namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EnumsListBox = new ListBox();
            ValuesListBox = new ListBox();
            IntValue = new TextBox();
            groupBox2 = new GroupBox();
            NumberOfWeekday = new TextBox();
            button1 = new Button();
            label4 = new Label();
            TextToParse = new TextBox();
            SeasonHandle = new GroupBox();
            ChooseSeason = new Button();
            label5 = new Label();
            comboBox1 = new ComboBox();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            label13 = new Label();
            titleTextBox = new TextBox();
            movieButton = new Button();
            ratingTextBox = new TextBox();
            label12 = new Label();
            genreTextBox = new TextBox();
            label11 = new Label();
            yearTextBox = new TextBox();
            label10 = new Label();
            durationTextBox = new TextBox();
            label9 = new Label();
            moviesListBox = new ListBox();
            groupBox3 = new GroupBox();
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
            label15 = new Label();
            yCenterTextBox = new TextBox();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SeasonHandle.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(SeasonHandle);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(IntValue);
            groupBox1.Location = new Point(0, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 277);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enumerations";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 3;
            label1.Text = "Choose enumeration:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 19);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 4;
            label2.Text = "Choose value:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 19);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 5;
            label3.Text = "Int value:";
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 15;
            EnumsListBox.Items.AddRange(new object[] { "Colours", "FormOfTheStudentEducation", "Genre", "SeasonOfYear", "SmartphoneManufacturers", "Weekday" });
            EnumsListBox.Location = new Point(6, 37);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(175, 229);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged_1;
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 15;
            ValuesListBox.Location = new Point(198, 37);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(175, 229);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // IntValue
            // 
            IntValue.Enabled = false;
            IntValue.Location = new Point(379, 37);
            IntValue.Name = "IntValue";
            IntValue.Size = new Size(145, 23);
            IntValue.TabIndex = 2;
            IntValue.TextChanged += IntValue_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(NumberOfWeekday);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TextToParse);
            groupBox2.Location = new Point(0, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 128);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekday Paring";
            // 
            // NumberOfWeekday
            // 
            NumberOfWeekday.Enabled = false;
            NumberOfWeekday.Location = new Point(17, 78);
            NumberOfWeekday.Name = "NumberOfWeekday";
            NumberOfWeekday.Size = new Size(246, 23);
            NumberOfWeekday.TabIndex = 3;
            NumberOfWeekday.TextChanged += ResultOfWeekday_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(269, 38);
            button1.Name = "button1";
            button1.Size = new Size(87, 23);
            button1.TabIndex = 2;
            button1.Text = "Parse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Parse_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 20);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 1;
            label4.Text = "Type value for paring:";
            // 
            // TextToParse
            // 
            TextToParse.Location = new Point(17, 38);
            TextToParse.Name = "TextToParse";
            TextToParse.Size = new Size(246, 23);
            TextToParse.TabIndex = 0;
            TextToParse.TextChanged += Weekday_TextChanged;
            // 
            // SeasonHandle
            // 
            SeasonHandle.Controls.Add(ChooseSeason);
            SeasonHandle.Controls.Add(label5);
            SeasonHandle.Controls.Add(comboBox1);
            SeasonHandle.Location = new Point(390, 287);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Size = new Size(372, 127);
            SeasonHandle.TabIndex = 8;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "SeasonHadle";
            // 
            // ChooseSeason
            // 
            ChooseSeason.Location = new Point(180, 37);
            ChooseSeason.Name = "ChooseSeason";
            ChooseSeason.Size = new Size(91, 23);
            ChooseSeason.TabIndex = 2;
            ChooseSeason.Text = "Go!";
            ChooseSeason.UseVisualStyleBackColor = true;
            ChooseSeason.Click += ChooseSeason_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 20);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 1;
            label5.Text = "Choose season:";
            label5.Click += label5_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            comboBox1.Location = new Point(6, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(168, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(titleTextBox);
            groupBox4.Controls.Add(movieButton);
            groupBox4.Controls.Add(ratingTextBox);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(genreTextBox);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(yearTextBox);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(durationTextBox);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(moviesListBox);
            groupBox4.Location = new Point(412, 21);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(348, 300);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Movies";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(170, 22);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 10;
            label13.Text = "Title:";
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(170, 40);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(108, 23);
            titleTextBox.TabIndex = 9;
            titleTextBox.TextChanged += titleTextBox_TextChanged;
            // 
            // movieButton
            // 
            movieButton.Location = new Point(170, 258);
            movieButton.Name = "movieButton";
            movieButton.Size = new Size(108, 23);
            movieButton.TabIndex = 8;
            movieButton.Text = "Find";
            movieButton.UseVisualStyleBackColor = true;
            movieButton.Click += movieButton_Click;
            // 
            // ratingTextBox
            // 
            ratingTextBox.Location = new Point(170, 216);
            ratingTextBox.Name = "ratingTextBox";
            ratingTextBox.Size = new Size(108, 23);
            ratingTextBox.TabIndex = 8;
            ratingTextBox.TextChanged += ratingTextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(170, 198);
            label12.Name = "label12";
            label12.Size = new Size(44, 15);
            label12.TabIndex = 7;
            label12.Text = "Rating:";
            // 
            // genreTextBox
            // 
            genreTextBox.Location = new Point(170, 172);
            genreTextBox.Name = "genreTextBox";
            genreTextBox.Size = new Size(108, 23);
            genreTextBox.TabIndex = 6;
            genreTextBox.TextChanged += genreTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(170, 154);
            label11.Name = "label11";
            label11.Size = new Size(41, 15);
            label11.TabIndex = 5;
            label11.Text = "Genre:";
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(170, 128);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(108, 23);
            yearTextBox.TabIndex = 4;
            yearTextBox.TextChanged += yearTextBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(170, 110);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 3;
            label10.Text = "Year:";
            // 
            // durationTextBox
            // 
            durationTextBox.Location = new Point(170, 84);
            durationTextBox.Name = "durationTextBox";
            durationTextBox.Size = new Size(108, 23);
            durationTextBox.TabIndex = 2;
            durationTextBox.TextChanged += durationTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(170, 66);
            label9.Name = "label9";
            label9.Size = new Size(115, 15);
            label9.TabIndex = 1;
            label9.Text = "Duration in minutes:";
            // 
            // moviesListBox
            // 
            moviesListBox.FormattingEnabled = true;
            moviesListBox.ItemHeight = 15;
            moviesListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            moviesListBox.Location = new Point(6, 22);
            moviesListBox.Name = "moviesListBox";
            moviesListBox.Size = new Size(158, 259);
            moviesListBox.TabIndex = 0;
            moviesListBox.SelectedIndexChanged += moviesListBox_SelectedIndexChanged;
            // 
            // groupBox3
            // 
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
            groupBox3.Location = new Point(12, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 300);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rectangles";
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
            rectangleButton.Location = new Point(165, 258);
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
            colourTextBox.TextChanged += colourTextBox_TextChanged;
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
            RectanglesListBox.Size = new Size(153, 259);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
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
            // yCenterTextBox
            // 
            yCenterTextBox.Enabled = false;
            yCenterTextBox.Location = new Point(165, 216);
            yCenterTextBox.Name = "yCenterTextBox";
            yCenterTextBox.Size = new Size(108, 23);
            yCenterTextBox.TabIndex = 11;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            Load += MainForm_Load;
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox EnumsListBox;
        private ListBox ValuesListBox;
        private TextBox IntValue;
        private GroupBox groupBox2;
        private TextBox NumberOfWeekday;
        private Button button1;
        private Label label4;
        private TextBox TextToParse;
        private GroupBox SeasonHandle;
        private Button ChooseSeason;
        private Label label5;
        private ComboBox comboBox1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox groupBox3;
        private Button rectangleButton;
        private TextBox colourTextBox;
        private Label label8;
        private TextBox widthTextBox;
        private Label label7;
        private TextBox lengthTextBox;
        private Label label6;
        private ListBox RectanglesListBox;
        private GroupBox groupBox4;
        private ListBox moviesListBox;
        private TextBox durationTextBox;
        private Label label9;
        private TextBox yearTextBox;
        private Label label10;
        private Button movieButton;
        private TextBox ratingTextBox;
        private Label label12;
        private TextBox genreTextBox;
        private Label label11;
        private Label label13;
        private TextBox titleTextBox;
        private TextBox xCenterTextBox;
        private Label label14;
        private Label label15;
        private TextBox yCenterTextBox;
    }
}