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
