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
            label5 = new Label();
            categoryComboBox = new ComboBox();
            adressTextBox = new TextBox();
            ratingTextBox = new TextBox();
            titleTextBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // CityBuildingsListBox
            // 
            CityBuildingsListBox.FormattingEnabled = true;
            CityBuildingsListBox.ItemHeight = 15;
            CityBuildingsListBox.Location = new Point(3, 3);
            CityBuildingsListBox.Name = "CityBuildingsListBox";
            CityBuildingsListBox.Size = new Size(196, 364);
            CityBuildingsListBox.TabIndex = 0;
            CityBuildingsListBox.SelectedIndexChanged += CityBuildingsListBox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(categoryComboBox);
            groupBox1.Controls.Add(adressTextBox);
            groupBox1.Controls.Add(ratingTextBox);
            groupBox1.Controls.Add(titleTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(215, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(419, 279);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "City Buildings";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(236, 135);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 8;
            label5.Text = "(Ex.: 4,4. But not 4.4)\r\n";
            // 
            // categoryComboBox
            // 
            categoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(69, 80);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(281, 23);
            categoryComboBox.TabIndex = 7;
            categoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // adressTextBox
            // 
            adressTextBox.Location = new Point(69, 51);
            adressTextBox.Name = "adressTextBox";
            adressTextBox.Size = new Size(281, 23);
            adressTextBox.TabIndex = 6;
            adressTextBox.TextChanged += adressTextBox_TextChanged;
            // 
            // ratingTextBox
            // 
            ratingTextBox.Location = new Point(69, 109);
            ratingTextBox.Name = "ratingTextBox";
            ratingTextBox.Size = new Size(281, 23);
            ratingTextBox.TabIndex = 5;
            ratingTextBox.TextChanged += ratingTextBox_TextChanged;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(69, 22);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(281, 23);
            titleTextBox.TabIndex = 4;
            titleTextBox.TextChanged += titleTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 117);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Rating:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 88);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Category:";
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
            label1.Location = new Point(31, 30);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // addButton
            // 
            addButton.Location = new Point(3, 373);
            addButton.Name = "addButton";
            addButton.Size = new Size(62, 23);
            addButton.TabIndex = 2;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(71, 373);
            editButton.Name = "editButton";
            editButton.Size = new Size(62, 23);
            editButton.TabIndex = 3;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(137, 373);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(62, 23);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // CityBuildingsControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(groupBox1);
            Controls.Add(CityBuildingsListBox);
            Name = "CityBuildingsControls";
            Size = new Size(656, 405);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox CityBuildingsListBox;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox categoryComboBox;
        private TextBox adressTextBox;
        private TextBox ratingTextBox;
        private TextBox titleTextBox;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private Label label5;
    }
}
