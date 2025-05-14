using System.Collections.ObjectModel;
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
        private Contact _selectedContact;

        /// <summary>
        /// Редактируемый контакт
        /// </summary>
        private Contact _editingContact;

        /// <summary>
        /// Контактный сериализатор.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Возможность добавления или редактирования
        /// </summary>
        private bool _isAddingOrEditing;

        /// <summary>
        /// Команда для добавления контакта
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Команада для изменения контакта
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Команда для удаления контакта
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Команда, которая принимает изменения
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Команда сохранения файла
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Возвращает список контактов
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; }

        /// <summary>
        /// Задает и возвращает имя контакта.
        /// </summary>
        public string Name
        {
            get => IsAddingOrEditing ? EditingContact?.Name : SelectedContact?.Name; 
            set
            {
                if (IsAddingOrEditing)
                {
                    if (EditingContact != null && EditingContact.Name != value)
                    {
                        EditingContact.Name = value;
                        OnPropertyChanged(nameof(Name));
                        CommandManager.InvalidateRequerySuggested();
                    }
                }
                else if (SelectedContact != null && SelectedContact.Name != value)
                {
                    SelectedContact.Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        /// <summary>
        /// Задает и возвращает номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get => IsAddingOrEditing ? EditingContact?.PhoneNumber : SelectedContact?.PhoneNumber; 
            set
            {
                if (IsAddingOrEditing)
                {
                    if (EditingContact != null && EditingContact.PhoneNumber != value)
                    {
                        EditingContact.PhoneNumber = value;
                        OnPropertyChanged(nameof(PhoneNumber));
                        CommandManager.InvalidateRequerySuggested();
                    }
                }
                else if (SelectedContact != null && SelectedContact.PhoneNumber != value)
                {
                    SelectedContact.PhoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }

            }
        }

        /// <summary>
        /// Задает и возвращает электронную почту контакта.
        /// </summary>
        public string Email
        {
            get => IsAddingOrEditing ? EditingContact?.Email : SelectedContact?.Email;
            set
            {
                if (IsAddingOrEditing)
                {
                    if (EditingContact != null && EditingContact.Email != value)
                    {
                        EditingContact.Email = value;
                        OnPropertyChanged(nameof(Email));
                        CommandManager.InvalidateRequerySuggested();
                    }
                    else if (SelectedContact != null && SelectedContact.Email != value)
                    {
                        SelectedContact.Email = value;
                        OnPropertyChanged(nameof(Email));
                    }
                }

            }
        }

        /// <summary>
        /// Задает и возвращает выбранный контакт
        /// </summary>
        public Contact SelectedContact
        {
            get => _selectedContact; 
            set
            {
                if (_selectedContact != value)
                {
                    _selectedContact = value;
                    if (IsAddingOrEditing && value != null)
                    {
                        EditingContact = null;
                        IsAddingOrEditing = false;
                    }
                    OnPropertyChanged(nameof(Name));
                    OnPropertyChanged(nameof(PhoneNumber));
                    OnPropertyChanged(nameof(Email));
                    OnPropertyChanged(nameof(SelectedContact));
                    OnPropertyChanged(nameof(IsEnabled));
                    OnPropertyChanged(nameof(Visible));
                }
            }
        }

        /// <summary>
        /// Задает и возвращает редактируемый контакт
        /// </summary>
        public Contact EditingContact
        {
            get => _editingContact; 
            set
            {
                _editingContact = value;
                OnPropertyChanged(nameof(EditingContact));
                OnPropertyChanged(nameof(Name));
                OnPropertyChanged(nameof(Email));
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Возвращает свойство только для чтения
        /// </summary>
        public bool IsReadonly
        {
            get => !_isAddingOrEditing;
        }
        
        /// <summary>
        /// Возвращает свойство доступности
        /// </summary>
        public bool IsEnabled
        {
            get => _selectedContact != null && Contacts.Count > 0;
        }

        /// <summary>
        /// Возвращает свойство видимости
        /// </summary>
        public bool Visible
        {
            get => _isAddingOrEditing;
        }
        
        /// <summary>
        /// Возвращает и задает возможность добавления или редактирования
        /// </summary>
        public bool IsAddingOrEditing
        {
            get => _isAddingOrEditing;
            set
            {
                if (_isAddingOrEditing != value)
                {
                    _isAddingOrEditing = value;
                    OnPropertyChanged(nameof(IsReadonly));
                    OnPropertyChanged(nameof(IsEnabled));
                }
            }
        }

        /// <summary>
        /// Функция добавления нового контакта
        /// </summary>
        /// <param name="parameter"></param>
        private void ExecuteAddCommand(object parameter)
        {
            SelectedContact = null;
            EditingContact = new Contact();
            IsAddingOrEditing = true;
            OnPropertyChanged(nameof(IsReadonly));
            OnPropertyChanged(nameof(Visible));
        }

        /// <summary>
        /// Функция редактирования контакта
        /// </summary>
        /// <param name="parameter"></param>
        private void ExecuteEditCommand(object parameter)
        {
            IsAddingOrEditing = true;
            EditingContact = new Contact
            {
                Name = SelectedContact.Name,
                PhoneNumber = SelectedContact.PhoneNumber,
                Email = SelectedContact.Email,
            };
            OnPropertyChanged(nameof(IsReadonly));
            OnPropertyChanged(nameof(Visible));
        }

        /// <summary>
        /// Функция удаления контакта
        /// </summary>
        /// <param name="parameter"></param>
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
                        if (index >=  Contacts.Count)
                        {
                            index = Contacts.Count - 1;
                        }
                        SelectedContact = Contacts[index];
                    }
                }
                OnPropertyChanged(nameof(IsEnabled));
            }
        }

        /// <summary>
        /// Функция применения изменений
        /// </summary>
        /// <param name="parameter"></param>
        private void ExecuteApplyCommand(object parameter)
        {
            if (SelectedContact == null)
            {
                Contact contact = new Contact
                (
                    EditingContact.Name,
                    EditingContact.PhoneNumber,
                    EditingContact.Email                    
                );
                Contacts.Add(contact);
                SelectedContact = contact;
            }
            else
            {
                var updatedContact = new Contact
                {
                    Name = EditingContact.Name,
                    PhoneNumber = EditingContact.PhoneNumber,
                    Email = EditingContact.Email,
                };
                int index = Contacts.IndexOf(SelectedContact);
                Contacts[index] = updatedContact;
                SelectedContact = updatedContact;
            }
            IsAddingOrEditing = false;
            EditingContact = null;
            OnPropertyChanged(nameof(IsReadonly));
            OnPropertyChanged(nameof(Visible));
        }

        /// <summary>
        /// Функция сохранения данных в файл
        /// </summary>
        /// <param name="parameter"></param>
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
                canExecute: _ => SelectedContact != null && Contacts.Count > 0,
                useCommandManager: true);

            RemoveCommand = new RelayCommand(
                execute: ExecuteRemoveCommand,
                canExecute: _ => SelectedContact != null && Contacts.Count > 0,
                useCommandManager: true);

            ApplyCommand = new RelayCommand(
                execute: ExecuteApplyCommand,
                canExecute: _ => IsAddingOrEditing &&
                !string.IsNullOrEmpty(EditingContact.Name) &&
                !string.IsNullOrEmpty(EditingContact.PhoneNumber) &&
                !string.IsNullOrEmpty(EditingContact.Email),
                useCommandManager: true);

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
