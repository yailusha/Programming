namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            label1 = new Label();
            ItemsListBox = new ListBox();
            addButton = new Button();
            label2 = new Label();
            CustomerComboBox = new ComboBox();
            label3 = new Label();
            cartTextBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            clearButton = new Button();
            removeButton = new Button();
            createButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 18);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(243, 454);
            ItemsListBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 478);
            addButton.Name = "addButton";
            addButton.Size = new Size(78, 35);
            addButton.TabIndex = 2;
            addButton.Text = "Add To Cart";
            addButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(252, 27);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 3;
            label2.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(327, 24);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(326, 23);
            CustomerComboBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 71);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 5;
            label3.Text = "Cart:";
            // 
            // cartTextBox
            // 
            cartTextBox.Location = new Point(252, 89);
            cartTextBox.Multiline = true;
            cartTextBox.Name = "cartTextBox";
            cartTextBox.Size = new Size(401, 167);
            cartTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(593, 268);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 7;
            label4.Text = "Amount:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(584, 294);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 8;
            label5.Text = "Customer:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(631, 309);
            label6.Name = "label6";
            label6.Size = new Size(25, 30);
            label6.TabIndex = 9;
            label6.Text = "0";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(546, 342);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(107, 45);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear Cart";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            removeButton.Location = new Point(433, 342);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(107, 45);
            removeButton.TabIndex = 11;
            removeButton.Text = "Remove Item";
            removeButton.UseVisualStyleBackColor = true;
            // 
            // createButton
            // 
            createButton.Location = new Point(252, 342);
            createButton.Name = "createButton";
            createButton.Size = new Size(107, 45);
            createButton.TabIndex = 12;
            createButton.Text = "Create Order";
            createButton.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(createButton);
            Controls.Add(removeButton);
            Controls.Add(clearButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(cartTextBox);
            Controls.Add(label3);
            Controls.Add(CustomerComboBox);
            Controls.Add(label2);
            Controls.Add(addButton);
            Controls.Add(ItemsListBox);
            Controls.Add(label1);
            Name = "CartsTab";
            Size = new Size(656, 534);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox ItemsListBox;
        private Button addButton;
        private Label label2;
        private ComboBox CustomerComboBox;
        private Label label3;
        private TextBox cartTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button clearButton;
        private Button removeButton;
        private Button createButton;
    }
}
