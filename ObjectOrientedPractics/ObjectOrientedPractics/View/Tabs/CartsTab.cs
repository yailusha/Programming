using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class CartsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private List<Customer> _customers = new List<Customer>();
        private Item _currentItem;
        private Customer _currentCustomer;
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                ItemsListBox.Items.AddRange(_items.ToArray());
            }
        }
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                CustomerComboBox.Items.AddRange(_customers.ToArray());
            }
        }
        public CartsTab()
        {
            InitializeComponent();
        }
        public void RefreshData()
        {
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(_items.ToArray());
            CustomerComboBox.Items.Clear();
            CustomerComboBox.Items.AddRange(_customers.ToArray());
        }
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            _currentItem = _items[ItemsListBox.SelectedIndex];
        }
        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentCustomer = _customers[CustomerComboBox.SelectedIndex];
            CartListBox.Items.Clear();
            CartListBox.Items.AddRange(_currentCustomer.Cart.Items.ToArray());
            amountLabel.Text = "0";
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1 || CustomerComboBox.SelectedIndex == -1) return;
            _currentCustomer.Cart.Items.Add(_currentItem);
            CartListBox.Items.Add(_currentItem);
            amountLabel.Text = _currentCustomer.Cart.Amount.ToString();
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (CustomerComboBox.SelectedIndex == -1 || CartListBox.SelectedIndex == -1) return;
            _currentCustomer.Cart.Items.RemoveAt(CartListBox.SelectedIndex);
            CartListBox.Items.RemoveAt(CartListBox.SelectedIndex);
            amountLabel.Text = _currentCustomer.Cart.Amount.ToString();

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (_currentCustomer == null) return;
            Order order = new Order(_currentCustomer.Address, new List<Item>(_currentCustomer.Cart.Items));
            _currentCustomer.Orders.Add(order);
            _currentCustomer.Cart.Items.Clear();
            CartListBox.Items.Clear();
            amountLabel.Text = "0";
        }
    }
}
