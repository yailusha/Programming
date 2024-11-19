using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class CustomersTab : UserControl
    {
        static List<Customer> _customers = new List<Customer>();
        Customer _currentCustomer = new Customer(false);
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                CustomersListBox.Items.AddRange(_customers.ToArray());
                UpdateInfo();
            }
        }
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;
            _currentCustomer = _customers[CustomersListBox.SelectedIndex];
            idTextBox.Text = _currentCustomer.Id.ToString();
            fullnameTextBox.Text = _currentCustomer.Fullname.ToString();
            addressControl1.Address = _currentCustomer.Address;
            IsPriorityCheckBox.Checked = _currentCustomer.IsPriority;
            DiscountsListBox.Items.Clear();
            DiscountsListBox.Items.AddRange(_currentCustomer.Discounts.ToArray());
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(true);
            _customers.Add(customer);
            CustomersListBox.Items.Add(customer);
        }

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.Items.IndexOf(_currentCustomer);
            if (index == -1) return;
            _customers.RemoveAt(index);
            CustomersListBox.Items.Remove(index);
            ClearInfo();
        }

        private void fullnameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.Items.IndexOf(_currentCustomer);
            if (index == -1) return;
            try
            {
                fullnameTextBox.BackColor = Color.White;
                string fullName = fullnameTextBox.Text.ToString();
                _currentCustomer.Fullname = fullName;
                UpdateInfo();
            }
            catch
            {
                fullnameTextBox.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// Обновляет информацию в списке
        /// </summary>
        private void UpdateInfo()
        {
            int index = CustomersListBox.Items.IndexOf(_currentCustomer);
            if (index == -1) return;
            CustomersListBox.Items.Clear();
            CustomersListBox.Items.AddRange(_customers.ToArray());
            DiscountsListBox.Items.Clear();
            DiscountsListBox.Items.AddRange(_currentCustomer.Discounts.ToArray());
            CustomersListBox.SelectedIndex = index;
        }
        /// <summary>
        /// Очищает поля.
        /// </summary>
        private void ClearInfo()
        {
            idTextBox.Clear();
            fullnameTextBox.Clear();
            addressControl1.ClearInfo();
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsPriorityCheckBox.Checked == true)
            {
                _currentCustomer.IsPriority = true;
            }
            else
            {
                _currentCustomer.IsPriority = false;
            }
        }

        private void addDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1) return;
            AddDiscountForm addDiscountForm = new AddDiscountForm();
            addDiscountForm.ShowDialog();
            if (addDiscountForm.Result == DialogResult.OK)
            {
                bool isContains = false;
                foreach (var discount in _currentCustomer.Discounts)
                {
                    if (discount is PercentDiscount percentDiscount1)
                    {
                        if (percentDiscount1.Category == addDiscountForm.SelectedCategory)
                        {
                            isContains = true;
                            break;
                        }
                    }
                }
                if (!isContains)
                {
                    _currentCustomer.Discounts.Add(new PercentDiscount(addDiscountForm.SelectedCategory));
                    UpdateInfo();
                }
            }
        }

        private void removeDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex == 0 || DiscountsListBox.SelectedIndex == -1 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
            UpdateInfo();
        }
    }
}