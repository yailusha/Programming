namespace CityBuildings.View.Panels
{
    partial class CityBuildingsControls
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
            CityBuildingsListBox = new ListBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TitleTextBox = new TextBox();
            AdressTextBox = new TextBox();
            CategoryComboBox = new ComboBox();
            RatingTextBox = new TextBox();
            AddButton = new Button();
            EditButton = new Button();
            DeleteButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CityBuildingsListBox
            // 
            CityBuildingsListBox.FormattingEnabled = true;
            CityBuildingsListBox.ItemHeight = 15;
            CityBuildingsListBox.Location = new Point(3, 26);
            CityBuildingsListBox.Name = "CityBuildingsListBox";
            CityBuildingsListBox.Size = new Size(183, 319);
            CityBuildingsListBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RatingTextBox);
            groupBox1.Controls.Add(CategoryComboBox);
            groupBox1.Controls.Add(AdressTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TitleTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(218, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 161);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected City Building";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Title: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 59);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Adress:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 89);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 120);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Rating:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(69, 22);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(262, 23);
            TitleTextBox.TabIndex = 4;
            // 
            // AdressTextBox
            // 
            AdressTextBox.Location = new Point(69, 51);
            AdressTextBox.Name = "AdressTextBox";
            AdressTextBox.Size = new Size(262, 23);
            AdressTextBox.TabIndex = 5;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(69, 81);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(262, 23);
            CategoryComboBox.TabIndex = 6;
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(69, 112);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(262, 23);
            RatingTextBox.TabIndex = 5;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 351);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(53, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(68, 351);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(53, 23);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(133, 351);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(53, 23);
            DeleteButton.TabIndex = 4;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // CityBuildingsControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(AddButton);
            Controls.Add(groupBox1);
            Controls.Add(CityBuildingsListBox);
            Name = "CityBuildingsControls";
            Size = new Size(712, 394);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox CityBuildingsListBox;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox AdressTextBox;
        private TextBox TitleTextBox;
        private TextBox RatingTextBox;
        private ComboBox CategoryComboBox;
        private Button AddButton;
        private Button EditButton;
        private Button DeleteButton;
    }
}
