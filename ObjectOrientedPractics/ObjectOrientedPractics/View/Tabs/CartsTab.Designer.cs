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
            ItemsListBox.Size = new Size(243, 454);
            ItemsListBox.TabIndex = 1;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addButton.Location = new Point(3, 478);
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
            label10.Location = new Point(593, 284);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 7;
            label10.Text = "Amount:";
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            amountLabel.Location = new Point(593, 309);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(25, 30);
            amountLabel.TabIndex = 9;
            amountLabel.Text = "0";
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Right;
            clearButton.Location = new Point(546, 342);
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
            removeButton.Location = new Point(433, 342);
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
            createButton.Location = new Point(252, 342);
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
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
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
        private Label label10;
        private Label amountLabel;
        private Button clearButton;
        private Button removeButton;
        private Button createButton;
        private ListBox CartListBox;
    }
}
