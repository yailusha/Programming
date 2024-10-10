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
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IdTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            RemoveButton = new Button();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(358, 251);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(367, 77);
            DescriptionTextBox.TabIndex = 42;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(358, 118);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(367, 112);
            NameTextBox.TabIndex = 41;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(427, 63);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(134, 23);
            CostTextBox.TabIndex = 40;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(427, 34);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(134, 23);
            IdTextBox.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 233);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 38;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 100);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 37;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(358, 66);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 36;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(358, 36);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 35;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(368, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 34;
            label2.Text = "Selected Item";
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(126, 418);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(117, 61);
            RemoveButton.TabIndex = 33;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 418);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(117, 61);
            AddButton.TabIndex = 32;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 18);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(349, 394);
            ItemsListBox.TabIndex = 31;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 30;
            label1.Text = "Items";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DescriptionTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(CostTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Controls.Add(ItemsListBox);
            Controls.Add(label1);
            Name = "ItemsTab";
            Size = new Size(746, 493);
            ResumeLayout(false);
            PerformLayout();
        }

        private void AddButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IdTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button RemoveButton;
        private Button AddButton;
        private ListBox ItemsListBox;
        private Label label1;
    }
}
