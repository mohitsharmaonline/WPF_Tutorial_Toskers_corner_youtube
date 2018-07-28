using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RelayCommand.ViewModels
{
    public class MessageViewModel
    {
        // ObservableCollection is a WPF specific generic collection type.
        public ObservableCollection<string> MyMessages { get; private set; }

        // our two relay commands
        public RelayCommand MessageBoxCommand { get; private set; }
        public RelayCommand ConsoleLogCommand { get; private set; }

        public MessageViewModel()
        {
            MyMessages = new ObservableCollection<string>()
            {
                // creating our predetermined messages.
                "Hello world!",
                "My name is Jill",
                "I love learning commands!",
                // special messages
                "Im a message box!",
                "Im a console!"
            };

            MessageBoxCommand = new RelayCommand(DisplayMessageBox, MessageBoxCanUse);
            ConsoleLogCommand = new RelayCommand(DisplayInConsole, ConsoleCanUse);
        }

        // Some methods that our commands will encapsulate.
        public void DisplayMessageBox(object message)
        {
            MessageBox.Show((string)message);
        }


        public void DisplayInConsole(object message)
        {
            Console.WriteLine((string)message);
        }

        // for Predicate

        public bool MessageBoxCanUse(object message)
        {
            if((string)message == "Im a console!")
            {
                return false;
            }
            return true;
        }

        public bool ConsoleCanUse(object message)
        {
            if ((string)message == "Im a message box!")
            {
                return false;
            }
            return true;
        }

    }
}
