
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ValueConverters.Converters
{
    public class BoolToVisibilityConverter : IValueConverter
    {
        /********************************************************************************
         * At beginner level we will first care about parameter of type object which
         * we shall be passing. this 'value' contains the value we are interested in 
         * conversion.
         * ****************************************************************************/
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // If you want to do Collapse etc. you can modify the code
            // for now it fullfills the purpose.s
            var booleanVal = (bool)value;
            if (booleanVal)
            {
                return Visibility.Visible;
            }
            else
            {
                return Visibility.Hidden;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
