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

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        private readonly List<Customer> _customers = new();
        private Customer _currentCustomer;
        public CustomersTab()
        {
            InitializeComponent();
        }
        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = CustomersListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _currentCustomer = _customers[selectedIndex];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                AddressTextBox.Text = _currentCustomer.Address;
                FullnameTextBox.Text = _currentCustomer.Fullname;
            }
        }
        private void FullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string fullname = FullnameTextBox.Text;
                if (fullname.Length > 200 || fullname.Length == 0)
                {
                    throw new FormatException();
                }
                FullnameTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                FullnameTextBox.BackColor = Color.LightPink;
            }
        }
        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string address = AddressTextBox.Text;
                if (address.Length > 500 || address.Length == 0)
                {
                    throw new FormatException();
                }
                AddressTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                AddressTextBox.BackColor = Color.LightPink;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            string fullname = FullnameTextBox.Text;
            string address = AddressTextBox.Text;
            if (fullname != "" && address != "")
            {
                Customer customer = new Customer(fullname, address);
                _customers.Add(customer);
                CustomersListBox.Items.Add($"{customer.Fullname} - {customer.Address}");
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int selectedIndex = CustomersListBox.SelectedIndex;
                CustomersListBox.Items.RemoveAt(selectedIndex);
                _customers.RemoveAt(selectedIndex);
                IdTextBox.Text = "";
                AddressTextBox.Text = "";
                FullnameTextBox.Text = "";
            }
        }
    }
}
