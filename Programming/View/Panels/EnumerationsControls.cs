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
    /// <summary>
    /// Хранит данные о пользовательском интерфейсе GroupBox'а перечислений.
    /// </summary>
    public partial class EnumerationsControls : UserControl
    {
        public EnumerationsControls()
        {
            InitializeComponent();
        }
        //Приведение всех перечисление к одному типу.
        private readonly Type[] _typeModel = new Type[] { typeof(Colours),
        typeof(FormOfTheStudentEducation), typeof(Genre), typeof (SeasonOfYear),
        typeof(SmartphoneManufacturers), typeof(Weekday)};
        /// <summary>
        /// Отображает числовое значение выбранного элемента перечисления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = ValuesListBox.SelectedIndex;
            intValueTextBox.Text = selectedIndex.ToString();
        }
        /// <summary>
        /// Отображает в выбранном перечислении его значения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnumsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(_typeModel[selectedIndex]).Cast<object>().ToArray();
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }
        private void intValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
