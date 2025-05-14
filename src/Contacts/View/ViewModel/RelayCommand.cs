using System.Windows.Input;

namespace ViewModel
{
    /// <summary>
    /// Универсальная команда для выполнения и проверки возможности выполнения
    /// </summary>
    public class RelayCommand : ICommand
    {
        private Action<object> _execute;
        private Func<object, bool> _canExecute;
        private readonly bool _useCommandManager;

        /// <summary>
        /// Событие, которое вызывается при изменении возможности выполнения
        /// </summary>
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

        /// <summary>
        /// Создает новую команду
        /// </summary>
        /// <param name="execute">Команда</param>
        /// <param name="canExecute">Функция проверки возможности выполнения команды</param>
        /// <param name="useCommandManager">Функция для перепроверки canExecute</param>
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null, bool useCommandManager = false)
        {
            _execute = execute;
            _canExecute = canExecute;
            _useCommandManager = useCommandManager;
        }
        
        /// <summary>
        /// Проверяет возможность выполнения команды
        /// </summary>
        /// <param name="parameter"></param>
        /// <returns></returns>
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        /// <summary>
        /// Выполняем команду
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _execute(parameter);
        }
    }
}
