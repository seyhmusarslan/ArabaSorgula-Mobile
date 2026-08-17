/* [grial-metadata] id: Grial#NotificationPopup.xaml version: 2.0.6 */

using UXDivers.Popups.Maui;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class NotificationPopup : PopupPage
{
    public static readonly BindableProperty MessageProperty =
        BindableProperty.Create(
            nameof(Message),
            typeof(string),
            typeof(NotificationPopup),
            defaultValue: string.Empty);

    public string Message
    {
        get { return (string)GetValue(MessageProperty); }
        set { SetValue(MessageProperty, value); }
    }

    public NotificationPopup()
    {
        InitializeComponent();
    }

    private async void OnClose(object sender, EventArgs e)
    {
        await IPopupService.Current.PopAsync();
    }
}
