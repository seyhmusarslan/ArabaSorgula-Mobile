/* [grial-metadata] id: Grial#StringToTimeConverter.cs version: 1.0.1 */
using System;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class StringToTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string time)
            {
                int hourTime;
                if (int.TryParse(time.Split(":")[0], out hourTime))
                {
                    return hourTime >= 12 ? time += " PM" : time += " AM";
                }

                return time;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

