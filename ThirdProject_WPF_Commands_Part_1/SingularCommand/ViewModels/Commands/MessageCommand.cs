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

        // Here we can use MessageViewModel as a parameter 
        // and can use it to display message. However
        // this kind of paramenter will tie the command to a 
        // particular View Manager. so we would rater avoid
        // this kind of parameter.
        public MessageCommand(MessageViewModel vm)
        {
            vm.DisplayMessage();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
