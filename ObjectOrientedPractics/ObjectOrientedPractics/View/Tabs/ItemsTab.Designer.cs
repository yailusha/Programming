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
            DescriptionTextBox.Location = new Point(368, 260);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(367, 77);
            DescriptionTextBox.TabIndex = 29;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(368, 127);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(367, 112);
            NameTextBox.TabIndex = 28;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(426, 72);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(134, 23);
            CostTextBox.TabIndex = 27;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(426, 42);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(134, 23);
            IdTextBox.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(368, 242);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 25;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 109);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 24;
            label5.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 75);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 23;
            label4.Text = "Cost:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(368, 45);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 22;
            label3.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(378, 9);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 21;
            label2.Text = "Selected Item";
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(136, 427);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(117, 61);
            RemoveButton.TabIndex = 20;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(13, 427);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(117, 61);
            AddButton.TabIndex = 19;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(13, 27);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(349, 394);
            ItemsListBox.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 17;
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
            Size = new Size(758, 539);
            ResumeLayout(false);
            PerformLayout();
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
