using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace NotifyChangeExample.ViewModels
{
    public class MainViewModel
    {
        public PersonViewModel Person { get; private set; }

        public BackgroundViewModel Background { get; private set; }

        public MainViewModel()
        {
            Person = new PersonViewModel();
            Background = new BackgroundViewModel();
        }

        // Person binding will be one way to source.
        public void SetBackground(Brush brushColor)
        {
            Background.Color = brushColor;
        }
    }
}
