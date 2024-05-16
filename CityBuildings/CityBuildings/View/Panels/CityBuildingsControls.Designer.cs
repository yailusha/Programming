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
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            groupBox1 = new GroupBox();
            RatingTextBox = new TextBox();
            CategoryComboBox = new ComboBox();
            AdressTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            TitleTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            CityBuildingsListBox = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(144, 340);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(53, 23);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(79, 340);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(53, 23);
            EditButton.TabIndex = 8;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(14, 340);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(53, 23);
            AddButton.TabIndex = 7;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
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
            groupBox1.Location = new Point(229, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(478, 161);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selected City Building";
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(69, 112);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(262, 23);
            RatingTextBox.TabIndex = 5;
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(69, 81);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(262, 23);
            CategoryComboBox.TabIndex = 6;
            // 
            // AdressTextBox
            // 
            AdressTextBox.Location = new Point(69, 51);
            AdressTextBox.Name = "AdressTextBox";
            AdressTextBox.Size = new Size(262, 23);
            AdressTextBox.TabIndex = 5;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 89);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // TitleTextBox
            // 
            TitleTextBox.Location = new Point(69, 22);
            TitleTextBox.Name = "TitleTextBox";
            TitleTextBox.Size = new Size(262, 23);
            TitleTextBox.TabIndex = 4;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 30);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Title: ";
            // 
            // CityBuildingsListBox
            // 
            CityBuildingsListBox.FormattingEnabled = true;
            CityBuildingsListBox.ItemHeight = 15;
            CityBuildingsListBox.Location = new Point(14, 15);
            CityBuildingsListBox.Name = "CityBuildingsListBox";
            CityBuildingsListBox.Size = new Size(183, 319);
            CityBuildingsListBox.TabIndex = 5;
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
            Size = new Size(904, 441);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private GroupBox groupBox1;
        private TextBox RatingTextBox;
        private ComboBox CategoryComboBox;
        private TextBox AdressTextBox;
        private Label label4;
        private Label label3;
        private TextBox TitleTextBox;
        private Label label2;
        private Label label1;
        private ListBox CityBuildingsListBox;
    }
}
