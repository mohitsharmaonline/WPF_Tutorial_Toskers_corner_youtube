
using System;
using System.Windows;

namespace NonValueConverter
{
    public class MainViewModel: ObservableObject
    {
        private bool isVisible;
        public bool IsVisible
        {
            get
            {
                return isVisible;
            }
            set
            {
                isVisible = value;
                UpdateVisibility(value);
                OnPropertyChanged(nameof(IsVisible));
            }
        }

        private Visibility visibility;
        public Visibility Visibility
        {
            get
            {
                return visibility;
            }
            set
            {
                visibility = value;
                OnPropertyChanged(nameof(Visibility));
            }
        }

        public MainViewModel()
        {
            isVisible = true;
            Visibility = Visibility.Visible;
        }

        private void UpdateVisibility(bool isVisible)
        {
            if(isVisible)
            {
                Visibility = Visibility.Visible;
            }
            else
            {
                Visibility = Visibility.Hidden;
            }
        }
    }
}
