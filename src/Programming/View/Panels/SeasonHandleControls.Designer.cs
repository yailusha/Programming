namespace Programming.View.Panels
{
    partial class SeasonHandleControls
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
            SeasonHandle = new GroupBox();
            chooseSeasonButton = new Button();
            label5 = new Label();
            seasonComboBox = new ComboBox();
            SeasonHandle.SuspendLayout();
            SuspendLayout();
            // 
            // SeasonHandle
            // 
            SeasonHandle.Controls.Add(chooseSeasonButton);
            SeasonHandle.Controls.Add(label5);
            SeasonHandle.Controls.Add(seasonComboBox);
            SeasonHandle.Location = new Point(3, 3);
            SeasonHandle.Name = "SeasonHandle";
            SeasonHandle.Size = new Size(372, 127);
            SeasonHandle.TabIndex = 9;
            SeasonHandle.TabStop = false;
            SeasonHandle.Text = "Season Handle";
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
            // 
            // SeasonHandleControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeasonHandle);
            Name = "SeasonHandleControls";
            Size = new Size(382, 143);
            SeasonHandle.ResumeLayout(false);
            SeasonHandle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeasonHandle;
        private Button chooseSeasonButton;
        private Label label5;
        private ComboBox seasonComboBox;
    }
}
