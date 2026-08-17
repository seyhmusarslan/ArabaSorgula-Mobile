/* [grial-metadata] id: Grial#NotificationConverter.cs version: 1.0.4 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public class NotificationConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var notificationType = (NotificationType)value;

            if (targetType == typeof(Color))
            {
                return GetColor(notificationType);
            }
            else if (targetType == typeof(string))
            {
                return GetIcon(notificationType);
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        private string GetIcon(NotificationType notificationType)
        {
            switch (notificationType)
            {
                case NotificationType.Confirmation:
                    return GrialIconsFont.Check;

                case NotificationType.Notification:
                    return GrialIconsFont.Bell;

                case NotificationType.Success:
                    return GrialIconsFont.Check;

                case NotificationType.Warning:
                    return GrialIconsFont.AlertTriangle;

                default: // Error
                    return GrialIconsFont.Close;
            }
        }

        private Color GetColor(NotificationType notificationType)
        {
            string resourceName;

            switch (notificationType)
            {
                case NotificationType.Confirmation:
                    resourceName = "SuccessColor";
                    break;

                case NotificationType.Notification:
                    resourceName = "InfoColor";
                    break;

                case NotificationType.Success:
                    resourceName = "SuccessColor";
                    break;

                case NotificationType.Warning:
                    resourceName = "WarningColor";
                    break;

                default: // Error
                    resourceName = "ErrorColor";
                    break;
            }

            return ResourceHelper.FindResource<Color>(resourceName);
        }
    }
}