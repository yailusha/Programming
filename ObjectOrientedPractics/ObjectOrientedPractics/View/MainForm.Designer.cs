namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Model.Address address1 = new Model.Address();
            customerPage = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            itemsPage = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            tabControl1 = new TabControl();
            cartsPage = new TabPage();
            cartsTab1 = new View.Tabs.CartsTab();
            ordersPage = new TabPage();
            ordersTab1 = new View.Tabs.OrdersTab();
            addressControl1 = new View.Controls.AddressControl();
            customerPage.SuspendLayout();
            itemsPage.SuspendLayout();
            tabControl1.SuspendLayout();
            cartsPage.SuspendLayout();
            ordersPage.SuspendLayout();
            SuspendLayout();
            // 
            // customerPage
            // 
            customerPage.Controls.Add(customersTab1);
            customerPage.Location = new Point(4, 24);
            customerPage.Name = "customerPage";
            customerPage.Padding = new Padding(3);
            customerPage.Size = new Size(942, 699);
            customerPage.TabIndex = 1;
            customerPage.Text = "Customers";
            customerPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Margin = new Padding(3, 4, 3, 4);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(936, 693);
            customersTab1.TabIndex = 0;
            // 
            // itemsPage
            // 
            itemsPage.Controls.Add(itemsTab1);
            itemsPage.Location = new Point(4, 24);
            itemsPage.Name = "itemsPage";
            itemsPage.Padding = new Padding(3);
            itemsPage.Size = new Size(942, 699);
            itemsPage.TabIndex = 0;
            itemsPage.Text = "Items";
            itemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Margin = new Padding(3, 4, 3, 4);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(936, 693);
            itemsTab1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(itemsPage);
            tabControl1.Controls.Add(customerPage);
            tabControl1.Controls.Add(cartsPage);
            tabControl1.Controls.Add(ordersPage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(950, 727);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedTabChanged;
            // 
            // cartsPage
            // 
            cartsPage.Controls.Add(cartsTab1);
            cartsPage.Location = new Point(4, 24);
            cartsPage.Name = "cartsPage";
            cartsPage.Size = new Size(942, 699);
            cartsPage.TabIndex = 2;
            cartsPage.Text = "Carts";
            cartsPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(0, 0);
            cartsTab1.Margin = new Padding(3, 4, 3, 4);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(942, 699);
            cartsTab1.TabIndex = 0;
            // 
            // ordersPage
            // 
            ordersPage.Controls.Add(ordersTab1);
            ordersPage.Location = new Point(4, 24);
            ordersPage.Name = "ordersPage";
            ordersPage.Size = new Size(942, 699);
            ordersPage.TabIndex = 3;
            ordersPage.Text = "Orders";
            ordersPage.UseVisualStyleBackColor = true;
            // 
            // ordersTab1
            // 
            ordersTab1.Dock = DockStyle.Fill;
            ordersTab1.Location = new Point(0, 0);
            ordersTab1.Name = "ordersTab1";
            ordersTab1.Size = new Size(942, 699);
            ordersTab1.TabIndex = 0;
            // 
            // addressControl1
            // 
            address1.Apartment = "Apartment";
            address1.Building = "Building";
            address1.City = "City";
            address1.Country = "Country";
            address1.Index = 100000;
            address1.Street = "Street";
            addressControl1.Address = address1;
            addressControl1.ApartmentValue = "";
            addressControl1.BuildingValue = "";
            addressControl1.CityValue = "";
            addressControl1.CountryValue = "";
            addressControl1.Location = new Point(0, 0);
            addressControl1.Margin = new Padding(3, 4, 3, 4);
            addressControl1.Name = "addressControl1";
            addressControl1.PostIndexValue = "";
            addressControl1.Size = new Size(594, 241);
            addressControl1.StreetValue = "";
            addressControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 727);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "MainForm";
            //FormClosing += MainForm_FormClosing;
            customerPage.ResumeLayout(false);
            itemsPage.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            cartsPage.ResumeLayout(false);
            ordersPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage customerPage;
        private View.Tabs.CustomersTab customersTab1;
        private TabPage itemsPage;
        private View.Tabs.ItemsTab itemsTab1;
        private TabControl tabControl1;
        private TabPage cartsPage;
        private View.Tabs.CartsTab cartsTab1;
        private TabPage ordersPage;
        private View.Controls.AddressControl addressControl1;
        private View.Tabs.OrdersTab ordersTab1;
    }
}
