using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Model;
using Services;
using View.ViewModel;

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
        private Contact _selectedContact;

        private Contact _editingContact;

        /// <summary>
        /// Контактный сериализатор.
        /// </summary>
        private readonly ContactSerializer _serializer;

        private bool _isAddingOrEdditing;

        

        /// <summary>
        /// Команда для сохранения в файл.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Команада для выгрузки из файла.
        /// </summary>
        public ICommand EditCommand { get; }

        public ICommand RemoveCommand { get; }

        public ICommand ApplyCommand { get; }

        public ICommand SaveCommand { get; }

        public ObservableCollection<Contact> Contacts { get; }

        /// <summary>
        /// Задает и возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get { return EditingContact?.Name; }
            set
            {
                if (EditingContact != null)
                {
                    EditingContact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Задает и возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get { return EditingContact?.PhoneNumber; }
            set
            {
                if (EditingContact != null)
                {
                    EditingContact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }

            }
        }

        /// <summary>
        /// Задает и возвращает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get { return EditingContact?.Email; }
            set
            {
                if (EditingContact != null)
                {
                    EditingContact.Email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        public Contact SelectedContact
        {
            get { return _selectedContact; }
            set
            {
                if (_isAddingOrEdditing && value != _selectedContact)
                {
                    _isAddingOrEdditing = false;
                    _selectedContact = null;
                }
                _selectedContact = value;
                OnPropertyChanged(nameof(SelectedContact));
            }
        }

        public Contact EditingContact
        {
            get { return _editingContact; }
            set
            {
                _editingContact = value;
                OnPropertyChanged(nameof(EditingContact));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Email));
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public bool IsReadonly
        {
            get { return !_isAddingOrEdditing; }
        }

        public bool IsEnabled
        {
            get { return _selectedContact != null && Contacts.Count > 0; }
        }

        public bool IsAddingOrEditing
        {
            get { return _isAddingOrEdditing; }
            set
            {
                if (_isAddingOrEdditing != value)
                {
                    _isAddingOrEdditing = value;
                    OnPropertyChanged(nameof(IsReadonly));
                    OnPropertyChanged(nameof(IsEnabled));
                }
            }
        }

        private void ExecuteAddCommand(object parameter)
        {
            SelectedContact = null;
            EditingContact = new Contact();
            _isAddingOrEdditing = true;
            OnPropertyChanged(nameof(IsReadonly));
            OnPropertyChanged(nameof(IsEnabled));
        }

        private void ExecuteEditCommand(object parameter)
        {
            if (SelectedContact != null)
            {
                _isAddingOrEdditing = true;
                EditingContact = new Contact
                {
                    Name = SelectedContact.Name,
                    Email = SelectedContact.Email,
                    PhoneNumber = SelectedContact.PhoneNumber,
                };
                OnPropertyChanged(nameof(IsReadonly));
                OnPropertyChanged(nameof(IsEnabled));
            }
        }

        private void ExecuteRemoveCommand(object parameter)
        {
            if (SelectedContact != null)
            {
                int index = Contacts.IndexOf(SelectedContact);
                if (index >= 0)
                {
                    Contacts.RemoveAt(index);
                    if (Contacts.Count == 0)
                    {
                        SelectedContact = null;
                    }
                    else
                    {
                        SelectedContact = Contacts[index];
                    }
                }
                OnPropertyChanged(nameof(IsEnabled));
            }
        }


        private void ExecuteApplyCommand(object parameter)
        {
            if (SelectedContact == null)
            {
                Contact contact = new Contact
                (
                    EditingContact.Name,
                    EditingContact.Email,
                    EditingContact.PhoneNumber
                );
                Contacts.Add(contact);
                SelectedContact = contact;
            }
            else
            {
                SelectedContact.Name = EditingContact.Name;
                SelectedContact.Email = EditingContact.Email;
                SelectedContact.PhoneNumber = EditingContact.PhoneNumber;
            }

            IsAddingOrEditing = false;
            EditingContact = null;
            OnPropertyChanged(nameof(IsReadonly));
            OnPropertyChanged(nameof(IsEnabled));
        }

        private void ExecuteSaveCommand(object parameter)
        {
            _serializer.SaveFile(Contacts);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>
        /// </summary>
        public MainVM ()
        {
            _serializer = new ContactSerializer ();
            Contacts = _serializer.LoadFile();

            AddCommand = new RelayCommand(
                execute: ExecuteAddCommand,
                canExecute: _ => true);

            EditCommand = new RelayCommand(
                execute: ExecuteEditCommand,
                canExecute: _ => SelectedContact != null && Contacts.Count > 0);

            RemoveCommand = new RelayCommand(
                execute: ExecuteRemoveCommand,
                canExecute: _ => SelectedContact != null && Contacts.Count > 0);

            ApplyCommand = new RelayCommand(
                execute: ExecuteApplyCommand,
                canExecute: _ => IsAddingOrEditing &&
                !string.IsNullOrEmpty(EditingContact.Name) &&
                !string.IsNullOrEmpty(EditingContact.PhoneNumber) &&
                !string.IsNullOrEmpty(EditingContact.Email));

            SaveCommand = new RelayCommand(
                execute: ExecuteSaveCommand,
                canExecute: _ => true);
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
