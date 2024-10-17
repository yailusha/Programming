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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит данные о покупателях.
    /// </summary>
    internal partial class CustomersTab : UserControl
    {
        private readonly List<Customer> _customers = new List<Customer>();
        private Customer _currentCustomer = new Customer();
        public CustomersTab()
        {
            InitializeComponent();
        }
        private void UpdateCustomersListBox()
        {
            CustomersListBox.Items.Clear();
            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"{customer.Id}. {customer.Fullname}");
            }
        }
        private void ClearInfo()
        {
            idTextBox.Clear();
            fullnameTextBox.Clear();
            addressControl1.ClearInfo();
        }
        /// <summary>
        /// Отображает данные покупателей.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _currentCustomer = _customers[selectedIndex];
                idTextBox.Text = _currentCustomer.Id.ToString();
                fullnameTextBox.Text = _currentCustomer.Fullname;
                addressControl1.Address = _currentCustomer.Address;
                
            }
        }
        /// <summary>
        /// Изменение и сохранение нового полного имени покупателя с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;
            try
            {
                fullnameTextBox.BackColor = Color.White;
                string fullname = fullnameTextBox.Text;
                _currentCustomer.Fullname = fullname;
                UpdateCustomersListBox();
            }
            catch 
            {
                fullnameTextBox.BackColor = Color.LightPink;
            }
        }
        /// <summary>
        /// Добавляет нового покупателя в LixtBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            string fullname = fullnameTextBox.Text;
            Address address = addressControl1.Address;
            if (fullname != "" && address != null)
            {
                _currentCustomer = new Customer (fullname, address);
                _customers.Add(_currentCustomer);
                CustomersListBox.Items.Add($"{_currentCustomer.Id}. {_currentCustomer.Fullname}");
                ClearInfo();
            }
        }
        /// <summary>
        /// Убирает выбранного покупателя из ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                CustomersListBox.Items.RemoveAt(selectedIndex);
                _customers.RemoveAt(selectedIndex);
                ClearInfo();
            }
        }
    }
}
