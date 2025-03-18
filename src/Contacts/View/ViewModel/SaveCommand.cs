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
    internal class SaveCommand : ICommand
    {
        private ContactSerializer _serializer;
        private Contact _contact;

        public SaveCommand(ContactSerializer serializer, Contact contact)
        {
            _serializer = serializer;
            _contact = contact;
        }
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            _serializer.SaveFile(_contact);
        }
    }
}

