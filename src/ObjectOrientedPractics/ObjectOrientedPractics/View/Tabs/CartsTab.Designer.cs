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
            label10 = new Label();
            amountLabel = new Label();
            clearButton = new Button();
            removeButton = new Button();
            createButton = new Button();
            CartListBox = new ListBox();
            label4 = new Label();
            DiscountsCheckedListBox = new CheckedListBox();
            label5 = new Label();
            discountAmountLabel = new Label();
            label7 = new Label();
            totalLabel = new Label();
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
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 18);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(243, 499);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(3, 526);
            addButton.Name = "addButton";
            addButton.Size = new Size(78, 35);
            addButton.TabIndex = 2;
            addButton.Text = "Add To Cart";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
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
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(327, 24);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(326, 23);
            CustomerComboBox.TabIndex = 4;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
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
            // label10
            // 
            label10.Anchor = AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label10.Location = new Point(575, 261);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 7;
            label10.Text = "Amount:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountLabel.Location = new Point(575, 276);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(25, 30);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "0";
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Right;
            clearButton.Location = new Point(546, 313);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(107, 45);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear Cart";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Right;
            removeButton.Location = new Point(433, 313);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(107, 45);
            removeButton.TabIndex = 11;
            removeButton.Text = "Remove Item";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.Left;
            createButton.Location = new Point(252, 313);
            createButton.Name = "createButton";
            createButton.Size = new Size(107, 45);
            createButton.TabIndex = 12;
            createButton.Text = "Create Order";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(252, 89);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(401, 169);
            CartListBox.TabIndex = 13;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(252, 372);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 14;
            label4.Text = "Discounts:";
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DiscountsCheckedListBox.BackColor = Color.FromArgb(224, 224, 224);
            DiscountsCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.Location = new Point(252, 390);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(196, 126);
            DiscountsCheckedListBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(551, 402);
            label5.Name = "label5";
            label5.Size = new Size(105, 13);
            label5.TabIndex = 16;
            label5.Text = "Discount Amount:";
            // 
            // discountAmountLabel
            // 
            discountAmountLabel.Anchor = AnchorStyles.Right;
            discountAmountLabel.AutoSize = true;
            discountAmountLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            discountAmountLabel.Location = new Point(551, 425);
            discountAmountLabel.Name = "discountAmountLabel";
            discountAmountLabel.Size = new Size(23, 25);
            discountAmountLabel.TabIndex = 17;
            discountAmountLabel.Text = "0";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(575, 523);
            label7.Name = "label7";
            label7.Size = new Size(47, 13);
            label7.TabIndex = 18;
            label7.Text = "TOTAL:";
            // 
            // totalLabel
            // 
            totalLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            totalLabel.Location = new Point(575, 536);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(23, 25);
            totalLabel.TabIndex = 19;
            totalLabel.Text = "0";
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(totalLabel);
            Controls.Add(label7);
            Controls.Add(discountAmountLabel);
            Controls.Add(label5);
            Controls.Add(DiscountsCheckedListBox);
            Controls.Add(label4);
            Controls.Add(CartListBox);
            Controls.Add(createButton);
            Controls.Add(removeButton);
            Controls.Add(clearButton);
            Controls.Add(amountLabel);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(CustomerComboBox);
            Controls.Add(label2);
            Controls.Add(addButton);
            Controls.Add(ItemsListBox);
            Controls.Add(label1);
            Name = "CartsTab";
            Size = new Size(656, 582);
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
        private Label label10;
        private Label amountLabel;
        private Button clearButton;
        private Button removeButton;
        private Button createButton;
        private ListBox CartListBox;
        private Label label4;
        private CheckedListBox DiscountsCheckedListBox;
        private Label label5;
        private Label discountAmountLabel;
        private Label label7;
        private Label totalLabel;
    }
}
