namespace lab7_2
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(273, 36);
            label1.TabIndex = 0;
            label1.Text = "Введите данные через запятую\r\n      для каждого магазина";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 128);
            label2.Name = "label2";
            label2.Size = new Size(155, 36);
            label2.TabIndex = 1;
            label2.Text = "Стоимость товара\r\n      в рублях";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(173, 18);
            label3.TabIndex = 2;
            label3.Text = "Название магазина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 63);
            label4.Name = "label4";
            label4.Size = new Size(152, 18);
            label4.TabIndex = 3;
            label4.Text = "Название товара";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(573, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(573, 27);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(203, 95);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(573, 27);
            textBox3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(12, 179);
            button1.Name = "button1";
            button1.Size = new Size(192, 89);
            button1.TabIndex = 7;
            button1.Text = "Внесение данных в файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(210, 179);
            button2.Name = "button2";
            button2.Size = new Size(192, 89);
            button2.TabIndex = 8;
            button2.Text = "Вывод данных";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.Enabled = false;
            // 
            // button3
            // 
            button3.Location = new Point(408, 179);
            button3.Name = "button3";
            button3.Size = new Size(192, 89);
            button3.TabIndex = 9;
            button3.Text = "   Вывод товаров, у которых\r\nмагазин введён с клавиатуры";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            button3.Enabled = false;
            // 
            // button4
            // 
            button4.Location = new Point(606, 179);
            button4.Name = "button4";
            button4.Size = new Size(192, 89);
            button4.TabIndex = 10;
            button4.Text = "Отсортировать список в файле";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            button4.Enabled = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 308);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Магазины";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}