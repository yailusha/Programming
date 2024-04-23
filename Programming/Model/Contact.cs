using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Хранит данные о контактных данных человека.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Имя для всех объектов класса.
        /// </summary>
        private string _name;
        /// <summary>
        /// Фамилия для всех объектов класса.
        /// </summary>
        private string _surname;
        /// <summary>
        /// Номер телефона для всех объектов класса.
        /// </summary>
        private string _phoneNumber;
        /// <summary>
        /// Дополнительная информация для всех объектов класса.
        /// </summary>
        private string _extraInformation;
        /// <summary>
        /// Английский алфавит для дальнейшей валидации.
        /// </summary>
        private string englishLetters = "qwertyuiopasdfghjklzxcvbnm";
        /// <summary>
        /// Проверяет, состоит ли строка только из символов.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <returns>Возвращает наличие символа, отличного от английского алфавита.</returns>
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
        /// <summary>
        /// Возвращает и задает имя человека. Должжно содержать только английские буквы.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает фамилию человека. Должна содержать только английские буквы.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает номер телефона. Должен содержать только цифры.
        /// </summary>
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
        /// <summary>
        /// Возвращает и задает дополнительную информацию.
        /// </summary>
        private string ExtraInformation { get; set; }
        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>
        /// </summary>
        /// <param name="name">Имя. Должно состоять только из английских букв.</param>
        /// <param name="surname">Фамилия. Должна состоять только из английских букв.</param>
        /// <param name="phoneNumber">Номер телефона. Должен состоять только из цифр.</param>
        /// <param name="extraInformation">Дополнительная информация.</param>
        public Contact(string name, string surname, string phoneNumber, string extraInformation)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            ExtraInformation = extraInformation;
        }
        public Contact()
        {

        }
    }
}
