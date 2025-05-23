namespace Programming.View.Panels
{
    partial class WeekdayParsingControls
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
            groupBox2 = new GroupBox();
            resultOfWeekday = new TextBox();
            parseButton = new Button();
            label4 = new Label();
            TextToParse = new TextBox();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resultOfWeekday);
            groupBox2.Controls.Add(parseButton);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(TextToParse);
            groupBox2.Location = new Point(3, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(373, 128);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Weekday Parsing";
            // 
            // resultOfWeekday
            // 
            resultOfWeekday.Enabled = false;
            resultOfWeekday.Location = new Point(17, 78);
            resultOfWeekday.Name = "resultOfWeekday";
            resultOfWeekday.Size = new Size(246, 23);
            resultOfWeekday.TabIndex = 3;
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
            label4.Size = new Size(125, 15);
            label4.TabIndex = 1;
            label4.Text = "Type value for parsing:";
            // 
            // TextToParse
            // 
            TextToParse.Location = new Point(17, 38);
            TextToParse.Name = "TextToParse";
            TextToParse.Size = new Size(246, 23);
            TextToParse.TabIndex = 0;
            // 
            // WeekdayParsingControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Name = "WeekdayParsingControls";
            Size = new Size(389, 140);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private TextBox resultOfWeekday;
        private Button parseButton;
        private Label label4;
        private TextBox TextToParse;
    }
}
