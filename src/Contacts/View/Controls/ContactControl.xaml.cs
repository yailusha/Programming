using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View.Controls
{
    /// <summary>
    /// Interaction logic for ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {

        private static Regex _regex = new Regex(@"^[0-9+\-()\s]+$");

        public ContactControl()
        {
            InitializeComponent();
            PhoneNumberTextBox.PreviewTextInput += PhoneNumberTextBox_PreviewTextInput;
            DataObject.AddPastingHandler(PhoneNumberTextBox, PhoneNumberTextBox_Pasting);
        }

        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !_regex.IsMatch(e.Text);
        }

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

        private static readonly DependencyProperty ReadonlyProperty =
            DependencyProperty.Register("IsReadonly", typeof(bool), typeof(ContactControl).BaseType,
                new PropertyMetadata(true));

        public bool IsReadonly
        {
            get { return (bool)GetValue(ReadonlyProperty); }
            set { SetValue(ReadonlyProperty, value); }
        }
    }
}
