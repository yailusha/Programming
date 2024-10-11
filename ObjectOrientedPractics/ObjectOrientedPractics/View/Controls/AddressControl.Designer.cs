namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            postIndexTextBox = new TextBox();
            countryTextBox = new TextBox();
            cityTextBox = new TextBox();
            streetTextBox = new TextBox();
            buildingTextBox = new TextBox();
            apartmentTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(15, 11);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 0;
            label1.Text = "Delivery Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 40);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 1;
            label2.Text = "Post Index:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 71);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Country:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 102);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 3;
            label4.Text = "Street:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 133);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Building:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(187, 133);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 5;
            label6.Text = "Apartment:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(291, 71);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 6;
            label7.Text = "City:";
            // 
            // postIndexTextBox
            // 
            postIndexTextBox.Location = new Point(86, 32);
            postIndexTextBox.Name = "postIndexTextBox";
            postIndexTextBox.Size = new Size(131, 23);
            postIndexTextBox.TabIndex = 7;
            postIndexTextBox.TextChanged += postIndexTextBox_TextChanged;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(86, 63);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(181, 23);
            countryTextBox.TabIndex = 8;
            countryTextBox.TextChanged += countryTextBox_TextChanged;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(328, 68);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(181, 23);
            cityTextBox.TabIndex = 9;
            cityTextBox.TextChanged += cityTextBox_TextChanged;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(86, 99);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(423, 23);
            streetTextBox.TabIndex = 10;
            streetTextBox.TextChanged += streetTextBox_TextChanged;
            // 
            // buildingTextBox
            // 
            buildingTextBox.Location = new Point(86, 130);
            buildingTextBox.Name = "buildingTextBox";
            buildingTextBox.Size = new Size(95, 23);
            buildingTextBox.TabIndex = 11;
            buildingTextBox.TextChanged += buildingTextBox_TextChanged;
            // 
            // apartmentTextBox
            // 
            apartmentTextBox.Location = new Point(260, 130);
            apartmentTextBox.Name = "apartmentTextBox";
            apartmentTextBox.Size = new Size(95, 23);
            apartmentTextBox.TabIndex = 12;
            apartmentTextBox.TextChanged += apartmentTextBox_TextChanged;
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(apartmentTextBox);
            Controls.Add(buildingTextBox);
            Controls.Add(streetTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(postIndexTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddressControl";
            Size = new Size(554, 205);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox postIndexTextBox;
        private TextBox countryTextBox;
        private TextBox cityTextBox;
        private TextBox streetTextBox;
        private TextBox buildingTextBox;
        private TextBox apartmentTextBox;
    }
}
