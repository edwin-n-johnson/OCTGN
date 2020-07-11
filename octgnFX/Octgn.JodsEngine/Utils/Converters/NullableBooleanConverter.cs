﻿using System;
using System.Windows.Data;

namespace Octgn.Utils.Converters
{
    [ValueConversion(typeof(bool), typeof(bool?))]
    public class NullableBooleanConverter
    {
        #region IValueConverter Members

        public object Convert(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(bool?))
                throw new InvalidOperationException("The target must be a nullable boolean");

            return (bool?)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter,
            System.Globalization.CultureInfo culture)
        {
            if (targetType != typeof(bool))
                throw new InvalidOperationException("The target must be a boolean");
            return value ?? false;
        }

        #endregion
    }
}