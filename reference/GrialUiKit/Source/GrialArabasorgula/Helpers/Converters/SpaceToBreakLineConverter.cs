/* [grial-metadata] id: Grial#SpaceToBreakLineConverter.cs version: 1.0.1 */
using System;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class SpaceToBreakLineConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string valueAsString)
            {
                return valueAsString.Replace(" ", "\n");
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}