namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            heightRecTextBox = new TextBox();
            label23 = new Label();
            widthRecTextBox = new TextBox();
            label22 = new Label();
            yRecTextBox = new TextBox();
            label21 = new Label();
            xRecTextBox = new TextBox();
            label20 = new Label();
            idRecTextBox = new TextBox();
            label19 = new Label();
            label18 = new Label();
            deleteRectangleButton = new Button();
            addRectangleButton = new Button();
            RecListBox = new ListBox();
            label17 = new Label();
            RectanglePanels = new Panel();
            SuspendLayout();
            // 
            // heightRecTextBox
            // 
            heightRecTextBox.Location = new Point(58, 392);
            heightRecTextBox.Name = "heightRecTextBox";
            heightRecTextBox.Size = new Size(136, 23);
            heightRecTextBox.TabIndex = 31;
            heightRecTextBox.TextChanged += heightRecTextBox_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(6, 395);
            label23.Name = "label23";
            label23.Size = new Size(46, 15);
            label23.TabIndex = 30;
            label23.Text = "Height:";
            // 
            // widthRecTextBox
            // 
            widthRecTextBox.Location = new Point(58, 363);
            widthRecTextBox.Name = "widthRecTextBox";
            widthRecTextBox.Size = new Size(136, 23);
            widthRecTextBox.TabIndex = 29;
            widthRecTextBox.TextChanged += widthRecTextBox_TextChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(10, 366);
            label22.Name = "label22";
            label22.Size = new Size(42, 15);
            label22.TabIndex = 28;
            label22.Text = "Width:";
            // 
            // yRecTextBox
            // 
            yRecTextBox.Location = new Point(58, 332);
            yRecTextBox.Name = "yRecTextBox";
            yRecTextBox.Size = new Size(136, 23);
            yRecTextBox.TabIndex = 27;
            yRecTextBox.TextChanged += yRecTextBox_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(35, 335);
            label21.Name = "label21";
            label21.Size = new Size(17, 15);
            label21.TabIndex = 26;
            label21.Text = "Y:";
            // 
            // xRecTextBox
            // 
            xRecTextBox.Location = new Point(58, 303);
            xRecTextBox.Name = "xRecTextBox";
            xRecTextBox.Size = new Size(136, 23);
            xRecTextBox.TabIndex = 25;
            xRecTextBox.TextChanged += xRecTextBox_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(35, 306);
            label20.Name = "label20";
            label20.Size = new Size(17, 15);
            label20.TabIndex = 24;
            label20.Text = "X:";
            // 
            // idRecTextBox
            // 
            idRecTextBox.Enabled = false;
            idRecTextBox.Location = new Point(58, 272);
            idRecTextBox.Name = "idRecTextBox";
            idRecTextBox.ReadOnly = true;
            idRecTextBox.Size = new Size(136, 23);
            idRecTextBox.TabIndex = 23;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(32, 275);
            label19.Name = "label19";
            label19.Size = new Size(20, 15);
            label19.TabIndex = 22;
            label19.Text = "Id:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 249);
            label18.Name = "label18";
            label18.Size = new Size(109, 15);
            label18.TabIndex = 21;
            label18.Text = "Selected Rectangle:";
            // 
            // deleteRectangleButton
            // 
            deleteRectangleButton.BackColor = Color.White;
            deleteRectangleButton.Image = (Image)resources.GetObject("deleteRectangleButton.Image");
            deleteRectangleButton.Location = new Point(115, 189);
            deleteRectangleButton.Name = "deleteRectangleButton";
            deleteRectangleButton.Size = new Size(67, 57);
            deleteRectangleButton.TabIndex = 20;
            deleteRectangleButton.UseVisualStyleBackColor = false;
            deleteRectangleButton.Click += deleteRectangleButton_Click;
            // 
            // addRectangleButton
            // 
            addRectangleButton.BackColor = Color.White;
            addRectangleButton.FlatAppearance.BorderColor = Color.White;
            addRectangleButton.FlatAppearance.BorderSize = 0;
            addRectangleButton.Image = (Image)resources.GetObject("addRectangleButton.Image");
            addRectangleButton.Location = new Point(32, 189);
            addRectangleButton.Name = "addRectangleButton";
            addRectangleButton.Size = new Size(67, 57);
            addRectangleButton.TabIndex = 19;
            addRectangleButton.UseVisualStyleBackColor = false;
            addRectangleButton.Click += addRectangleButton_Click;
            // 
            // RecListBox
            // 
            RecListBox.FormattingEnabled = true;
            RecListBox.ItemHeight = 15;
            RecListBox.Location = new Point(3, 32);
            RecListBox.Name = "RecListBox";
            RecListBox.Size = new Size(295, 154);
            RecListBox.TabIndex = 18;
            RecListBox.SelectedIndexChanged += RecListBox_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 14);
            label17.Name = "label17";
            label17.Size = new Size(67, 15);
            label17.TabIndex = 17;
            label17.Text = "Rectangles:";
            // 
            // RectanglePanels
            // 
            RectanglePanels.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanels.Location = new Point(304, 14);
            RectanglePanels.Name = "RectanglePanels";
            RectanglePanels.Size = new Size(480, 413);
            RectanglePanels.TabIndex = 16;
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(heightRecTextBox);
            Controls.Add(label23);
            Controls.Add(widthRecTextBox);
            Controls.Add(label22);
            Controls.Add(yRecTextBox);
            Controls.Add(label21);
            Controls.Add(xRecTextBox);
            Controls.Add(label20);
            Controls.Add(idRecTextBox);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(deleteRectangleButton);
            Controls.Add(addRectangleButton);
            Controls.Add(RecListBox);
            Controls.Add(label17);
            Controls.Add(RectanglePanels);
            Name = "RectanglesCollisionControl";
            Size = new Size(792, 438);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TextBox heightRecTextBox;
        private Label label23;
        private TextBox widthRecTextBox;
        private Label label22;
        private TextBox yRecTextBox;
        private Label label21;
        private TextBox xRecTextBox;
        private Label label20;
        private TextBox idRecTextBox;
        private Label label19;
        private Label label18;
        private Button deleteRectangleButton;
        private Button addRectangleButton;
        private ListBox RecListBox;
        private Label label17;
        private Panel RectanglePanels;
    }
}
