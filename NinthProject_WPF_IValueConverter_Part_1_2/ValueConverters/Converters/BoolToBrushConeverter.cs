﻿using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ValueConverters.Converters
{
    public class BoolToBrushConeverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var isOnline = (bool)value;
            if(isOnline)
            {
                return Brushes.Green;
            }
            else
            {
                return Brushes.Red;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
