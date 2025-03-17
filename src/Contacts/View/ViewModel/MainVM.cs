using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    internal class MainVM : INotifyPropertyChanged
    {
        private Contact _contact;
        public string Name
        {
            get { return _contact.Name; }
            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }
        public string PhoneNumber
        {
            get { return _contact.PhoneNumber; }
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }
        public string Email
        {
            get { return _contact.Email; }
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
        public MainVM ()
        {
            _contact = new Contact ();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
