/* [grial-metadata] id: Grial#InteractiveNotificationPopup.xaml version: 1.0.6 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UXDivers.Popups.Maui;
using UXDivers.Popups.Maui.Controls;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class InteractiveNotificationPopup : PopupPage
{
    public static readonly BindableProperty IconTextProperty = BindableProperty.Create(
        nameof(IconText),
        typeof(string),
        typeof(InteractiveNotificationPopup),
        null);

    /// <summary>
    /// Gets or sets the main IconText content displayed in the popup.
    /// </summary>
    public string IconText
    {
        get { return (string)GetValue(IconTextProperty); }
        set { SetValue(IconTextProperty, value); }
    }

    public static readonly BindableProperty IconColorProperty = BindableProperty.Create(
        nameof(IconColor),
        typeof(Color),
        typeof(InteractiveNotificationPopup),
        null);

    /// <summary>
    /// Gets or sets the main IconColor content displayed in the popup.
    /// </summary>
    public Color IconColor
    {
        get { return (Color)GetValue(IconColorProperty); }
        set { SetValue(IconColorProperty, value); }
    }

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text),
        typeof(string),
        typeof(InteractiveNotificationPopup),
        null);

    /// <summary>
    /// Gets or sets the main text content displayed in the popup.
    /// </summary>
    public string Text
    {
        get { return (string)GetValue(TextProperty); }
        set { SetValue(TextProperty, value); }
    }

     public static readonly BindableProperty ActionButtonCommandProperty = BindableProperty.Create(
        nameof(ActionButtonCommand),
        typeof(ICommand),
        typeof(InteractiveNotificationPopup),
        defaultValue: new Command(async () => await IPopupService.Current.PopAsync()));

    /// <summary>
    /// Gets or sets the command executed when the primary action button is clicked. Defaults to PopAsync.
    /// </summary>
    public ICommand ActionButtonCommand
    {
        get { return (ICommand)GetValue(ActionButtonCommandProperty); }
        set { SetValue(ActionButtonCommandProperty, value); }
    }

    public static readonly BindableProperty ActionButtonTextProperty = BindableProperty.Create(
        nameof(ActionButtonText),
        typeof(string),
        typeof(InteractiveNotificationPopup),
        null);

    /// <summary>
    /// Gets or sets the text displayed on the primary action button.
    /// </summary>
    public string ActionButtonText
    {
        get { return (string)GetValue(ActionButtonTextProperty); }
        set { SetValue(ActionButtonTextProperty, value); }
    }

    public InteractiveNotificationPopup()
    {
        InitializeComponent();
    }
}