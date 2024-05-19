using CityBuildings.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityBuildings.View.Panels
{
    /// <summary>
    /// Хранит данные о строениях.
    /// </summary>
    public partial class CityBuildingsControls : UserControl
    {
        private readonly List<Building> _cityBuildings = new List<Building>();
        private Building _currentBuilding;
        private bool _changesMade = false;
        private bool _confirmChanges = false;
        private string _filePath = @"C:\Users\Илья\source\repos\CityBuildings\CityBuildings\Model\Buildings.txt";
        private int _allowedIndex = -1;
        public CityBuildingsControls()
        {
            InitializeComponent();
            ReadInfoFromFile();
        }
        /// <summary>
        /// Считывает информацию с файла и добавляет в список и ListBox.
        /// </summary>
        private void ReadInfoFromFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(_filePath, true))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        Building building = new Building
                        {
                            Title = parts[0],
                            Adress = parts[1],
                            Category = parts[2],
                            Rating = double.Parse(parts[3])
                        };
                        _cityBuildings.Add(building);
                        CityBuildingsListBox.Items.Add($"{building.Category} - {building.Title}");
                    }
                }
            }
            catch { }
        }
        /// <summary>
        /// Редактирует выбранную строку в файле.
        /// </summary>
        /// <param name="selectedLine">Выбранная строка.</param>
        private void EditFile(int selectedLine)
        {
            string[] lines = File.ReadAllLines( _filePath);
            string[] parts = lines[selectedLine].Split(';');
            Building building = new Building
            {
                Title = parts[0],
                Adress = parts[1],
                Category = parts[2],
                Rating = double.Parse(parts[3])
            };
            lines[selectedLine] = $"{building.Title};{building.Adress};{building.Category};{building.Rating}";
        }
        /// <summary>
        /// Полностью очищает файл.
        /// </summary>
        private void ClearFile()
        {
            using (FileStream fs = new FileStream(_filePath, FileMode.Truncate))
            {
                fs.SetLength(0);
            }
        }
        /// <summary>
        /// Удаляет выбранную строку из файла.
        /// </summary>
        /// <param name="selectedLine">Выбранная строка.</param>
        private void DeleteLineFromFile(int selectedLine)
        {
            string[] lines = File.ReadAllLines(_filePath);
            var linesList = new List<string>(lines);
            linesList.RemoveAt(selectedLine);
            lines = linesList.ToArray();
            SortBuildingsListBox();
        }
        /// <summary>
        /// Записывает новую информацию в файл.
        /// </summary>
        /// <param name="building">Переданная информация.</param>
        private void WriteInfoInFile(Building building)
        {
            using (StreamWriter write = new StreamWriter(_filePath, true))
            {
                write.WriteLine($"{building.Title};{building.Adress};{building.Category};{building.Rating}");
            }
        }
        /// <summary>
        /// Сортирует значения в ListBox по принципу "Категория - Название"
        /// </summary>
        private void SortBuildingsListBox()
        {
            ClearFile();
            CityBuildingsListBox.Items.Clear();
            _cityBuildings.Sort((x, y) =>
            {
                int result = x.Category.CompareTo(y.Category);
                if (result == 0)
                {
                    result = x.Title.CompareTo(y.Title);
                }
                return result;
            });
            foreach (Building building in _cityBuildings)
            {
                CityBuildingsListBox.Items.Add($"{building.Category} - {building.Title}");
                WriteInfoInFile(building);
            }
        }
        /// <summary>
        /// Очищает информацию о заведении в TextBox и ComboBox.
        /// </summary>
        private void ClearBuildingInfo()
        {
            titleTextBox.Text = "";
            adressTextBox.Text = "";
            ratingTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
        }
        /// <summary>
        /// Обновляет значения в ListBox.
        /// </summary>
        private void UpdateBuildingListBox()
        {
            CityBuildingsListBox.Items.Clear();
            foreach (Building building in _cityBuildings)
            {
                CityBuildingsListBox.Items.Add($"{building.Category} - {building.Title}");
            }
            SortBuildingsListBox();
        }
        /// <summary>
        /// Отображает данные заведения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CityBuildingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CityBuildingsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _currentBuilding = _cityBuildings[selectedIndex];
                titleTextBox.Text = _currentBuilding.Title;
                adressTextBox.Text = _currentBuilding.Adress;
                categoryComboBox.SelectedItem = _currentBuilding.Category;
                ratingTextBox.Text = _currentBuilding.Rating.ToString();
                _changesMade = true;
                if (_confirmChanges)
                {
                    if (selectedIndex != _allowedIndex)
                    {
                        MessageBox.Show($"You did not confirm changes. Choose {_allowedIndex + 1} building and press Edit to confirm chages.");
                        editButton.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Press Edit to confirm changes");
                        editButton.Enabled = true;
                    }
                }
            }
        }
        /// <summary>
        /// Выбор категории.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = (string)categoryComboBox.SelectedItem;
            if (_currentBuilding != null)
            {
                if (!_changesMade)
                {
                    ComboBox currentCategoryComboBox = (ComboBox)sender;
                    string originalChoose = (string)categoryComboBox.Tag;
                    if (currentCategoryComboBox.Text != originalChoose)
                    {
                        _currentBuilding.Category = category;
                    }
                }
            }
        }
        /// <summary>
        /// Изменение и сохранение нового рейтинга заведения с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double rating = double.Parse(ratingTextBox.Text);
                if (_currentBuilding != null)
                {
                    if (rating < 0 || rating > 5)
                    {
                        throw new FormatException();
                    }
                    if (!_changesMade)
                    {
                        TextBox currentTextBox = (TextBox)sender;
                        string originalText = (string)currentTextBox.Tag;
                        if (currentTextBox.Text != originalText)
                        {
                            _currentBuilding.Rating = rating;
                            ratingTextBox.BackColor = AppColors.ValidatorTrueColor;
                        }
                    }
                }
                else if (rating < 0 || rating > 5)
                {
                    throw new FormatException();
                }
                ratingTextBox.BackColor = AppColors.ValidatorTrueColor;
            }
            catch (FormatException)
            {
                ratingTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение нового названия заведения с его валидацией. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string title = titleTextBox.Text;
                if (_currentBuilding != null)
                {
                    if (string.IsNullOrEmpty(title) || title.Length > 200)
                    {
                        throw new FormatException();
                    }
                    if (!_changesMade)
                    {
                        TextBox currentTextBox = (TextBox)sender;
                        string originalText = (string)currentTextBox.Tag;
                        if (currentTextBox.Text != originalText)
                        {
                            _currentBuilding.Title = title;
                            titleTextBox.BackColor = AppColors.ValidatorTrueColor;
                        }
                    }
                }
                else if (string.IsNullOrEmpty(title) || title.Length > 200)
                {
                    throw new FormatException();
                }
                titleTextBox.BackColor = AppColors.ValidatorTrueColor;
            }
            catch (FormatException)
            {
                titleTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение нового адреса заведения с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void adressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string adress = adressTextBox.Text;
                if (_currentBuilding != null)
                {
                    if (string.IsNullOrEmpty(adress) || adress.Length > 100)
                    {
                        throw new FormatException();
                    }
                    if (!_changesMade)
                    {
                        TextBox currentTextBox = (TextBox)sender;
                        string originalText = (string)currentTextBox.Tag;
                        if (currentTextBox.Text != originalText)
                        {
                            _currentBuilding.Adress = adress;
                            adressTextBox.BackColor = AppColors.ValidatorTrueColor;
                        }
                    }
                }
                else if (string.IsNullOrEmpty(adress) || adress.Length > 100)
                {
                    throw new FormatException();
                }
                adressTextBox.BackColor = AppColors.ValidatorTrueColor;
            }
            catch (FormatException)
            {
                adressTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Добавляет новое заведение в ListBox и файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = categoryComboBox.SelectedIndex;
            string title = titleTextBox.Text;
            string adress = adressTextBox.Text;
            if (Validator.AssertOnLengthRange(title, 200) && Validator.AssertOnLengthRange(adress, 100)
                && selectedIndex != -1 && ratingTextBox.BackColor == AppColors.ValidatorTrueColor)
            {
                string category = categoryComboBox.Items[selectedIndex].ToString();
                double rating = double.Parse(ratingTextBox.Text);
                Building building = new Building(title, adress, category, rating);
                _cityBuildings.Add(building);
                SortBuildingsListBox();
                ClearBuildingInfo();
            }
        }
        /// <summary>
        /// Удаляет выбранное заведение из ListBox'а и файла.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (CityBuildingsListBox.SelectedIndex != -1)
            {
                int selectedIndex = CityBuildingsListBox.SelectedIndex;
                ClearBuildingInfo();
                CityBuildingsListBox.Items.RemoveAt(selectedIndex);
                _cityBuildings.RemoveAt(selectedIndex);
                DeleteLineFromFile(selectedIndex);
            }
            else
            {
                MessageBox.Show("Choose the building that you want to delete");
            }
        }
        /// <summary>
        /// Редактирует значения выбранного заведения в ListBox'е и файле.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = CityBuildingsListBox.SelectedIndex;
            if (selectedIndex != - 1)
            {
                _changesMade = false;
                _cityBuildings[selectedIndex].Title = _currentBuilding.Title;
                _cityBuildings[selectedIndex].Adress = _currentBuilding.Adress;
                _cityBuildings[selectedIndex].Category = _currentBuilding.Category;
                _cityBuildings[selectedIndex].Rating = _currentBuilding.Rating;
                EditFile(selectedIndex);
                UpdateBuildingListBox();
                _allowedIndex = selectedIndex;
                if (!_confirmChanges)
                {
                    _confirmChanges = true;
                    addButton.Enabled = false;
                    deleteButton.Enabled = false;
                }
                else
                {
                    addButton.Enabled = true;
                    deleteButton.Enabled = true;
                    _confirmChanges = false;
                    _allowedIndex = -1;
                }
            }
        }
    }
}
