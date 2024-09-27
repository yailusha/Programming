namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            IdTextBox = new TextBox();
            CostTextBox = new TextBox();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            label7 = new Label();
            CustomersListBox = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(752, 533);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(DescriptionTextBox);
            tabPage1.Controls.Add(NameTextBox);
            tabPage1.Controls.Add(CostTextBox);
            tabPage1.Controls.Add(IdTextBox);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(RemoveButton);
            tabPage1.Controls.Add(AddButton);
            tabPage1.Controls.Add(ItemsListBox);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(744, 505);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Items";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox1);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(button1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(CustomersListBox);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(744, 505);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(129, 430);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(117, 61);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(6, 430);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(117, 61);
            AddButton.TabIndex = 6;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 30);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(349, 394);
            ItemsListBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 4;
            label1.Text = "Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(371, 12);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 8;
            label2.Text = "Selected Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 48);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 9;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(361, 78);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 10;
            label4.Text = "Cost:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(361, 112);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(361, 245);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 12;
            label6.Text = "Description:";
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(419, 45);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(134, 23);
            IdTextBox.TabIndex = 13;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(419, 75);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(134, 23);
            CostTextBox.TabIndex = 14;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(361, 130);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(367, 112);
            NameTextBox.TabIndex = 15;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(361, 263);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(367, 77);
            DescriptionTextBox.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(6, 12);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 0;
            label7.Text = "Customers";
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(6, 30);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(349, 394);
            CustomersListBox.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(129, 430);
            button1.Name = "button1";
            button1.Size = new Size(117, 61);
            button1.TabIndex = 9;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(6, 430);
            button2.Name = "button2";
            button2.Size = new Size(117, 61);
            button2.TabIndex = 8;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(371, 12);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 10;
            label8.Text = "Selected Customer";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(361, 48);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 11;
            label9.Text = "ID:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(361, 78);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 12;
            label10.Text = "Cost:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(361, 112);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 13;
            label11.Text = "Address:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(419, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 14;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(419, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 23);
            textBox2.TabIndex = 15;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(419, 109);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(314, 139);
            textBox3.TabIndex = 16;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Name = "ItemsTab";
            Size = new Size(758, 539);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private Label label1;
        private TabPage tabPage2;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private TextBox DescriptionTextBox;
        private Label label7;
        private Label label9;
        private Label label8;
        private Button button1;
        private Button button2;
        private ListBox CustomersListBox;
        private Label label10;
        private Label label11;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
