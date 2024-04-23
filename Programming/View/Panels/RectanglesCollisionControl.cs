using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;
using Programming.Model.Geometry;
using AppColors = Programming.Model.AppColors;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Rectangle = Programming.Model.Rectangle;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private readonly List<Rectangle> _rectangles = new List<Rectangle>();
        private List<Panel> _rectanglePanels = new List<Panel>();
        private Rectangle _currentRectangle;

        public RectanglesCollisionControl()
        {
            InitializeComponent();
        }
        private void ClearRectangleInfo()
        {
            idRecTextBox.Text = "";
            xRecTextBox.Text = "";
            yRecTextBox.Text = "";
            widthRecTextBox.Text = "";
            heightRecTextBox.Text = "";
        }
        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].BackColor = AppColors.CollisionFalse;
            }
            for (int i = 1; i < _rectangles.Count; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.CollisionTrue;
                        _rectanglePanels[j].BackColor = AppColors.CollisionTrue;
                    }
                }
            }
        }
        private void DrawRectangle()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                _rectanglePanels[i].Location = new Point((int)_rectangles[i].Center.X-_rectangles[i].Width/2, (int)_rectangles[i].Center.Y - _rectangles[i].Length/2);
                _rectanglePanels[i].Width = _rectangles[i].Width;
                _rectanglePanels[i].Height = _rectangles[i].Length;
                RectanglePanels.Controls.Add(_rectanglePanels[i]);
            }
        }
        private void UpdateRecListBox()
        {
            RecListBox.Items.Clear();
            foreach (Rectangle rectangle in _rectangles)
            {
                RecListBox.Items.Add($"{rectangle.Id - 5}: (X= {rectangle.Center.X}; Y= {rectangle.Center.Y};" +
                    $" W= {rectangle.Width}; H= {rectangle.Length})");
            }
        }
        private void RecListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = RecListBox.SelectedIndex;
            if (selectedIndex != -1)
            {
                _currentRectangle = _rectangles[selectedIndex];
                idRecTextBox.Text = selectedIndex.ToString();
                xRecTextBox.Text = _currentRectangle.Center.X.ToString();
                yRecTextBox.Text = _currentRectangle.Center.Y.ToString();
                widthRecTextBox.Text = _currentRectangle.Width.ToString();
                heightRecTextBox.Text = _currentRectangle.Length.ToString();
                RectanglePanels.Controls.Clear();
                DrawRectangle();
                FindCollisions();
            }
        }
        private void xRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int xCoord = int.Parse(xRecTextBox.Text);
                    if (xCoord < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Center.X = xCoord;

                    xRecTextBox.BackColor = AppColors.ValidatorTrueColor;
                    UpdateRecListBox();
                }
            }
            catch (FormatException)
            {
                xRecTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                xRecTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        private void yRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int yCoord = int.Parse(yRecTextBox.Text);
                    if (yCoord < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Center.Y = yCoord;
                    yRecTextBox.BackColor = AppColors.ValidatorTrueColor;
                    UpdateRecListBox();
                }
            }
            catch (FormatException)
            {
                yRecTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                yRecTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        private void widthRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int width = int.Parse(widthRecTextBox.Text);
                    if (width <= 0 || width > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Width = width;
                    widthRecTextBox.BackColor = AppColors.ValidatorTrueColor;
                    UpdateRecListBox();
                }
            }
            catch (FormatException)
            {
                widthRecTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                widthRecTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        private void heightRecTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (_currentRectangle != null)
                {
                    int heigth = int.Parse(heightRecTextBox.Text);
                    if (heigth <= 0 || heigth > 100)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    _currentRectangle.Length = heigth;
                    heightRecTextBox.BackColor = AppColors.ValidatorTrueColor;
                    UpdateRecListBox();
                }
            }
            catch (FormatException)
            {
                heightRecTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
            catch (ArgumentOutOfRangeException)
            {
                heightRecTextBox.BackColor = AppColors.ValidatorFalseColor;
            }
        }
        private void addRectangleButton_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = RectangleFactory.Randomize();
            Panel panel = new Panel
            {
                Location = new Point((int)rectangle.Center.X-rectangle.Width/2,(int) rectangle.Center.Y-rectangle.Length/2),
                Width = (int)rectangle.Width,
                Height = (int)rectangle.Length,
                BackColor =AppColors.CollisionFalse
            };
            RectanglePanels.Controls.Add(panel);
            _rectanglePanels.Add(panel);
            _rectangles.Add(rectangle);
            UpdateRecListBox();
            FindCollisions();
        }
        private void deleteRectangleButton_Click(object sender, EventArgs e)
        {
            if (RecListBox.SelectedIndex != -1)
            {
                int selectedIndex = RecListBox.SelectedIndex;
                ClearRectangleInfo();
                _rectangles.RemoveAt(selectedIndex);
                RecListBox.Items.RemoveAt(selectedIndex);
                _rectanglePanels.RemoveAt(selectedIndex);
                RectanglePanels.Controls.RemoveAt(selectedIndex);
                FindCollisions();
            }
        }
    }
}
