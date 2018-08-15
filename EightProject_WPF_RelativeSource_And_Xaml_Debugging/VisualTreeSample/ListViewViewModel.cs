using System.Collections.ObjectModel;

namespace VisualTreeSample
{
    public class ListViewViewModel
    {
        public ObservableCollection<string> Names { get; set; }

        public ListViewViewModel()
        {
            Names = new ObservableCollection<string>()
            {
                "Joe",
                "Jane",
                "John",
                "Jessica",
                "Matt"
            };
        }
    }
}
