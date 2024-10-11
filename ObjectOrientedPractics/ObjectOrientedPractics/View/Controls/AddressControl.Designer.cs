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
            apartmentTextBox = new TextBox();
            buildingTextBox = new TextBox();
            streetTextBox = new TextBox();
            cityTextBox = new TextBox();
            countryTextBox = new TextBox();
            postIndexTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // apartmentTextBox
            // 
            apartmentTextBox.Location = new Point(248, 128);
            apartmentTextBox.Name = "apartmentTextBox";
            apartmentTextBox.Size = new Size(95, 23);
            apartmentTextBox.TabIndex = 25;
            apartmentTextBox.TextChanged += apartmentTextBox_TextChanged;
            // 
            // buildingTextBox
            // 
            buildingTextBox.Location = new Point(74, 128);
            buildingTextBox.Name = "buildingTextBox";
            buildingTextBox.Size = new Size(95, 23);
            buildingTextBox.TabIndex = 24;
            buildingTextBox.TextChanged += buildingTextBox_TextChanged;
            // 
            // streetTextBox
            // 
            streetTextBox.Location = new Point(74, 97);
            streetTextBox.Name = "streetTextBox";
            streetTextBox.Size = new Size(423, 23);
            streetTextBox.TabIndex = 23;
            streetTextBox.TextChanged += streetTextBox_TextChanged;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(316, 66);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(181, 23);
            cityTextBox.TabIndex = 22;
            cityTextBox.TextChanged += cityTextBox_TextChanged;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(74, 61);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(181, 23);
            countryTextBox.TabIndex = 21;
            countryTextBox.TextChanged += countryTextBox_TextChanged;
            // 
            // postIndexTextBox
            // 
            postIndexTextBox.Location = new Point(74, 30);
            postIndexTextBox.Name = "postIndexTextBox";
            postIndexTextBox.Size = new Size(131, 23);
            postIndexTextBox.TabIndex = 20;
            postIndexTextBox.TextChanged += postIndexTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 69);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 19;
            label7.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 131);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 18;
            label6.Text = "Apartment:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 131);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 17;
            label5.Text = "Building:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 100);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 16;
            label4.Text = "Street:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 69);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 15;
            label3.Text = "Country:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 38);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 14;
            label2.Text = "Post Index:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 13;
            label1.Text = "Delivery Address";
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
            Size = new Size(520, 181);
            ResumeLayout(false);
            PerformLayout();
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox apartmentTextBox;
        private TextBox buildingTextBox;
        private TextBox streetTextBox;
        private TextBox cityTextBox;
        private TextBox countryTextBox;
        private TextBox postIndexTextBox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
