/* [grial-metadata] id: Grial#SwitchConverter.cs version: 1.0.1 */
using System;
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class SwitchConverter : IValueConverter
    {
        public object Case1 { get; set; }
        public object Result1 { get; set; }
        public object Case2 { get; set; }
        public object Result2 { get; set; }
        public object Case3 { get; set; }
        public object Result3 { get; set; }
        public object Case4 { get; set; }
        public object Result4 { get; set; }
        public object Case5 { get; set; }
        public object Result5 { get; set; }
        public object Case6 { get; set; }
        public object Result6 { get; set; }
        public object Case7 { get; set; }
        public object Result7 { get; set; }

        public object NullResult { get; set; }
        public object DefaultResult { get; set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
            {
                return NullResult;
            }

            if (Case1 != null && (value.Equals(Case1) || value.ToString() == Case1.ToString()))
            {
                return Result1;
            }

            if (Case2 != null && (value.Equals(Case2) || value.ToString() == Case2.ToString()))
            {
                return Result2;
            }

            if (Case3 != null && (value.Equals(Case3) || value.ToString() == Case3.ToString()))
            {
                return Result3;
            }

            if (Case4 != null && (value.Equals(Case4) || value.ToString() == Case4.ToString()))
            {
                return Result4;
            }

            if (Case5 != null && (value.Equals(Case5) || value.ToString() == Case5.ToString()))
            {
                return Result5;
            }

            if (Case6 != null && (value.Equals(Case6) || value.ToString() == Case6.ToString()))
            {
                return Result6;
            }

            if (Case7 != null && (value.Equals(Case7) || value.ToString() == Case7.ToString()))
            {
                return Result7;
            }

            return DefaultResult;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}