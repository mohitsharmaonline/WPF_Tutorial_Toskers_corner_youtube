using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SingularCommand.ViewModels
{
    public class MessageViewModel
    {
        public string MessageText { get; set; }

        public MessageViewModel()
        {

        }

        public void DisplayMessage()
        {
            MessageBox.Show(MessageText);
        }
    }
}
