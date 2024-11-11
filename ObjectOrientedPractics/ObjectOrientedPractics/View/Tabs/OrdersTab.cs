using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
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
        List<Customer> _customers = new List<Customer>();
        List<Order> _orders = new List<Order>();
        Order _currentOrder = new Order(false);
        PriorityOrder _currentPriorityOrder = new PriorityOrder(false);
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
            foreach (DeliveryTimeRange time in Enum.GetValues(typeof(DeliveryTimeRange)))
                DeliveryTimeComboBox.Items.Add(time);
            foreach (OrderStatus status in Enum.GetValues(typeof(OrderStatus)))
                StatusComboBox.Items.Add(status);
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
                    if (order is PriorityOrder)
                    {
                        row.Cells["Priority"].Value = "✔";
                    }
                    row.Cells["IdColumn"].Value = order.Id;
                    row.Cells["CreatedColumn"].Value = $"{order.OrderCreationDate.Day}:{order.OrderCreationDate.Month}:{order.OrderCreationDate.Year}";
                    row.Cells["FullnameColumn"].Value = customer.Fullname;
                    row.Cells["AddressColumn"].Value = order.Address.ToString();
                    row.Cells["AmountColumn"].Value = order.Amount;
                    row.Cells["StatusColumn"].Value = order.Status;
                }
            }
        }
        private void OrdersDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = OrdersDataGrid.SelectedCells[0].RowIndex;
            var orderType = _orders[rowIndex].GetType();
            if (orderType == typeof(PriorityOrder))
            {
                _currentOrder = _orders[OrdersDataGrid.SelectedCells[0].RowIndex];
                _currentPriorityOrder = (PriorityOrder)_orders[OrdersDataGrid.SelectedCells[0].RowIndex];
                idTextBox.Text = _currentOrder.Id.ToString();
                createdTextBox.Text = $"{_currentOrder.OrderCreationDate.Day}.{_currentOrder.OrderCreationDate.Month}.{_currentOrder.OrderCreationDate.Year}";
                StatusComboBox.SelectedIndex = (int)_currentOrder.Status;
                addressControl1.Address = _currentOrder.Address;
                amountLabel.Text = _currentOrder.Amount.ToString();
                PriorityPanel.Visible = true;
                OrderItemsListBox.Items.Clear();
                OrderItemsListBox.Items.AddRange(_currentOrder.Items.ToArray());
            }
            else
            {
                _currentOrder = _orders[OrdersDataGrid.SelectedCells[0].RowIndex];
                _currentPriorityOrder = null;
                idTextBox.Text = _currentOrder.Id.ToString();
                createdTextBox.Text = $"{_currentOrder.OrderCreationDate.Day}.{_currentOrder.OrderCreationDate.Month}.{_currentOrder.OrderCreationDate.Year}";
                StatusComboBox.SelectedIndex = (int)_currentOrder.Status;
                addressControl1.Address = _currentOrder.Address;
                amountLabel.Text = _currentOrder.Amount.ToString();
                PriorityPanel.Visible = false;
                OrderItemsListBox.Items.Clear();
                OrderItemsListBox.Items.AddRange(_currentOrder.Items.ToArray());
            }

        }

        private void addressControl1_Load(object sender, EventArgs e)
        {
            addressControl1.ReadOnly();
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeliveryTimeComboBox.SelectedIndex == -1) return;
            Array deliveryTime = Enum.GetValues(typeof(DeliveryTimeRange));
            _currentPriorityOrder.DesiredDeliveryTime = (DeliveryTimeRange)deliveryTime.GetValue(DeliveryTimeComboBox.SelectedIndex);

        }
    }
}
