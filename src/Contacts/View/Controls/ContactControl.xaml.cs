using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace View.Controls
{
    /// <summary>
    /// Отображает ContactControl
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Регулярная функция для валидации
        /// </summary>
        private static Regex _regex = new Regex(@"^[0-9+\-()\s]+$");

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactControl"/>
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
            PhoneNumberTextBox.PreviewTextInput += PhoneNumberTextBox_PreviewTextInput;
            DataObject.AddPastingHandler(PhoneNumberTextBox, PhoneNumberTextBox_Pasting);
        }

        /// <summary>
        /// Функция, которая запрещает водить данные, если те содрежат запрещенные символы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !_regex.IsMatch(e.Text);
        }

        /// <summary>
        /// Функция, которая запрещает вставлять данные, если те содержат запрещенные символы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhoneNumberTextBox_Pasting(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string phoneNumber = (string)e.DataObject.GetData(typeof(string));
                if (!_regex.IsMatch(phoneNumber))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        /// <summary>
        /// По умолчания свойство ReadOnly - true
        /// </summary>
        private static readonly DependencyProperty ReadonlyProperty =
            DependencyProperty.Register("IsReadonly", typeof(bool), typeof(ContactControl).BaseType,
                new PropertyMetadata(true));

        /// <summary>
        /// Возвращает свойство только для чтения
        /// </summary>
        public bool IsReadonly
        {
            get { return (bool)GetValue(ReadonlyProperty); }
            set { SetValue(ReadonlyProperty, value); }
        }
    }
}
