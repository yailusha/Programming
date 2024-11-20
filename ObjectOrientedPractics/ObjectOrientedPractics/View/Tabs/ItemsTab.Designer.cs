
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
            descriptionTextBox = new TextBox();
            nameTextBox = new TextBox();
            costTextBox = new TextBox();
            idTextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            removeButton = new Button();
            addButton = new Button();
            ItemsListBox = new ListBox();
            label1 = new Label();
            label7 = new Label();
            CategoryComboBox = new ComboBox();
            label8 = new Label();
            findTextBox = new TextBox();
            label9 = new Label();
            SortComboBox = new ComboBox();
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(358, 276);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(488, 124);
            descriptionTextBox.TabIndex = 42;
            descriptionTextBox.TextChanged += descriptionTextBox_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(358, 143);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(488, 112);
            nameTextBox.TabIndex = 41;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // costTextBox
            // 
            costTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            costTextBox.Location = new Point(427, 63);
            costTextBox.Name = "costTextBox";
            costTextBox.Size = new Size(255, 23);
            costTextBox.TabIndex = 40;
            costTextBox.TextChanged += costTextBox_TextChanged;
            // 
            // idTextBox
            // 
            idTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            idTextBox.Location = new Point(427, 34);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(255, 23);
            idTextBox.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(358, 258);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 38;
            label6.Text = "Description:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(358, 125);
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
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            removeButton.Location = new Point(126, 503);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(117, 61);
            removeButton.TabIndex = 33;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(3, 503);
            addButton.Name = "addButton";
            addButton.Size = new Size(117, 61);
            addButton.TabIndex = 32;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 66);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(358, 97);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 43;
            label7.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(427, 94);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(255, 23);
            CategoryComboBox.TabIndex = 44;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 36);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 45;
            label8.Text = "Find:";
            // 
            // findTextBox
            // 
            findTextBox.Location = new Point(42, 34);
            findTextBox.Name = "findTextBox";
            findTextBox.Size = new Size(310, 23);
            findTextBox.TabIndex = 46;
            findTextBox.TextChanged += findTextBox_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(3, 474);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 47;
            label9.Text = "Order by:";
            // 
            // SortComboBox
            // 
            SortComboBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SortComboBox.FormattingEnabled = true;
            SortComboBox.Items.AddRange(new object[] { "Cost (Ascending)", "Cost (Descending)", "Name" });
            SortComboBox.Location = new Point(65, 471);
            SortComboBox.Name = "SortComboBox";
            SortComboBox.Size = new Size(287, 23);
            SortComboBox.TabIndex = 48;
            SortComboBox.SelectedIndexChanged += SortComboBox_SelectedIndexChanged;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SortComboBox);
            Controls.Add(label9);
            Controls.Add(findTextBox);
            Controls.Add(label8);
            Controls.Add(CategoryComboBox);
            Controls.Add(label7);
            Controls.Add(descriptionTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(costTextBox);
            Controls.Add(idTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(removeButton);
            Controls.Add(addButton);
            Controls.Add(ItemsListBox);
            Controls.Add(label1);
            Name = "ItemsTab";
            Size = new Size(867, 567);
            ResumeLayout(false);
            PerformLayout();
        }

        private void AddButton_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox descriptionTextBox;
        private TextBox nameTextBox;
        private TextBox costTextBox;
        private TextBox idTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button removeButton;
        private Button addButton;
        private ListBox ItemsListBox;
        private Label label1;
        private Label label7;
        private ComboBox CategoryComboBox;
        private Label label8;
        private TextBox findTextBox;
        private Label label9;
        private ComboBox SortComboBox;
    }
}
