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
            AddressTextBox = new TextBox();
            FullnameTextBox = new TextBox();
            IdTextBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            RemoveButton = new Button();
            AddButton = new Button();
            CustomersListBox = new ListBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(424, 98);
            AddressTextBox.Multiline = true;
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(314, 139);
            AddressTextBox.TabIndex = 27;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Location = new Point(424, 63);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(314, 23);
            FullnameTextBox.TabIndex = 26;
            FullnameTextBox.TextChanged += FullnameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(424, 34);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(134, 23);
            IdTextBox.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(355, 100);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 24;
            label11.Text = "Address:";
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
            label8.Location = new Point(365, 0);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 21;
            label8.Text = "Selected Customer";
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(123, 418);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(117, 61);
            RemoveButton.TabIndex = 20;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(0, 418);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(117, 61);
            AddButton.TabIndex = 19;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(0, 18);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(349, 394);
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
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressTextBox);
            Controls.Add(FullnameTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(CustomersListBox);
            Controls.Add(label7);
            Name = "CustomersTab";
            Size = new Size(754, 497);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AddressTextBox;
        private TextBox FullnameTextBox;
        private TextBox IdTextBox;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox CustomersListBox;
        private Label label7;
    }
}
