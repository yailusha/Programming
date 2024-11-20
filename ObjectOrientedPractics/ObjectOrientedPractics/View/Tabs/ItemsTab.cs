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
using System.Linq.Expressions;
using System.Web;

namespace ObjectOrientedPractics.View.Tabs
{
    internal partial class ItemsTab : UserControl
    {
        List<Item> _items = new List<Item>();
        List<Item> _displayedItems = new List<Item>();
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
                _displayedItems = _items;
                ItemsListBox.Items.AddRange(_displayedItems.ToArray());
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
        }
        public event EventHandler ItemsChanged;
        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        private void UpdateInfo()
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            ItemsListBox.Items.Clear();
            ItemsListBox.Items.AddRange(_displayedItems.ToArray());
            if (index != -1)
            {
                ItemsListBox.SelectedIndex = index;
            }
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
        private void Sort()
        {
            List<Item> sortedItems;

            switch (SortComboBox.SelectedIndex)
            {
                case 1:
                    sortedItems = DataTools.Sort(_displayedItems, (item1, item2) => item1.Cost < item2.Cost);
                    break;
                case 2:
                    sortedItems = DataTools.Sort(_displayedItems, (item1, item2) => item1.Cost > item2.Cost);
                    break;
                default:
                    sortedItems = DataTools.Sort(_displayedItems, (item1, item2) => string.Compare(item1.Name, item2.Name) > 0);
                    break;
            }
            _displayedItems = sortedItems;
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
            UpdateInfo();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.Items.IndexOf(_currentItem);
            if (index == -1) return;
            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);
            ClearInfo();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                nameTextBox.BackColor = Color.White;
                string name = nameTextBox.Text.ToString();
                _currentItem.Name = name;
                UpdateInfo();
                ItemsChanged?.Invoke(this, EventArgs.Empty);
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
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                descriptionTextBox.BackColor = Color.LightPink;
            }
        }
        private void findTextBox_TextChanged(object sender, EventArgs e)
        {
            string findText = findTextBox.Text.ToLower();
            if (string.IsNullOrEmpty(findText))
            {
                _displayedItems = _items;
                ItemsListBox.Items.Clear();
                ItemsListBox.Items.AddRange(_displayedItems.ToArray());
            }
            else
            {
                List<Item> filteredItems = DataTools.Filter(_items, item => item.Name.ToLower().Contains(findText));
                _displayedItems = filteredItems;
                ItemsListBox.Items.Clear();
                ItemsListBox.Items.AddRange(_displayedItems.ToArray());
            }
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

        private void SortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sort();
            UpdateInfo();
        }
    }
}