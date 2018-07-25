using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SingularCommand.ViewModels.Commands
{
    public class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Action _execute;
        
        // We will instead use parameter of type Action that
        // is a delegate containing method with no parameter
        // in this case.
        public MessageCommand(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            // Fire the method coming via delegate.
            _execute.Invoke();
        }
    }
}
