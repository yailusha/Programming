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
    internal partial class PriorityOrdersTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private PriorityOrder _priorityOrder = new PriorityOrder(false);
        public List<Item> Items
        {
            get { return _items; }
            set { _items = value; }
        }
        public PriorityOrdersTab()
        {
            InitializeComponent();
            foreach (var time in Enum.GetValues(typeof(DeliveryTimeRange)))
                DeliveryTimeComboBox.Items.Add(time);
            foreach (var status in Enum.GetValues(typeof(OrderStatus)))
                StatusComboBox.Items.Add(status);

            idTextBox.Text = _priorityOrder.Id.ToString();
            createdTextBox.Text = _priorityOrder.OrderCreationDate.ToString();
            StatusComboBox.SelectedItem = _priorityOrder.Status;
            addressControl1.Address = _priorityOrder.Address;
            OrderItemsListBox.Items.AddRange(_priorityOrder.Items.ToArray());

        }
        private void UpdateInfo()
        {
            OrderItemsListBox.Items.Clear();
            OrderItemsListBox.Items.AddRange(_priorityOrder.Items.ToArray());
            amountLabel.Text = _priorityOrder.Amount.ToString();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            _priorityOrder.Items.Add(Items[0]);
            UpdateInfo();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.SelectedIndex == -1) return;
            _priorityOrder.Items.RemoveAt(OrderItemsListBox.SelectedIndex);
            UpdateInfo();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //_priorityOrder = null;
            _priorityOrder = new PriorityOrder(false);
            UpdateInfo();
            idTextBox.Text = _priorityOrder.Id.ToString();
            createdTextBox.Text = _priorityOrder.OrderCreationDate.ToString();
            StatusComboBox.SelectedItem = _priorityOrder.Status;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _priorityOrder.Status = (OrderStatus)Enum.Parse(typeof(OrderStatus), StatusComboBox.Text);
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _priorityOrder.DesiredDeliveryTime = (DeliveryTimeRange)Enum.Parse(typeof(DeliveryTimeRange), DeliveryTimeComboBox.Text);
        }

        private void PriorityOrdersTab_Load(object sender, EventArgs e)
        {

        }
    }
}
