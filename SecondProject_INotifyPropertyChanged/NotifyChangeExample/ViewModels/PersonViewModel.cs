using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotifyChangeExample.ViewModels
{
    public class PersonViewModel : ObservableObject
    {
        private string _name;

        public string Name
        {
            get
            {
                // we need to make sure that if _name is nothing
                // we return something, because it will be one way binding
                // and we would not like to break binding by
                // throwing an error.
                if(string.IsNullOrWhiteSpace(_name))
                {
                    return "Unknown";
                }
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }


        }
    }
}
