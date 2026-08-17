/* [grial-metadata] id: Grial#StringToColorConverter.cs version: 1.0.1 */
using System;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class StringToColorConverter : IValueConverter
    {
        public Color NullColor { get; set; }
        public Color OtherColor { get; set; }

        public string Value1 { get; set; }
        public Color Color1 { get; set; }
        public string Value2 { get; set; }
        public Color Color2 { get; set; }
        public string Value3 { get; set; }
        public Color Color3 { get; set; }
        public string Value4 { get; set; }
        public Color Color4 { get; set; }
        public string Value5 { get; set; }
        public Color Color5 { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return NullColor;
            }

            string val = string.Empty;

            if (value is int intr)
            {
                val = intr.ToString();
            }
            else if (value is string str)
            {
                val = str;
            }
            else if (value is Enum en)
            {
                val = en.ToString();
            }

            if (Value1 != null && string.Equals(val, Value1, StringComparison.InvariantCultureIgnoreCase))
            {
                return Color1;
            }

            if (Value2 != null && string.Equals(val, Value2, StringComparison.InvariantCultureIgnoreCase))
            {
                return Color2;
            }

            if (Value3 != null && string.Equals(val, Value3, StringComparison.InvariantCultureIgnoreCase))
            {
                return Color3;
            }

            if (Value4 != null && string.Equals(val, Value4, StringComparison.InvariantCultureIgnoreCase))
            {
                return Color4;
            }

            if (Value5 != null && string.Equals(val, Value5, StringComparison.InvariantCultureIgnoreCase))
            {
                return Color5;
            }

            return OtherColor;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}