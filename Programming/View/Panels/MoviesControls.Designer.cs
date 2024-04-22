namespace Programming.View.Panels
{
    partial class MoviesControls
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
            groupBox4.SuspendLayout();
            SuspendLayout();
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
            groupBox4.Location = new Point(3, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(348, 319);
            groupBox4.TabIndex = 2;
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
            // MoviesControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Name = "MoviesControls";
            Size = new Size(363, 334);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox4;
        private Label label13;
        private TextBox titleTextBox;
        private Button movieButton;
        private TextBox ratingTextBox;
        private Label label12;
        private TextBox genreTextBox;
        private Label label11;
        private TextBox yearTextBox;
        private Label label10;
        private TextBox durationTextBox;
        private Label label9;
        private ListBox MoviesListBox;
    }
}
