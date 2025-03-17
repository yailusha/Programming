using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model.Services;

namespace View.Model
{
    internal class Contact
    {
        private string _name;
        private string _phoneNumber;
        private string _email;

        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;
                ValueValidator.AssertStringOnLength(value, 100, nameof(Name));
                _name = value;
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber == value) return;
                ValueValidator.AssertStringOnMinLength(value, 11, nameof(PhoneNumber));
                _phoneNumber = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email == value) return;
                if (!value.Contains("@"))
                {
                    throw new ArgumentException("Email doesn't contain \"@\"");
                }
                ValueValidator.AssertStringOnLength(value, 100, nameof(Email));
                _email = value;
            }
        }
        public Contact (string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public Contact()
        {

        }
    }
}
