using System.Windows.Input;
using Services;
using Model;

namespace ViewModel
{
    /// <summary>
    /// Команда для выгрузки данных из файла.
    /// </summary>
    internal class LoadCommand : ICommand
    {
        /// <summary>
        /// Контактный сериализатор.
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Объект класса MainVM.
        /// </summary>
        private MainVM _mainVM;

        /// <summary>
        /// Создает экземпляр класса <see cref="LoadCommand"/>
        /// </summary>
        /// <param name="serializer">Сериализатор.</param>
        /// <param name="mainVM">Объект класса MainVM.</param>
        public LoadCommand(ContactSerializer serializer, MainVM mainVM)
        {
            _serializer = serializer;
            _mainVM = mainVM;
        }

        /// <summary>
        /// Событие о возможности изменения.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        /// <summary>
        /// Возвращает возможность выполнения команды.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <returns>Всегда возвращает true, потому что действие всегда возможно.</returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Загружает данные из файла в MainVM.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        /// <exception cref="Exception">Выдает ошибку, если не получилось выгрузить данные из файла.</exception>
        public void Execute(object parameter)
        {
            try
            {
                Contact contact = _serializer.LoadFile();
                _mainVM.Name = contact.Name;
                _mainVM.PhoneNumber = contact.PhoneNumber;
                _mainVM.Email = contact.Email;
            }
            catch (Exception ex)
            {
                throw new Exception("Data could not be load from file.");
            }
        }
    }
}
