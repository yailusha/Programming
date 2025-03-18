using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model.Services;
using View.Model;
using System.Net.Http.Headers;

namespace View.ViewModel
{
    internal class LoadCommand : ICommand
    {
        private ContactSerializer _serializer;
        private MainVM _mainVM;

        public LoadCommand(ContactSerializer serializer, MainVM mainVM)
        {
            _serializer = serializer;
            _mainVM = mainVM;
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
