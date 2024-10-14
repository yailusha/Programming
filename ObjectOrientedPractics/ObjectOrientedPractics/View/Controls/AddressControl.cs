using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
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
    /// <summary>
    /// Хранит данные об адресе покупателя
    /// </summary>
    public partial class AddressControl : UserControl
    {
        private Address _address = new Address();
        public Address Address
        {
            get { return _address; }
            set
            {
                _address = value;
                postIndexTextBox.Text = _address.Index.ToString();
                countryTextBox.Text = _address.Country;
                cityTextBox.Text = _address.City;
                streetTextBox.Text = _address.Street;
                buildingTextBox.Text = _address.Building;
                apartmentTextBox.Text = _address.Apartment;
            }
        }
        public AddressControl()
        {
            InitializeComponent();
            this.toolTip1 = new ToolTip();
        }
        public void ClearInfo()
        {
            postIndexTextBox.Clear();
            countryTextBox.Clear();
            cityTextBox.Clear();
            streetTextBox.Clear();
            buildingTextBox.Clear();
            apartmentTextBox.Clear();
            _address = new Address();
        }
        private Address Address { get; set; }

        private void postIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                postIndexTextBox.BackColor = Color.White;
                int postIndex = int.Parse(postIndexTextBox.Text);
                _address.Index = postIndex;
                }
            catch 
            {
                postIndexTextBox.BackColor = Color.LightPink;
                this.toolTip1.SetToolTip(this.postIndexTextBox, "Почтовый индекс должен быть шестизначным числом");
                
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
                countryTextBox.BackColor = Color.White;
                string country = countryTextBox.Text;
                _address.Country = country;
            }
            catch
            {
                countryTextBox.BackColor = Color.LightPink;
                this.toolTip1.SetToolTip(this.countryTextBox, "Длина страны может содержать максимум 50 символов.");
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
                string city = cityTextBox.Text;               
                _address.City = city;
            }
            catch 
            {
                cityTextBox.BackColor = Color.LightPink;
                this.toolTip1.SetToolTip(this.countryTextBox, "Длина строки может содержать максимум 50 символов");
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
                string street = streetTextBox.Text;                
                _address.Street = street;
            }
            catch
            {
                streetTextBox.BackColor = Color.LightPink;
                this.toolTip1.SetToolTip(this.streetTextBox, "Длина строки может содержать максимум 100 символов");
            }
        }

        private void buildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string building = buildingTextBox.Text;
                if (building.Length > 10  || building.Length == 0)
                {
                    throw new FormatException();
                }    
                buildingTextBox.Text = building.ToString();
                buildingTextBox.BackColor = Color.White;
                string building = buildingTextBox.Text;
                _address.Building = building;
            }
            catch 
            {
                buildingTextBox.BackColor = Color.LightPink;
                this.toolTip1.SetToolTip(this.buildingTextBox, "Длина строки может содержать максимум 10 символов");
            }
        }

        private void apartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string apartment = apartmentTextBox.Text;
                if (apartment.Length > 10 ||  apartment.Length == 0)
                {
                    throw new FormatException();
                }
                apartmentTextBox.Text = apartment.ToString();
                apartmentTextBox.BackColor = Color.White;
                string apartment = apartmentTextBox.Text;               
                _address.Apartment = apartment;
            }
            catch 
            {
                apartmentTextBox.BackColor = Color.LightPink;
                this.toolTip1.SetToolTip(apartmentTextBox, "Длина строки может содержать максимум 10 символов");
            }
        }

    }
}
