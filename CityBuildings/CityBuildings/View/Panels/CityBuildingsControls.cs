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
        public CityBuildingsControls()
        {
            InitializeComponent();
        }
        private void SortListBox()
        {
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
            }
        }
        private void ClearBuildingInfo()
        {
            titleTextBox.Text = "";
            adressTextBox.Text = "";
            ratingTextBox.Text = "";
            categoryComboBox.SelectedIndex = -1;
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
                    _currentBuilding.Rating = rating;
                    ratingTextBox.BackColor = AppColors.ValidatorTrueColor;
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
                    _currentBuilding.Title = title;
                    titleTextBox.BackColor = AppColors.ValidatorTrueColor;
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
                    _currentBuilding.Adress = adress;
                    adressTextBox.BackColor = AppColors.ValidatorTrueColor;
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
            int selectedIndex = categoryComboBox.SelectedIndex;
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
                SortListBox();
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
            }
        }
    }
}
