using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace View.ViewModel
{
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        private readonly bool _useCommandManager;

        public event EventHandler CanExecuteChanged
        {
            add 
            { 
                if (_useCommandManager)
                {
                    CommandManager.RequerySuggested += value;
                }
            }
            remove 
            {  
                if (_useCommandManager)
                {
                    CommandManager.RequerySuggested -= value;
                }
            }
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null, bool useCommandManager = false)
        {
            _execute = execute;
            _canExecute = canExecute;
            _useCommandManager = useCommandManager;
        }
        
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
