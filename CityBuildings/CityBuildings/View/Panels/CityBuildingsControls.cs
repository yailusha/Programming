using CityBuildings.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double rating = double.Parse(ratingTextBox.Text);
                if (rating < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _currentBuilding.Rating = rating;
                ratingTextBox.BackColor = AppColors.ValudatorTrueColor;
            }
            catch (FormatException)
            {
                ratingTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
    }
}
