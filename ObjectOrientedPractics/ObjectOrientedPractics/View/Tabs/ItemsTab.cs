using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;


namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит данные о товарах.
    /// </summary>
    internal partial class ItemsTab : UserControl
    {
        private List<Item> _items = new List<Item>();
        private Item _currentItem;
        public List<Item> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                ItemsListBox.Items.AddRange(_items.ToArray());
                UpdateItemsListBox();
            }
        }
        public ItemsTab()
        {
            InitializeComponent();
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category);
            }
        }
        private void UpdateItemsListBox()
        {
            ItemsListBox.Items.Clear();
            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Name} - {item.Cost}");
            }
        }
        /// <summary>
        /// Отображает данные товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _currentItem = _items[selectedIndex];
                idTextBox.Text = _currentItem.Id.ToString();
                CategoryComboBox.SelectedItem = _currentItem.Category;
                costTextBox.Text = _currentItem.Cost.ToString();
                nameTextBox.Text = _currentItem.Name;
                descriptionTextBox.Text = _currentItem.Info;
            }
        }
        /// <summary>
        /// Выбор категории товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Изменение и сохранение новой стоимости товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void costTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            try
            {
                costTextBox.BackColor = Color.White;
                double cost = double.Parse(costTextBox.Text);
                _currentItem.Cost = cost;
                UpdateItemsListBox();
            }
            catch 
            {
                costTextBox.BackColor = Color.LightPink;
            }
        }
        /// <summary>
        /// Сохранение и изменение нового названия товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (ItemsListBox.SelectedIndex == -1) return;
                nameTextBox.BackColor = Color.White;
                string name = nameTextBox.Text;
                _currentItem.Name = name;
                UpdateItemsListBox();
                
            }
            catch (FormatException)
            {
                nameTextBox.BackColor = Color.LightPink;
            }
        }
        /// <summary>
        /// Сохранение и изменения нового описания товара.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1) return;
            try
            {
                descriptionTextBox.BackColor = Color.White;
                string info = descriptionTextBox.Text;
                _currentItem.Info = info;
                UpdateItemsListBox();
            }
            catch (FormatException)
            {
                descriptionTextBox.BackColor = Color.LightPink;
            }
        }
        /// <summary>
        /// Добавляет новый товар в ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            double cost = double.Parse(costTextBox.Text);
            string name = nameTextBox.Text;
            string description = descriptionTextBox.Text;
            Category category = (Category)CategoryComboBox.SelectedItem;
            if (name != "" && description != "")
            {
                Item item = new Item(name, description, cost, category);
                _items.Add(item);
                ItemsListBox.Items.Add($"{item.Name} - {item.Cost}");
            }

        }
        /// <summary>
        /// Убирает выбранный товар.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;
                ItemsListBox.Items.RemoveAt(selectedIndex);
                _items.RemoveAt(selectedIndex);
                idTextBox.Text = "";
                nameTextBox.Text = "";
                costTextBox.Text = "";
                descriptionTextBox.Text = "";
                CategoryComboBox.SelectedItem = null;
            }
        }
    }
}
