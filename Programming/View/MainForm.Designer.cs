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
            seasonHandleControls1 = new View.Panels.SeasonHandleControls();
            weekdayParsingControls1 = new View.Panels.WeekdayParsingControls();
            enumerationsControls1 = new View.Panels.EnumerationsControls();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            rectanglesControls1 = new View.Panels.RectanglesControls();
            tabPage3 = new TabPage();
            rectanglesCollisionControl1 = new View.Panels.RectanglesCollisionControl();
            moviesControls1 = new View.Panels.MoviesControls();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(seasonHandleControls1);
            tabPage1.Controls.Add(weekdayParsingControls1);
            tabPage1.Controls.Add(enumerationsControls1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(794, 436);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Enums";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // seasonHandleControls1
            // 
            seasonHandleControls1.Location = new Point(390, 287);
            seasonHandleControls1.Name = "seasonHandleControls1";
            seasonHandleControls1.Size = new Size(382, 143);
            seasonHandleControls1.TabIndex = 11;
            // 
            // weekdayParsingControls1
            // 
            weekdayParsingControls1.Location = new Point(3, 287);
            weekdayParsingControls1.Name = "weekdayParsingControls1";
            weekdayParsingControls1.Size = new Size(381, 140);
            weekdayParsingControls1.TabIndex = 10;
            // 
            // enumerationsControls1
            // 
            enumerationsControls1.Location = new Point(3, 0);
            enumerationsControls1.Name = "enumerationsControls1";
            enumerationsControls1.Size = new Size(776, 281);
            enumerationsControls1.TabIndex = 9;
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
            tabControl1.Size = new Size(802, 464);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(moviesControls1);
            tabPage2.Controls.Add(rectanglesControls1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(794, 436);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Classes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rectanglesControls1
            // 
            rectanglesControls1.Location = new Point(17, 21);
            rectanglesControls1.Name = "rectanglesControls1";
            rectanglesControls1.Size = new Size(359, 331);
            rectanglesControls1.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(rectanglesCollisionControl1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(794, 436);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Rectangles";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(3, 3);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(788, 430);
            rectanglesCollisionControl1.TabIndex = 0;
            // 
            // moviesControls1
            // 
            moviesControls1.Location = new Point(382, 21);
            moviesControls1.Name = "moviesControls1";
            moviesControls1.Size = new Size(363, 334);
            moviesControls1.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 464);
            Controls.Add(tabControl1);
            Name = "MainForm";
            Text = "Programming Demo";
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.EnumerationsControls enumerationsControls1;
        private View.Panels.WeekdayParsingControls weekdayParsingControls1;
        private View.Panels.SeasonHandleControls seasonHandleControls1;
        private View.Panels.RectanglesControls rectanglesControls1;
        private View.Panels.MoviesControls moviesControls1;
    }
}