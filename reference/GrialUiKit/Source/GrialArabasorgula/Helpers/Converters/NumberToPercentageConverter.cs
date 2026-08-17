/* [grial-metadata] id: Grial#NumberToPercentageConverter.cs version: 1.0.1 */
using System;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class NumberToPercentageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is double num)
            {
                return Math.Floor(num * 100);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

