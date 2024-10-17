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
            fullnameTextBox = new TextBox();
            idTextBox = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            removeButton = new Button();
            addButton = new Button();
            CustomersListBox = new ListBox();
            label7 = new Label();
            addressControl1 = new Controls.AddressControl();
            SuspendLayout();
            // 
            // fullnameTextBox
            // 
            fullnameTextBox.Location = new Point(424, 63);
            fullnameTextBox.Name = "fullnameTextBox";
            fullnameTextBox.Size = new Size(314, 23);
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
            label8.Location = new Point(365, 0);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 21;
            label8.Text = "Selected Customer";
            // 
            // removeButton
            // 
            removeButton.Location = new Point(123, 418);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(117, 61);
            removeButton.TabIndex = 20;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(0, 418);
            addButton.Name = "addButton";
            addButton.Size = new Size(117, 61);
            addButton.TabIndex = 19;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
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
            // addressControl1
            // 
            addressControl1.Location = new Point(355, 92);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(520, 181);
            addressControl1.TabIndex = 27;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addressControl1);
            Controls.Add(fullnameTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(CustomersListBox);
            Controls.Add(label7);
            Name = "CustomersTab";
            Size = new Size(881, 497);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox fullnameTextBox;
        private TextBox idTextBox;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button removeButton;
        private Button addButton;
        private ListBox CustomersListBox;
        private Label label7;
        private Controls.AddressControl addressControl1;
    }
}
