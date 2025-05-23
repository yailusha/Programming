using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Model
{
    /// <summary>
    /// Хранит информацию о контактных данных человека.
    /// </summary>
    public partial class Contact : ObservableObject, IDataErrorInfo
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        [ObservableProperty]
        private string _name;

        /// <summary>
        /// Номер телефона человека.
        /// </summary>
        [ObservableProperty]
        private string _phoneNumber;

        /// <summary>
        /// Электронная почта человека.
        /// </summary>
        [ObservableProperty]
        private string _email;

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

        /// <summary>
        /// Создает копию экземпляра класса <see cref="Contact"/>
        /// </summary>
        /// <param name="contact">Копия контакта</param>
        public Contact(Contact contact)
        {
            if (contact != null)
            {
                Name = contact.Name;
                PhoneNumber = contact.PhoneNumber;
                Email = contact.Email;
            }
        }

        public Contact()
        {

        }

        /// <summary>
        /// Обеспечивает валидацию для всех полей
        /// </summary>
        /// <param name="columnName">Проверяем свойство</param>
        /// <returns></returns>
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

        /// <summary>
        /// Возвращает ошибки
        /// </summary>
        public string Error => null;
    }
}
