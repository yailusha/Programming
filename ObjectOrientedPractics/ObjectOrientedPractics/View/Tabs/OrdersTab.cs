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

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class OrdersTab : UserControl
    {
        private List<Customer> _customers = new List<Customer>();
        private List<Order> _orders = new List<Order>();
        private Order _currentOrder = new Order();
        public List<Customer> Customers
        {
            get { return _customers; }
            set
            {
                _customers = value;
                UpdateOrders();
            }
        }
        public OrdersTab()
        {
            InitializeComponent();
        }
        public void UpdateOrders()
        {
            _orders.Clear();
            OrdersDataGrid.Rows.Clear();
            foreach (Customer customer in _customers)
            {
                foreach (Order order in customer.Orders)
                {
                    _orders.Add(order);
                    int rowIndex = OrdersDataGrid.Rows.Add();
                    DataGridViewRow row = OrdersDataGrid.Rows[rowIndex];
                    row.Cells["IdColumn"].Value = order.Id;
                    row.Cells["CreatedColumn"].Value = $"{order.OrderCreationDate.Day}.{order.OrderCreationDate.Month}.{order.OrderCreationDate.Year}";
                    row.Cells["FullnameColumn"].Value = customer.Fullname;
                    row.Cells["AddressColumn"].Value = order.Address.ToString();
                    row.Cells["AmountColumn"].Value = order.Amount;
                    row.Cells["StatusColumn"].Value = order.Status;
                }
            }
        }
        public void OrdersDataGrid_RowHeaderMouseClick(object sender, DataColumnChangeEventArgs e)
        {
            _currentOrder = _orders[OrdersDataGrid.SelectedCells[0].RowIndex];
            idTextBox.Text = _currentOrder.Id.ToString();
            createdTextBox.Text = $"{_currentOrder.OrderCreationDate.Day}.{_currentOrder.OrderCreationDate.Month}.{_currentOrder.OrderCreationDate.Year}";
            StatusComboBox.SelectedIndex = (int)_currentOrder.Status;
            addressControl1.PostIndexValue = _currentOrder.Address.Index.ToString();
            addressControl1.CountryValue = _currentOrder.Address.Country;
            addressControl1.CityValue = _currentOrder.Address.City;
            addressControl1.StreetValue = _currentOrder.Address.Street;
            addressControl1.BuildingValue = _currentOrder.Address.Building;
            addressControl1.ApartmentValue = _currentOrder.Address.Apartment;
            amountLabel.Text = _currentOrder.Amount.ToString();
            OrderItemsListBox.Items.Clear();
            OrderItemsListBox.Items.AddRange(_currentOrder.Items.ToArray());
        }

        private void addressControl1_Load(object sender, EventArgs e)
        {
            addressControl1.ReadOnly();
        }
    }
}
