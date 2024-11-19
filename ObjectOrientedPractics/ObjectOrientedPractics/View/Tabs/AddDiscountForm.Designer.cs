namespace ObjectOrientedPractics.View
{
    partial class AddDiscountForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            CategoryComboBox = new ComboBox();
            applyButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Percent Discount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 1;
            label2.Text = "Category: ";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(79, 41);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(206, 23);
            CategoryComboBox.TabIndex = 2;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // applyButton
            // 
            applyButton.Location = new Point(102, 81);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(90, 39);
            applyButton.TabIndex = 3;
            applyButton.Text = "Ok";
            applyButton.UseVisualStyleBackColor = true;
            applyButton.Click += applyButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(198, 81);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(90, 39);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 136);
            Controls.Add(cancelButton);
            Controls.Add(applyButton);
            Controls.Add(CategoryComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddDiscountForm";
            Text = "Add Discount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox CategoryComboBox;
        private Button applyButton;
        private Button cancelButton;
    }
}