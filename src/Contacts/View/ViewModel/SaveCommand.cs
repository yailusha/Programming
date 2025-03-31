using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    /// <summary>
    /// Команда для сохранения данных в файл.
    /// </summary>
    internal class SaveCommand : ICommand
    {
        /// <summary>
        /// Контактный сериализатор.
        /// </summary>
        private ContactSerializer _serializer;

        /// <summary>
        /// Контактные данные человека.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Создает экземпляр класса <see cref="SaveCommand"/>
        /// </summary>
        /// <param name="serializer">Контактный сериализатор.</param>
        /// <param name="contact">Контактные данные человека.</param>
        public SaveCommand(ContactSerializer serializer, Contact contact)
        {
            _serializer = serializer;
            _contact = contact;
        }

        /// <summary>
        /// Событие о возможности изменения.
        /// </summary>
        public event EventHandler CanExecuteChanged;

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
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="parameter">Параметр.</param>
        public void Execute(object parameter)
        {
            _serializer.SaveFile(_contact);
        }
    }
}

