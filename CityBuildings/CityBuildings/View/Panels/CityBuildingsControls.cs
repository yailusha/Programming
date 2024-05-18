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
    public partial class CityBuildingsControls : UserControl
    {
        private readonly List<Building> _cityBuildings = new List<Building>();
        private Building _currentBuilding;
        private bool _changesMade = false;
        private string _filePath = @"C:\Users\Илья\source\repos\CityBuildings\CityBuildings\Model\Buildings.txt";
        public CityBuildingsControls()
        {
            InitializeComponent();
            ReadInfoFromFile();
        }
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
        private void ClearFile()
        {
            using (FileStream fs = new FileStream(_filePath, FileMode.Truncate))
            {
                fs.SetLength(0);
            }
        }
        private void DeleteLineFromFile(int selectedLine)
        {
            string[] lines = File.ReadAllLines(_filePath);
            var linesList = new List<string>(lines);
            linesList.RemoveAt(selectedLine);
            lines = linesList.ToArray();
            SortBuildingsListBox();
        }
        private void WriteInfoInFile(Building building)
        {
            using (StreamWriter write = new StreamWriter(_filePath, true))
            {
                write.WriteLine($"{building.Title};{building.Adress};{building.Category};{building.Rating}");
            }
        }
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
        private void ClearBuildingInfo()
        {
            titleTextBox.Text = "";
            adressTextBox.Text = "";
            ratingTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
        }
        private void UpdateBuildingListBox()
        {
            CityBuildingsListBox.Items.Clear();
            foreach (Building building in _cityBuildings)
            {
                CityBuildingsListBox.Items.Add($"{building.Category} - {building.Title}");
            }
            SortBuildingsListBox();
        }
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

        private void AddButton_Click(object sender, EventArgs e)
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CityBuildingsListBox.SelectedIndex != -1)
            {
                int selectedIndex = CityBuildingsListBox.SelectedIndex;
                ClearBuildingInfo();
                CityBuildingsListBox.Items.RemoveAt(selectedIndex);
                _cityBuildings.RemoveAt(selectedIndex);
                DeleteLineFromFile(selectedIndex);
            }
        }

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
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
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
            }
        }
    }
}
