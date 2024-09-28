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
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            CustomersListBox = new ListBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(428, 108);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(314, 139);
            textBox3.TabIndex = 27;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(428, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(314, 23);
            textBox2.TabIndex = 26;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(428, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(134, 23);
            textBox1.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(370, 111);
            label11.Name = "label11";
            label11.Size = new Size(52, 15);
            label11.TabIndex = 24;
            label11.Text = "Address:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(370, 77);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 23;
            label10.Text = "Cost:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 47);
            label9.Name = "label9";
            label9.Size = new Size(21, 15);
            label9.TabIndex = 22;
            label9.Text = "ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label8.Location = new Point(380, 11);
            label8.Name = "label8";
            label8.Size = new Size(119, 15);
            label8.TabIndex = 21;
            label8.Text = "Selected Customer";
            // 
            // button1
            // 
            button1.Location = new Point(138, 429);
            button1.Name = "button1";
            button1.Size = new Size(117, 61);
            button1.TabIndex = 20;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(15, 429);
            button2.Name = "button2";
            button2.Size = new Size(117, 61);
            button2.TabIndex = 19;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(15, 29);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(349, 394);
            CustomersListBox.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label7.Location = new Point(15, 11);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 17;
            label7.Text = "Customers";
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(CustomersListBox);
            Controls.Add(label7);
            Name = "CustomersTab";
            Size = new Size(754, 501);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button button1;
        private Button button2;
        private ListBox CustomersListBox;
        private Label label7;
    }
}
