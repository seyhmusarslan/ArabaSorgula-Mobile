/* [grial-metadata] id: Grial#OptionsListPopup.xaml version: 1.0.6 */
using System.Windows.Input;
using UXDivers.Popups.Maui;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class OptionsListPopup : PopupResultPage<object>
{
        public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title),
        typeof(string),
        typeof(OptionsListPopup),
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
        typeof(OptionsListPopup),
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
        typeof(OptionsListPopup),
        null);

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
        typeof(OptionsListPopup),
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
        typeof(OptionsListPopup),
        null);

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
        typeof(OptionsListPopup),
        null);

    /// <summary>
    /// Gets or sets the text displayed on the secondary action button.
    /// </summary>
    public string SecondaryActionButtonText
    {
        get { return (string)GetValue(SecondaryActionButtonTextProperty); }
        set { SetValue(SecondaryActionButtonTextProperty, value); }
    }

    public static readonly BindableProperty SelectedItemProperty = BindableProperty.Create(
        nameof(SelectedItem),
        typeof(object),
        typeof(OptionsListPopup),
        null);

    /// <summary>
    /// Gets or sets the text displayed on the secondary action button.
    /// </summary>
    public object SelectedItem
    {
        get { return (object)GetValue(SelectedItemProperty); }
        set { SetValue(SelectedItemProperty, value); }
    }

    public static readonly BindableProperty ItemsProperty = BindableProperty.Create(
        nameof(Items),
        typeof(IEnumerable<object>),
        typeof(OptionsListPopup),
        null);

    /// <summary>
    /// Gets or sets the text displayed on the secondary action button.
    /// </summary>
    public IEnumerable<object> Items
    {
        get { return (IEnumerable<object>)GetValue(ItemsProperty); }
        set { SetValue(ItemsProperty, value); }
    }

    public OptionsListPopup()
    {
        InitializeComponent();

        if (ActionButtonCommand == null)
        {
            ActionButtonCommand = new Command(async () => await OnPrimaryActionButtonClicked());
        }

        if (SecondaryActionButtonCommand == null)
        {
            SecondaryActionButtonCommand = new Command(async () => await OnSecondaryActionButtonClicked());
        }
    }

    private Task OnPrimaryActionButtonClicked()
    {
        SetResult(SelectedItem);
        
        return IPopupService.Current.PopAsync(this);
    }

    private Task OnSecondaryActionButtonClicked()
    {
        SetResult(null);
        
        return IPopupService.Current.PopAsync(this);
    }
}