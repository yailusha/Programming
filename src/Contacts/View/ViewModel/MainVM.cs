using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Model;
using Services;

namespace ViewModel
{
    /// <summary>
    /// Хранит данные о MainVM.
    /// </summary>
    internal class MainVM : INotifyPropertyChanged
    {
        /// <summary>
        /// Контактные данные человека.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Контактный сериализатор.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Команда для сохранения в файл.
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Команада для выгрузки из файла.
        /// </summary>
        public ICommand LoadCommand { get; }

        /// <summary>
        /// Задает и возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get { return _contact.Name; }
            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Задает и возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return _contact.PhoneNumber; }
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Задает и возвращает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get { return _contact.Email; }
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>
        /// </summary>
        public MainVM ()
        {
            _contact = new Contact ();
            _serializer = new ContactSerializer ();
            SaveCommand = new SaveCommand(_serializer, _contact);
            LoadCommand = new LoadCommand(_serializer, this);
        }

        /// <summary>
        /// Событие при изменении данных.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Уведомляет о том, где произошло изменение.
        /// </summary>
        /// <param name="propertyName">Название свойства.</param>
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
