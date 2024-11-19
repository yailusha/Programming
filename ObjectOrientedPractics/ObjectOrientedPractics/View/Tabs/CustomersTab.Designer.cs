namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            fullnameTextBox = new TextBox();
            idTextBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            removeCustomerButton = new Button();
            addCustomerButton = new Button();
            CustomersListBox = new ListBox();
            label7 = new Label();
            addressControl1 = new Controls.AddressControl();
            IsPriorityCheckBox = new CheckBox();
            label1 = new Label();
            DiscountsListBox = new ListBox();
            addDiscountButton = new Button();
            removeDiscountButton = new Button();
            SuspendLayout();
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(424, 63);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(451, 23);
            fullnameTextBox.TabIndex = 26;
            fullnameTextBox.TextChanged += fullnameTextBox_TextChanged;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(424, 34);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(134, 23);
            idTextBox.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(355, 66);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 23;
            label10.Text = "Full Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(355, 36);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 22;
            label9.Text = "ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(355, 0);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 21;
            label8.Text = "Selected Customer";
            // 
            // removeCustomerButton
            // 
            removeCustomerButton.Location = new Point(138, 576);
            removeCustomerButton.Name = "removeCustomerButton";
            removeCustomerButton.Size = new Size(132, 61);
            removeCustomerButton.TabIndex = 20;
            removeCustomerButton.Text = "Remove";
            removeCustomerButton.UseVisualStyleBackColor = true;
            removeCustomerButton.Click += removeCustomerButton_Click;
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(0, 576);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(132, 61);
            addCustomerButton.TabIndex = 19;
            addCustomerButton.Text = "Add";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(0, 18);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(349, 544);
            CustomersListBox.TabIndex = 18;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 17;
            label7.Text = "Customers";
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
            addressControl1.Location = new Point(355, 116);
            addressControl1.Name = "addressControl1";
            addressControl1.PostIndexValue = "";
            addressControl1.Size = new Size(520, 181);
            addressControl1.StreetValue = "";
            addressControl1.TabIndex = 27;
            // 
            // IsPriorityCheckBox
            // 
            IsPriorityCheckBox.AutoSize = true;
            IsPriorityCheckBox.Location = new Point(428, 92);
            IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            IsPriorityCheckBox.Size = new Size(75, 19);
            IsPriorityCheckBox.TabIndex = 28;
            IsPriorityCheckBox.Text = "Is Priority";
            IsPriorityCheckBox.UseVisualStyleBackColor = true;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(355, 310);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 29;
            label1.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 15;
            DiscountsListBox.Location = new Point(355, 328);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(333, 154);
            DiscountsListBox.TabIndex = 30;
            // 
            // addDiscountButton
            // 
            addDiscountButton.Location = new Point(694, 328);
            addDiscountButton.Name = "addDiscountButton";
            addDiscountButton.Size = new Size(117, 49);
            addDiscountButton.TabIndex = 31;
            addDiscountButton.Text = "Add";
            addDiscountButton.UseVisualStyleBackColor = true;
            addDiscountButton.Click += addDiscountButton_Click;
            // 
            // removeDiscountButton
            // 
            removeDiscountButton.Location = new Point(694, 383);
            removeDiscountButton.Name = "removeDiscountButton";
            removeDiscountButton.Size = new Size(117, 49);
            removeDiscountButton.TabIndex = 32;
            removeDiscountButton.Text = "Remove";
            removeDiscountButton.UseVisualStyleBackColor = true;
            removeDiscountButton.Click += removeDiscountButton_Click;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(removeDiscountButton);
            Controls.Add(addDiscountButton);
            Controls.Add(DiscountsListBox);
            Controls.Add(label1);
            Controls.Add(IsPriorityCheckBox);
            Controls.Add(addressControl1);
            Controls.Add(fullnameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(removeCustomerButton);
            Controls.Add(addCustomerButton);
            Controls.Add(CustomersListBox);
            Controls.Add(label7);
            Name = "CustomersTab";
            Size = new Size(881, 667);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private TextBox fullnameTextBox;
        private TextBox idTextBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button removeCustomerButton;
        private Button addCustomerButton;
        private ListBox CustomersListBox;
        private Label label7;
        private Controls.AddressControl addressControl1;
        private CheckBox IsPriorityCheckBox;
        private Label label1;
        private ListBox DiscountsListBox;
        private Button addDiscountButton;
        private Button removeDiscountButton;
    }
}