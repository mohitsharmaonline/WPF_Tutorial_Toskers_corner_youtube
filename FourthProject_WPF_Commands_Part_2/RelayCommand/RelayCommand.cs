using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RelayCommand
{
    // we are going to add an Action here as before and also something known as the predicate.
    public class RelayCommandClass : ICommand
    {
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        public RelayCommandClass(Action<object> execute, Predicate<object> canExecute)
        {
            _execute = execute ?? throw new NullReferenceException(nameof(execute));
            _canExecute = canExecute;
        }

        // In some cases we might not need to supply predicate.
        // for those cases we will have another constructor.
        public RelayCommandClass(Action<object> execute) : this(execute, null)
        {
        }

        // Basically what CommandManager.RequeryManager is basically doing for us is
        // it's going to automatically on it's own pick up on changes that could affect
        // the outcome of our can execute so things such as when we bind our command to a 
        // control if the control has lost focus it will throw an event to CanExecute, whether or not
        // it's actualy changed doesn't matter. so it's kind of inefficient in that way, but
        // it will keep throwing if a possible change comes up and if it changes
        // obviously it'll set the new can execute willing value.
        // But one thing i have heard but never experienced is that you can have trouble
        // using the command manager require suggested using the asynchronous operations
        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object parameter)
        {
            // as discussed before in certain cases we might not have
            // the predicate.
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter);
        }
    }
}
