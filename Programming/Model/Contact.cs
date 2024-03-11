using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        private string name;
        private string phoneNumber;
        private string ExtraInformation { get;set; }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Имя не может быть пустым");
                }
                name = value;
            }
        }
        public string PhoneNumber
        {
            get { return phoneNumber; }
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

                if (string.IsNullOrEmpty (value) || value.Length < 12 || flag)
                {
                    throw new ArgumentException("Номер телефона должен начинаться с + и содержать 11 цифр");
                }
                phoneNumber = value;
            }
        }
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
