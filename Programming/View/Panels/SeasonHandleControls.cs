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
    /// Хранит данные о пользовательском интерфейсе.
    /// </summary>
    public partial class SeasonHandleControls : UserControl
    {
        public SeasonHandleControls()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Осуществляет различные действия ввиду выбора.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chooseSeasonButton_Click(object sender, EventArgs e)
        {
            switch (seasonComboBox.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("ХОЛОДНО!");
                    break;
                case 1:
                    MessageBox.Show("Слякоть(");
                    break;
                case 2:
                    MessageBox.Show("Ура! Сессия сдана! Лето!");
                    break;
                case 3:
                    MessageBox.Show("ОСЕНЬ ПЬЯНАЯЯЯЯЯЯЯ");
                    break;
            }
        }
    }
}
