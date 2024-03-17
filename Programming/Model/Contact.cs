using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        private string _name;
        private string _surname;
        private string _phoneNumber;
        private string _extraInformation;
        private string englishLetters = "qwertyuiopasdfghjklzxcvbnm";
        private bool AssertStringContainOnlyLetters(string value)
        {
            value = value.ToLower();
            foreach (char c in value)
            {
                if (!englishLetters.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (!AssertStringContainOnlyLetters(value))
                {
                    throw new ArgumentException("Name must contain only English letters");
                }
                _name = value;
            }
        }
        public string Surname
        { 
            get { return _surname; }
            set
            {
                if (!AssertStringContainOnlyLetters(value))
                {
                    throw new ArgumentException("Surname must contain only English letters");
                }
                _surname = value;
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                bool flag = false;
                foreach(char c in value)
                {
                    if (char.IsLetter(c))
                    {
                        flag = true;
                    }
                }

                if (string.IsNullOrEmpty (value) || value.Length != 11 || flag)
                {
                    throw new ArgumentException("Phone number must contain 11 numbers");
                }
                _phoneNumber = value;
            }
        }
        private string ExtraInformation { get; set; }
        public Contact(string name, string phoneNumber, string extraInformation)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            ExtraInformation = extraInformation;
        }
        public Contact()
        {

        }
    }
}
