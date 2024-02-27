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
            tabControl1 = new TabControl();
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
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SeasonHandle.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
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
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            Load += MainForm_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private TextBox IntValue;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox TextToParse;
        private TextBox NumberOfWeekday;
        private Button button1;
        private GroupBox SeasonHandle;
        private Label label5;
        private ComboBox comboBox1;
        private Button ChooseSeason;
    }
}