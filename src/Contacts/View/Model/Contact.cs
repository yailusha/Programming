using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Хранит информацию о контактных данных человека.
    /// </summary>
    internal class Contact : IDataErrorInfo
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        private string _name;

        /// <summary>
        /// Номер телефона человека.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Электронная почта человека.
        /// </summary>
        private string _email;

        /// <summary>
        /// Возвращает и задает имя человека.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value) return;
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и задает номер телефона человека.
        /// </summary>
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber == value) return;
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Возвращает и задает электронную почту человека.
        /// </summary>
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email == value) return;
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <param name="phoneNumber">Номер телефона.</param>
        /// <param name="email">Электронная почта.</param>
        public Contact(string name, string phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public Contact()
        {

        }

        public string this[string columnName]
        {
            get
            {
                string error = string.Empty;
                switch (columnName)
                {
                    case nameof(Name):
                        {
                            if (!string.IsNullOrEmpty(Name))
                            {
                                if (Name.Length > 100)
                                {
                                    error = "Length of name must be 100 or less";
                                }
                            }
                            break;
                        }
                    case nameof(PhoneNumber):
                        {
                            if (!string.IsNullOrEmpty(PhoneNumber))
                            {
                                if (PhoneNumber.Length > 100)
                                {
                                    error = "Length of phone number must be 100 or less";
                                }
                                if (!Regex.IsMatch(PhoneNumber, @"^[0-9+\-()\s]+$"))
                                {
                                    error = "Phone number can contain only +()- or digits";
                                }
                            }
                            break;
                        }
                    case nameof(Email):
                        {
                            if (!string.IsNullOrEmpty(Email))
                            {
                                if (Email.Length > 100)
                                {
                                    error = "Length of email must be 100 or less";
                                }
                                if (!Email.Contains("@"))
                                {
                                    error = "Email must contain @";
                                }
                            }
                            break;
                        }
                }
                return error;
            }
        }

        public string Error => null;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Уведомляет об изменении свойства с помощью события <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="propertyName">Название свойства</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
