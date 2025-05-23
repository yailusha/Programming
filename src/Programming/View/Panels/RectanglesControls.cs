using Programming.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.Panels
{
    /// <summary>
    /// Хранит данные о пользовательском интерфейсе.
    /// </summary>
    public partial class RectanglesControls : UserControl
    {
        Rectangle[] _rectangles;
        Rectangle _currentRectangle;
        public RectanglesControls()
        {
            Random random = new Random();
            //Создание списка с 5 прямоугольниками.
            _rectangles = new Rectangle[5];

            string[] colors = new string[] { "green", "black", "red", "blue", "yellow" };
            //Генерация прямоугольников.
            for (int i = 0; i < _rectangles.Length; i++)
            {
                //Генерация длины и ширины прямоугольника в интервале от 1 до 100.
                int length = random.Next(1, 100);
                int width = random.Next(1, 100);

                //Генерация цвета прямоугольника.
                int selectedColor = random.Next(colors.Length);

                //Генерация координат центра прямоугольника в интервале от 1 до 350.
                int xCenter = random.Next(1, 350);
                int yCenter = random.Next(1, 350);

                Point2D center = new Point2D(xCenter, yCenter);
                _currentRectangle = new Rectangle(length, width, colors[selectedColor], center);
                _rectangles[i] = _currentRectangle;
            }
            InitializeComponent();
        }
        /// <summary>
        /// Осуществляет поиск прямоугольника с наибольшей шириной.
        /// </summary>
        /// <returns>Возвращает индекс прямоугольника с максимальной шириной.</returns>
        /// <exception cref="InvalidOperationException">Выдает ошибку в случае отсутствия прямоугольников.</exception>
        private int FindRectangleWithMaxWidth()
        {
            if (_rectangles.Length != 0)
            {
                int indexOfMaxWidth = 0;
                double maxWidth = _rectangles[0].Width;
                for (int i = 1; i < _rectangles.Length; i++)
                {
                    if (maxWidth < _rectangles[i].Width)
                    {
                        maxWidth = _rectangles[i].Width;
                        indexOfMaxWidth = i;
                    }
                }
                return indexOfMaxWidth;
            }
            throw new InvalidOperationException("No rectangles there are");
        }
        /// <summary>
        /// Отображает данные выбранного прямоугольника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndex];
            if (_currentRectangle != null)
            {
                lengthTextBox.Text = _currentRectangle.Length.ToString();
                widthTextBox.Text = _currentRectangle.Width.ToString();
                colourTextBox.Text = _currentRectangle.Colour.ToString();
                xCenterTextBox.Text = _currentRectangle.Center.X.ToString();
                yCenterTextBox.Text = _currentRectangle.Center.Y.ToString();
                idTextBox.Text = (_currentRectangle.Id-2).ToString();
            }
        }
        /// <summary>
        /// Изменение и сохранение новой длины прямоугольника с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int length = int.Parse(lengthTextBox.Text);
                    if (length <= 0 || length > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Length = length;
                    lengthTextBox.BackColor = AppColors.ValidatorTrueColor;
                }
            }
            catch (FormatException)
            {
                lengthTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                lengthTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение новой ширины прямоугольника с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int width = int.Parse(widthTextBox.Text);
                    if (width <= 0 || width > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Width = width;
                    widthTextBox.BackColor = AppColors.ValidatorTrueColor;
                }
            }
            catch (FormatException)
            {
                widthTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                widthTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Изменение и сохранение нового цвета прямоугольника с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void colourTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string colour = colourTextBox.Text;
                if (string.IsNullOrEmpty(colour))
                {
                    throw new ArgumentNullException();
                }
                foreach (char c in colour)
                {
                    if (char.IsDigit(c))
                    {
                        throw new ArgumentException();
                    }
                }
                _currentRectangle.Colour = colour;
                colourTextBox.BackColor = AppColors.ValidatorTrueColor;
            }
            catch (ArgumentNullException)
            {
                colourTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentException)
            {
                colourTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        /// <summary>
        /// Осуществляет поиск прямоугольника с максимальной шириной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rectangleButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
        }
    }
}
