﻿using System;
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
    public partial class ItemsTab : UserControl
    {
        private readonly List<Item> _items = new();
        private Item _currentItem;
        public ItemsTab()
        {
            InitializeComponent();
            foreach (Category category in Enum.GetValues(typeof(Category)))
            {
                categoryComboBox.Items.Add(category);
            }
        }
        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ItemsListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _currentItem = _items[selectedIndex];
                IdTextBox.Text = _currentItem.Id.ToString();
                categoryComboBox.SelectedItem = _currentItem.Category;
                CostTextBox.Text = _currentItem.Cost.ToString();
                NameTextBox.Text = _currentItem.Name;
                DescriptionTextBox.Text = _currentItem.Info;
            }
        }
        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double cost = double.Parse(CostTextBox.Text);
                if (cost < 0 || cost > 100000)
                {
                    throw new ArgumentOutOfRangeException();
                }
                CostTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                CostTextBox.BackColor = Color.LightPink;
            }
            catch (ArgumentOutOfRangeException)
            {
                CostTextBox.BackColor = Color.LightPink;
            }
        }
        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string name = NameTextBox.Text;
                if (name.Length > 200 || name.Length == 0)
                {
                    throw new FormatException();
                }
                NameTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                NameTextBox.BackColor = Color.LightPink;
            }
        }
        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string info = DescriptionTextBox.Text;
                if (info.Length > 1000 || info.Length == 0)
                {
                    throw new FormatException();
                }
                DescriptionTextBox.BackColor = Color.White;
            }
            catch (FormatException)
            {
                DescriptionTextBox.BackColor = Color.LightPink;
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            double cost = double.Parse(CostTextBox.Text);
            string name = NameTextBox.Text;
            string description = DescriptionTextBox.Text;
            Category category = (Category)categoryComboBox.SelectedItem;
            if (name != "" && description != "")
            {
                Item item = new Item(name, description, cost, category);
                _items.Add(item);
                ItemsListBox.Items.Add($"{item.Name} - {item.Cost}");
            }

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = ItemsListBox.SelectedIndex;
                ItemsListBox.Items.RemoveAt(selectedIndex);
                _items.RemoveAt(selectedIndex);
                IdTextBox.Text = "";
                NameTextBox.Text = "";
                CostTextBox.Text = "";
                DescriptionTextBox.Text = "";
                categoryComboBox.SelectedItem = null;
            }
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
