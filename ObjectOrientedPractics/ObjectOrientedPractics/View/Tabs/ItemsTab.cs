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
using ObjectOrientedPractics.Services;
using System.Text.Json;
using ObjectOrientedPractics.Model.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class ItemsTab : UserControl
    {
        List<Item> _items = new List<Item>();
        Item _currentItem = new Item(false);
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                ItemsListBox.Items.AddRange(_items.ToArray());
                UpdateInfo();

            }
        }
        public ItemsTab()
        {
            InitializeComponent();
            var categories = Enum.GetValues(typeof(Category));
            foreach (var category in categories)
            {
                CategoryComboBox.Items.Add(category);
            }
            ItemsListBox.Items.AddRange(_items.ToArray());
        }
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            _currentItem = _items[ItemsListBox.SelectedIndex];
            Item item = (Item)ItemsListBox.SelectedItem;
            idTextBox.Text = item.Id.ToString();
            costTextBox.Text = item.Cost.ToString();
            nameTextBox.Text = item.Name.ToString();
            descriptionTextBox.Text = item.Info.ToString();
            CategoryComboBox.SelectedIndex = (int)item.Category;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Item item = new Item(true);
            _items.Add(item);
            ItemsListBox.Items.Add(item);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);
            ClearInfo();
        }

        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            try
            {
                costTextBox.BackColor = Color.White;
                double cost = double.Parse(costTextBox.Text);
                _currentItem.Cost = cost;
                UpdateInfo();
            }
            catch
            {
                costTextBox.BackColor = Color.LightPink;
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            try
            {
                costTextBox.BackColor = Color.White;
                string name = nameTextBox.Text.ToString();
                _currentItem.Name = name;
                UpdateInfo();
            }
            catch
            {
                nameTextBox.BackColor = Color.LightPink;
            }
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            try
            {
                descriptionTextBox.BackColor = Color.White;
                string description = descriptionTextBox.Text.ToString();
                _currentItem.Info = description;
                UpdateInfo();
            }
            catch
            {
                descriptionTextBox.BackColor = Color.LightPink;
            }
        }
        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        private void UpdateInfo()
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(_items.ToArray());
            ItemsListBox.SelectedIndex = index;
        }
        /// <summary>
        /// Очищает поля.
        /// </summary>
        private void ClearInfo()
        {
            nameTextBox.Clear();
            descriptionTextBox.Clear();
            costTextBox.Clear();
            idTextBox.Clear();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            try
            {
                CategoryComboBox.BackColor = Color.White;
                Category category = (Category)Enum.Parse(typeof(Category), CategoryComboBox.Text);
                _currentItem.Category = category;
                UpdateInfo();
            }
            catch
            {
                CategoryComboBox.BackColor = Color.LightPink;
            }
        }
    }
}