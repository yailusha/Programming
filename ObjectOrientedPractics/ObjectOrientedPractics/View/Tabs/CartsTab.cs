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
        private Cart _currentCart;
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
    }
}
