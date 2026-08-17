/* [grial-metadata] id: Grial#ClipboardLinkPopup.xaml version: 1.0.6 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UXDivers.Popups.Maui;
using UXDivers.Popups.Services;
using UXDivers.Grial;


namespace arabasorgula;

public partial class ClipboardLinkPopup : PopupResultPage<bool>
{
    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title),
        typeof(string),
        typeof(ClipboardLinkPopup),
        null);

    /// <summary>
    /// Gets or sets the title text displayed in the popup.
    /// </summary>
    public string Title
    {
        get { return (string)GetValue(TitleProperty); }
        set { SetValue(TitleProperty, value); }
    }

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text),
        typeof(string),
        typeof(ClipboardLinkPopup),
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
        typeof(ClipboardLinkPopup),
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
        typeof(ClipboardLinkPopup),
        null);

    /// <summary>
    /// Gets or sets the text displayed on the primary action button.
    /// </summary>
    public string ActionButtonText
    {
        get { return (string)GetValue(ActionButtonTextProperty); }
        set { SetValue(ActionButtonTextProperty, value); }
    }

    public static readonly BindableProperty SecondaryActionButtonCommandProperty = BindableProperty.Create(
        nameof(SecondaryActionButtonCommand),
        typeof(ICommand),
        typeof(ClipboardLinkPopup),
        defaultValue: new Command(async () => await IPopupService.Current.PopAsync()));

    /// <summary>
    /// Gets or sets the command executed when the secondary action button is clicked. Defaults to PopAsync.
    /// </summary>
    public ICommand SecondaryActionButtonCommand
    {
        get { return (ICommand)GetValue(SecondaryActionButtonCommandProperty); }
        set { SetValue(SecondaryActionButtonCommandProperty, value); }
    }

    public static readonly BindableProperty SecondaryActionButtonTextProperty = BindableProperty.Create(
        nameof(SecondaryActionButtonText),
        typeof(string),
        typeof(ClipboardLinkPopup),
        null);

    /// <summary>
    /// Gets or sets the text displayed on the secondary action button.
    /// </summary>
    public string SecondaryActionButtonText
    {
        get { return (string)GetValue(SecondaryActionButtonTextProperty); }
        set { SetValue(SecondaryActionButtonTextProperty, value); }
    }

    public static readonly BindableProperty ClipboardLinkPlaceholderProperty = BindableProperty.Create(
        nameof(ClipboardLinkPlaceholder),
        typeof(string),
        typeof(ClipboardLinkPopup),
        null);

    /// <summary>
    /// Gets or sets the text displayed on the secondary action button.
    /// </summary>
    public string ClipboardLinkPlaceholder
    {
        get { return (string)GetValue(ClipboardLinkPlaceholderProperty); }
        set { SetValue(ClipboardLinkPlaceholderProperty, value); }
    }

    public static readonly BindableProperty ClipboardLinkTextProperty = BindableProperty.Create(
        nameof(ClipboardLinkText),
        typeof(string),
        typeof(ClipboardLinkPopup),
        null);

    /// <summary>
    /// Gets or sets the text displayed on the secondary action button.
    /// </summary>
    public string ClipboardLinkText
    {
        get { return (string)GetValue(ClipboardLinkTextProperty); }
        set { SetValue(ClipboardLinkTextProperty, value); }
    }

    public ClipboardLinkPopup()
    {
        InitializeComponent();
    }    
}