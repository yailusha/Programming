using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using Services;

namespace ViewModel
{
    /// <summary>
    /// Хранит данные о MainVM.
    /// </summary>
    public partial class MainVM : ObservableObject
    {
        /// <summary>
        /// Контактные данные человека.
        /// </summary>
        [ObservableProperty]
        private Contact _selectedContact;

        /// <summary>
        /// Редактируемый контакт
        /// </summary>
        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        private Contact _editingContact;

        /// <summary>
        /// Контактный сериализатор.
        /// </summary>
        private readonly ContactSerializer _serializer;

        /// <summary>
        /// Возможность добавления или редактирования
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsReadonly))]
        [NotifyPropertyChangedFor(nameof(IsEnabled))]
        [NotifyPropertyChangedFor(nameof(Visible))]
        [NotifyCanExecuteChangedFor(nameof(ApplyCommand))]
        private bool _isAddingOrEditing;

        /// <summary>
        /// Возвращает список контактов
        /// </summary>
        public ObservableCollection<Contact> Contacts { get; }

        /// <summary>
        /// Задает и возвращает выбранный контакт
        /// </summary>
        partial void OnSelectedContactChanged(Contact value)
        {
            if (value != null)
            {
                if (IsAddingOrEditing)
                {
                    IsAddingOrEditing = false;
                }
                EditingContact.Name = value.Name;
                EditingContact.PhoneNumber = value.PhoneNumber;
                EditingContact.Email = value.Email;
            }

            OnPropertyChanged(nameof(IsEnabled));
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();    
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

        private bool CanEditOrRemove() => SelectedContact != null;

        private bool CanApply() =>
            IsAddingOrEditing &&
            !string.IsNullOrWhiteSpace(EditingContact.Name) &&
            !string.IsNullOrWhiteSpace(EditingContact.PhoneNumber) &&
            !string.IsNullOrWhiteSpace(EditingContact.Email) &&
            string.IsNullOrEmpty(EditingContact[nameof(Contact.Name)]) &&
            string.IsNullOrEmpty(EditingContact[nameof(Contact.PhoneNumber)]) &&
            string.IsNullOrEmpty(EditingContact[nameof(Contact.Email)]);


        private void EditingContact_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            ApplyCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Функция добавления нового контакта
        /// </summary>
        [RelayCommand]
        private void Add()
        {
            SelectedContact = null;
            if (EditingContact != null)
            {
                EditingContact.PropertyChanged -= EditingContact_PropertyChanged;
            }
            EditingContact = new Contact();
            IsAddingOrEditing = true;
            EditingContact.PropertyChanged += EditingContact_PropertyChanged;
        }

        /// <summary>
        /// Функция редактирования контакта
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanEditOrRemove))]
        private void Edit()
        {
            IsAddingOrEditing = true;
        }

        /// <summary>
        /// Функция удаления контакта
        /// </summary>
        [RelayCommand(CanExecute = nameof(CanEditOrRemove))]
        private void Remove()
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
                        if (index >= Contacts.Count)
                        {
                            index = Contacts.Count - 1;
                        }
                        SelectedContact = Contacts[index];
                    }
                }
            }
            OnPropertyChanged(nameof(IsEnabled));
            EditCommand.NotifyCanExecuteChanged();
            RemoveCommand.NotifyCanExecuteChanged();
        }

        /// <summary>
        /// Функция применения изменений
        /// </summary>
        /// <param name="parameter"></param>
        [RelayCommand(CanExecute = nameof(CanApply))]
        private void Apply()
        {
            if (SelectedContact == null)
            {
                Contact contact = new Contact(EditingContact);
                Contacts.Add(contact);
                SelectedContact = contact;
            }
            else
            {
                SelectedContact.Name = EditingContact.Name;
                SelectedContact.PhoneNumber = EditingContact.PhoneNumber;
                SelectedContact.Email = EditingContact.Email;
            }
            IsAddingOrEditing = false;
        }

        /// <summary>
        /// Функция сохранения данных в файл
        /// </summary>
        [RelayCommand]
        private void Save()
        {
            _serializer.SaveFile(Contacts);
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>
        /// </summary>
        public MainVM()
        {
            _serializer = new ContactSerializer();
            _editingContact = new Contact();
            Contacts = _serializer.LoadFile();
            if (_editingContact != null)
            {
                EditingContact.PropertyChanged += EditingContact_PropertyChanged;
            }
        }
    }
}