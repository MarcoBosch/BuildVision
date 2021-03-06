using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AlekseyNagovitsyn.BuildVision.Tool.Views.Converters
{
    [ValueConversion(typeof(Visibility), typeof(bool))]
    public class VisibilityToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (new BooleanToVisibilityConverter()).ConvertBack(value, targetType, parameter, culture);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (new BooleanToVisibilityConverter()).Convert(value, targetType, parameter, culture);
        }
    }
}