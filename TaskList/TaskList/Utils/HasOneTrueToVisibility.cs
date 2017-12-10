using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace TaskList.Utils {
    public class HasOneTrueToVisibility : IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            foreach (var value in values) {
                if (!(value is bool val))
                    return Visibility.Collapsed;
                if (val)
                    return Visibility.Visible;
            }
            return Visibility.Collapsed;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
    public class HasOneFalseToVisibility : IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            foreach (var value in values) {
                if (!(value is bool val))
                    return Visibility.Collapsed;
                if (val)
                    return Visibility.Collapsed;
            }
            return Visibility.Visible;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}