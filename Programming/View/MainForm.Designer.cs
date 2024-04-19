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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            EnumsListBox = new ListBox();
            ValuesListBox = new ListBox();
            intValueTextBox = new TextBox();
            groupBox2 = new GroupBox();
            resultOfWeekday = new TextBox();
            parseButton = new Button();
            label4 = new Label();
            TextToParse = new TextBox();
            SeasonHandle = new GroupBox();
            chooseSeasonButton = new Button();
            label5 = new Label();
            seasonComboBox = new ComboBox();
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
            MoviesListBox = new ListBox();
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
            tabPage3 = new TabPage();
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
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SeasonHandle.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            tabPage3.SuspendLayout();
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(EnumsListBox);
            groupBox1.Controls.Add(ValuesListBox);
            groupBox1.Controls.Add(intValueTextBox);
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
            // intValueTextBox
            // 
            intValueTextBox.Enabled = false;
            intValueTextBox.Location = new Point(379, 37);
            intValueTextBox.Name = "intValueTextBox";
            intValueTextBox.Size = new Size(145, 23);
            intValueTextBox.TabIndex = 2;
            intValueTextBox.TextChanged += intValueTextBox_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resultOfWeekday);
            groupBox2.Controls.Add(parseButton);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TextToParse);
            groupBox2.Location = new Point(0, 286);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 128);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekday Paring";
            // 
            // resultOfWeekday
            // 
            resultOfWeekday.Enabled = false;
            resultOfWeekday.Location = new Point(17, 78);
            resultOfWeekday.Name = "resultOfWeekday";
            resultOfWeekday.Size = new Size(246, 23);
            resultOfWeekday.TabIndex = 3;
            resultOfWeekday.TextChanged += resultOfWeekday_TextChanged;
            // 
            // parseButton
            // 
            parseButton.Location = new Point(269, 38);
            parseButton.Name = "parseButton";
            parseButton.Size = new Size(87, 23);
            parseButton.TabIndex = 2;
            parseButton.Text = "Parse";
            parseButton.UseVisualStyleBackColor = true;
            parseButton.Click += parseButton_Click;
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
            // 
            // SeasonHandle
            // 
            SeasonHandle.Controls.Add(chooseSeasonButton);
            SeasonHandle.Controls.Add(label5);
            SeasonHandle.Controls.Add(seasonComboBox);
            SeasonHandle.Location = new Point(390, 287);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Size = new Size(372, 127);
            SeasonHandle.TabIndex = 8;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "SeasonHadle";
            // 
            // chooseSeasonButton
            // 
            chooseSeasonButton.Location = new Point(180, 37);
            chooseSeasonButton.Name = "chooseSeasonButton";
            chooseSeasonButton.Size = new Size(91, 23);
            chooseSeasonButton.TabIndex = 2;
            chooseSeasonButton.Text = "Go!";
            chooseSeasonButton.UseVisualStyleBackColor = true;
            chooseSeasonButton.Click += chooseSeasonButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 20);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 1;
            label5.Text = "Choose season:";
            // 
            // seasonComboBox
            // 
            seasonComboBox.FormattingEnabled = true;
            seasonComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            seasonComboBox.Location = new Point(6, 38);
            seasonComboBox.Name = "seasonComboBox";
            seasonComboBox.Size = new Size(168, 23);
            seasonComboBox.TabIndex = 0;
            seasonComboBox.SelectedIndexChanged += seasonComboBox_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
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
            groupBox4.Controls.Add(MoviesListBox);
            groupBox4.Location = new Point(412, 21);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(348, 319);
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
            movieButton.Location = new Point(170, 288);
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
            // MoviesListBox
            // 
            MoviesListBox.FormattingEnabled = true;
            MoviesListBox.ItemHeight = 15;
            MoviesListBox.Items.AddRange(new object[] { "Movie 1", "Movie 2", "Movie 3", "Movie 4", "Movie 5" });
            MoviesListBox.Location = new Point(6, 22);
            MoviesListBox.Name = "MoviesListBox";
            MoviesListBox.Size = new Size(158, 289);
            MoviesListBox.TabIndex = 0;
            MoviesListBox.SelectedIndexChanged += MoviesListBox_SelectedIndexChanged;
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
            groupBox3.Location = new Point(12, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(348, 319);
            groupBox3.TabIndex = 0;
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
            RectanglesListBox.Location = new Point(6, 22);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(153, 289);
            RectanglesListBox.TabIndex = 0;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(heightRecTextBox);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(widthRecTextBox);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(yRecTextBox);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(xRecTextBox);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(idRecTextBox);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(deleteRectangleButton);
            tabPage3.Controls.Add(addRectangleButton);
            tabPage3.Controls.Add(RecListBox);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(RectanglePanels);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rectangles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // heightRecTextBox
            // 
            heightRecTextBox.Location = new Point(63, 384);
            heightRecTextBox.Name = "heightRecTextBox";
            heightRecTextBox.Size = new Size(136, 23);
            heightRecTextBox.TabIndex = 15;
            heightRecTextBox.TextChanged += heightRecTextBox_TextChanged;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(11, 387);
            label23.Name = "label23";
            label23.Size = new Size(46, 15);
            label23.TabIndex = 14;
            label23.Text = "Height:";
            // 
            // widthRecTextBox
            // 
            widthRecTextBox.Location = new Point(63, 355);
            widthRecTextBox.Name = "widthRecTextBox";
            widthRecTextBox.Size = new Size(136, 23);
            widthRecTextBox.TabIndex = 13;
            widthRecTextBox.TextChanged += widthRecTextBox_TextChanged;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(15, 358);
            label22.Name = "label22";
            label22.Size = new Size(42, 15);
            label22.TabIndex = 12;
            label22.Text = "Width:";
            // 
            // yRecTextBox
            // 
            yRecTextBox.Location = new Point(63, 324);
            yRecTextBox.Name = "yRecTextBox";
            yRecTextBox.Size = new Size(136, 23);
            yRecTextBox.TabIndex = 11;
            yRecTextBox.TextChanged += yRecTextBox_TextChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(40, 327);
            label21.Name = "label21";
            label21.Size = new Size(17, 15);
            label21.TabIndex = 10;
            label21.Text = "Y:";
            // 
            // xRecTextBox
            // 
            xRecTextBox.Location = new Point(63, 295);
            xRecTextBox.Name = "xRecTextBox";
            xRecTextBox.Size = new Size(136, 23);
            xRecTextBox.TabIndex = 9;
            xRecTextBox.TextChanged += xRecTextBox_TextChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(40, 298);
            label20.Name = "label20";
            label20.Size = new Size(17, 15);
            label20.TabIndex = 8;
            label20.Text = "X:";
            // 
            // idRecTextBox
            // 
            idRecTextBox.Enabled = false;
            idRecTextBox.Location = new Point(63, 264);
            idRecTextBox.Name = "idRecTextBox";
            idRecTextBox.ReadOnly = true;
            idRecTextBox.Size = new Size(136, 23);
            idRecTextBox.TabIndex = 7;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(37, 267);
            label19.Name = "label19";
            label19.Size = new Size(20, 15);
            label19.TabIndex = 6;
            label19.Text = "Id:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 241);
            label18.Name = "label18";
            label18.Size = new Size(109, 15);
            label18.TabIndex = 5;
            label18.Text = "Selected Rectangle:";
            // 
            // deleteRectangleButton
            // 
            deleteRectangleButton.BackColor = Color.White;
            deleteRectangleButton.Image = (Image)resources.GetObject("deleteRectangleButton.Image");
            deleteRectangleButton.Location = new Point(120, 181);
            deleteRectangleButton.Name = "deleteRectangleButton";
            deleteRectangleButton.Size = new Size(67, 57);
            deleteRectangleButton.TabIndex = 4;
            deleteRectangleButton.UseVisualStyleBackColor = false;
            deleteRectangleButton.Click += deleteRectangleButton_Click;
            // 
            // addRectangleButton
            // 
            addRectangleButton.BackColor = Color.White;
            addRectangleButton.FlatAppearance.BorderColor = Color.White;
            addRectangleButton.FlatAppearance.BorderSize = 0;
            addRectangleButton.Image = (Image)resources.GetObject("addRectangleButton.Image");
            addRectangleButton.Location = new Point(37, 181);
            addRectangleButton.Name = "addRectangleButton";
            addRectangleButton.Size = new Size(67, 57);
            addRectangleButton.TabIndex = 3;
            addRectangleButton.UseVisualStyleBackColor = false;
            addRectangleButton.Click += addRectangleButton_Click;
            // 
            // RecListBox
            // 
            RecListBox.FormattingEnabled = true;
            RecListBox.ItemHeight = 15;
            RecListBox.Location = new Point(8, 24);
            RecListBox.Name = "RecListBox";
            RecListBox.Size = new Size(295, 154);
            RecListBox.TabIndex = 2;
            RecListBox.SelectedIndexChanged += RecListBox_SelectedIndexChanged;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(8, 6);
            label17.Name = "label17";
            label17.Size = new Size(67, 15);
            label17.TabIndex = 1;
            label17.Text = "Rectangles:";
            // 
            // RectanglePanels
            // 
            RectanglePanels.BorderStyle = BorderStyle.FixedSingle;
            RectanglePanels.Location = new Point(309, 6);
            RectanglePanels.Name = "RectanglePanels";
            RectanglePanels.Size = new Size(480, 413);
            RectanglePanels.TabIndex = 0;
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
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
        private TextBox intValueTextBox;
        private GroupBox groupBox2;
        private TextBox resultOfWeekday;
        private Button parseButton;
        private Label label4;
        private TextBox TextToParse;
        private GroupBox SeasonHandle;
        private Button chooseSeasonButton;
        private Label label5;
        private ComboBox seasonComboBox;
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
        private ListBox MoviesListBox;
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
        private TextBox idTextBox;
        private Label label16;
        private TabPage tabPage3;
        private Panel RectanglePanels;
        private Label label19;
        private Label label18;
        private Button deleteRectangleButton;
        private Button addRectangleButton;
        private ListBox RecListBox;
        private Label label17;
        private TextBox heightRecTextBox;
        private Label label23;
        private TextBox widthRecTextBox;
        private Label label22;
        private TextBox yRecTextBox;
        private Label label21;
        private TextBox xRecTextBox;
        private Label label20;
        private TextBox idRecTextBox;
    }
}