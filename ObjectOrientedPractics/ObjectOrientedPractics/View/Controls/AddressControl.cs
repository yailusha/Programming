using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;
        public AddressControl()
        {
            InitializeComponent();
            _address = new Address();
        }
        private Address Address { get; set; }

        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int postIndex = int.Parse(postIndexTextBox.Text);
                if (postIndex < 100000 || postIndex > 999999)
                {
                    throw new ArgumentOutOfRangeException();
                }
                postIndexTextBox.Text = postIndex.ToString();
                postIndexTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                postIndexTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                postIndexTextBox.BackColor = Color.LightPink;
            }
        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string country = countryTextBox.Text;
                if (country.Length > 50 || country.Length == 0)
                {
                    throw new FormatException();
                }
                countryTextBox.Text = country.ToString();
                countryTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                countryTextBox.BackColor = Color.LightPink;
            }
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string city = cityTextBox.Text;
                if (city.Length > 50 || city.Length == 0)
                {
                    throw new FormatException();
                }
                cityTextBox.Text = city.ToString();
                cityTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                cityTextBox.BackColor = Color.LightPink;
            }
        }

        private void streetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string street = streetTextBox.Text;
                if (street.Length > 100 || street.Length == 0)
                {
                    throw new FormatException();
                }
                streetTextBox.Text = street.ToString();
                streetTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                streetTextBox.BackColor = Color.LightPink;
            }
        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string building = buildingTextBox.Text;
                if (building.Length > 10 || building.Length == 0)
                {
                    throw new FormatException();
                }
                buildingTextBox.Text = building.ToString();
                buildingTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                buildingTextBox.BackColor = Color.LightPink;
            }
        }

        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string apartment = apartmentTextBox.Text;
                if (apartment.Length > 10 || apartment.Length == 0)
                {
                    throw new FormatException();
                }
                apartmentTextBox.Text = apartment.ToString();
                apartmentTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                apartmentTextBox.BackColor = Color.LightPink;
            }
        }
    }
}
