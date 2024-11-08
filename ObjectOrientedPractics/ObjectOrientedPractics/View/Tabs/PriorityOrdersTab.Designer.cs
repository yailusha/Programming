namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Model.Address address1 = new Model.Address();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            idTextBox = new TextBox();
            createdTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            label5 = new Label();
            label15 = new Label();
            DeliveryTimeComboBox = new ComboBox();
            addressControl1 = new Controls.AddressControl();
            label6 = new Label();
            OrderItemsListBox = new ListBox();
            label7 = new Label();
            amountLabel = new Label();
            AddButton = new Button();
            RemoveButton = new Button();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Selected Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 30);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 1;
            label2.Text = "ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 82);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 2;
            label3.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 56);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Created:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(67, 27);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(153, 23);
            idTextBox.TabIndex = 4;
            // 
            // createdTextBox
            // 
            createdTextBox.Location = new Point(67, 53);
            createdTextBox.Name = "createdTextBox";
            createdTextBox.ReadOnly = true;
            createdTextBox.Size = new Size(153, 23);
            createdTextBox.TabIndex = 5;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(67, 79);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(153, 23);
            StatusComboBox.TabIndex = 6;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(258, 0);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 7;
            label5.Text = "Priority Options";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(258, 30);
            label15.Name = "label15";
            label15.Size = new Size(81, 15);
            label15.TabIndex = 8;
            label15.Text = "Delivery Time:";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(345, 27);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(153, 23);
            DeliveryTimeComboBox.TabIndex = 9;
            DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // addressControl1
            // 
            address1.Apartment = "0";
            address1.Building = "0";
            address1.City = "City";
            address1.Country = "Country";
            address1.Index = 100000;
            address1.Street = "Street";
            addressControl1.Address = address1;
            addressControl1.ApartmentValue = "";
            addressControl1.BuildingValue = "";
            addressControl1.CityValue = "";
            addressControl1.CountryValue = "";
            addressControl1.Location = new Point(0, 108);
            addressControl1.Name = "addressControl1";
            addressControl1.PostIndexValue = "";
            addressControl1.Size = new Size(520, 181);
            addressControl1.StreetValue = "";
            addressControl1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(3, 292);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 11;
            label6.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(3, 311);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(495, 229);
            OrderItemsListBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(438, 543);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 13;
            label7.Text = "Amount:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountLabel.Location = new Point(438, 571);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(25, 30);
            amountLabel.TabIndex = 14;
            amountLabel.Text = "0";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 604);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(125, 53);
            AddButton.TabIndex = 15;
            AddButton.Text = "Add Item";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(134, 604);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(125, 53);
            RemoveButton.TabIndex = 16;
            RemoveButton.Text = "Remove Item";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(373, 604);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(125, 53);
            ClearButton.TabIndex = 17;
            ClearButton.Text = "Clear Order";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ClearButton);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(amountLabel);
            Controls.Add(label7);
            Controls.Add(OrderItemsListBox);
            Controls.Add(label6);
            Controls.Add(addressControl1);
            Controls.Add(DeliveryTimeComboBox);
            Controls.Add(label15);
            Controls.Add(label5);
            Controls.Add(StatusComboBox);
            Controls.Add(createdTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PriorityOrdersTab";
            Size = new Size(505, 678);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox idTextBox;
        private TextBox createdTextBox;
        private ComboBox StatusComboBox;
        private Label label5;
        private Label label15;
        private ComboBox DeliveryTimeComboBox;
        private Controls.AddressControl addressControl1;
        private Label label6;
        private ListBox OrderItemsListBox;
        private Label label7;
        private Label amountLabel;
        private Button AddButton;
        private Button RemoveButton;
        private Button ClearButton;
    }
}
