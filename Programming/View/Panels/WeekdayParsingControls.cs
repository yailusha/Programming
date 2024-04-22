using Programming.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class WeekdayParsingControls : UserControl
    {
        public WeekdayParsingControls()
        {
            InitializeComponent();
        }
        private void parseButton_Click(object sender, EventArgs e)
        {
            Weekday weekday;
            string day = TextToParse.Text;
            int numbers;
            if (int.TryParse(day, out numbers))
            {
                resultOfWeekday.Text = "Введите день недели, а не число!";
                return;
            }

            if (Enum.TryParse(day, out weekday))
                resultOfWeekday.Text = $"Это день недели ({weekday} = {(int)weekday})";
            else
                resultOfWeekday.Text = "Нет такого дня недели";
        }
    }
}
