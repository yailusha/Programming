namespace Programming.View.Panels
{
    partial class RectanglesControls
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
            groupBox3 = new GroupBox();
            idTextBox = new TextBox();
            label16 = new Label();
            yCenterTextBox = new TextBox();
            label15 = new Label();
            xCenterTextBox = new TextBox();
            label14 = new Label();
            rectangleButton = new Button();
            colourTextBox = new TextBox();
            label8 = new Label();
            widthTextBox = new TextBox();
            label7 = new Label();
            lengthTextBox = new TextBox();
            label6 = new Label();
            RectanglesListBox = new ListBox();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(idTextBox);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(yCenterTextBox);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(xCenterTextBox);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(rectangleButton);
            groupBox3.Controls.Add(colourTextBox);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(widthTextBox);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(lengthTextBox);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(RectanglesListBox);
            groupBox3.Location = new Point(3, 3);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 319);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rectangles";
            // 
            // idTextBox
            // 
            idTextBox.Enabled = false;
            idTextBox.Location = new Point(165, 259);
            idTextBox.Name = "idTextBox";
            idTextBox.ReadOnly = true;
            idTextBox.Size = new Size(108, 23);
            idTextBox.TabIndex = 13;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(165, 242);
            label16.Name = "label16";
            label16.Size = new Size(21, 15);
            label16.TabIndex = 12;
            label16.Text = "ID:";
            // 
            // yCenterTextBox
            // 
            yCenterTextBox.Enabled = false;
            yCenterTextBox.Location = new Point(165, 216);
            yCenterTextBox.Name = "yCenterTextBox";
            yCenterTextBox.Size = new Size(108, 23);
            yCenterTextBox.TabIndex = 11;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(165, 198);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 10;
            label15.Text = "Center Y:";
            // 
            // xCenterTextBox
            // 
            xCenterTextBox.Enabled = false;
            xCenterTextBox.Location = new Point(165, 172);
            xCenterTextBox.Name = "xCenterTextBox";
            xCenterTextBox.Size = new Size(108, 23);
            xCenterTextBox.TabIndex = 9;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(165, 154);
            label14.Name = "label14";
            label14.Size = new Size(55, 15);
            label14.TabIndex = 8;
            label14.Text = "Center X:";
            // 
            // rectangleButton
            // 
            rectangleButton.Location = new Point(165, 288);
            rectangleButton.Name = "rectangleButton";
            rectangleButton.Size = new Size(108, 23);
            rectangleButton.TabIndex = 7;
            rectangleButton.Text = "Find";
            rectangleButton.UseVisualStyleBackColor = true;
            rectangleButton.Click += rectangleButton_Click;
            // 
            // colourTextBox
            // 
            colourTextBox.Location = new Point(165, 128);
            colourTextBox.Name = "colourTextBox";
            colourTextBox.Size = new Size(108, 23);
            colourTextBox.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(165, 110);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 5;
            label8.Text = "Colour:";
            // 
            // widthTextBox
            // 
            widthTextBox.Location = new Point(165, 84);
            widthTextBox.Name = "widthTextBox";
            widthTextBox.Size = new Size(108, 23);
            widthTextBox.TabIndex = 4;
            widthTextBox.TextChanged += widthTextBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(165, 66);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 3;
            label7.Text = "Width:";
            // 
            // lengthTextBox
            // 
            lengthTextBox.Location = new Point(165, 40);
            lengthTextBox.Name = "lengthTextBox";
            lengthTextBox.Size = new Size(108, 23);
            lengthTextBox.TabIndex = 2;
            lengthTextBox.TextChanged += lengthTextBox_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(165, 22);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 1;
            label6.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 15;
            RectanglesListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectanglesListBox.Location = new Point(6, 22);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(153, 289);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // RectanglesControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox3);
            Name = "RectanglesControls";
            Size = new Size(359, 331);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private TextBox idTextBox;
        private Label label16;
        private TextBox yCenterTextBox;
        private Label label15;
        private TextBox xCenterTextBox;
        private Label label14;
        private Button rectangleButton;
        private TextBox colourTextBox;
        private Label label8;
        private TextBox widthTextBox;
        private Label label7;
        private TextBox lengthTextBox;
        private Label label6;
        private ListBox RectanglesListBox;
    }
}
