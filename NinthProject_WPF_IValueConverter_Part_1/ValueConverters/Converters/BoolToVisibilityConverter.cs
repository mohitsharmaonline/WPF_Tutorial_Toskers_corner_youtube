
using System;
using System.Globalization;
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
            throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
