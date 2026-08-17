/* [grial-metadata] id: Grial#SingleEntryFormPopup.xaml version: 1.0.6 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Popups.Maui;
using UXDivers.Popups.Maui.Controls;
using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula;

public partial class SingleEntryFormPopup : PopupResultPage<string>
{
    public BindableProperty PlaceholderProperty =
        BindableProperty.Create(
            nameof(Placeholder),
            typeof(string),
            typeof(SingleEntryFormPopup),
            string.Empty);

    public string Placeholder
    {
        get => (string)GetValue(PlaceholderProperty);
        set => SetValue(PlaceholderProperty, value);
    }

    public BindableProperty ActionButtonTextProperty =
        BindableProperty.Create(
            nameof(ActionButtonText),
            typeof(string),
            typeof(SingleEntryFormPopup),
            string.Empty);

    public string ActionButtonText
    {
        get => (string)GetValue(ActionButtonTextProperty);
        set => SetValue(ActionButtonTextProperty, value);
    }

    public BindableProperty TitleProperty =
        BindableProperty.Create(
            nameof(Title),
            typeof(string),
            typeof(SingleEntryFormPopup),
            string.Empty);

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public BindableProperty TextProperty =
        BindableProperty.Create(
            nameof(Text),
            typeof(string),
            typeof(SingleEntryFormPopup),
            string.Empty);

    public string Text
    {
        get => (string)GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    
    public SingleEntryFormPopup()
    {
        InitializeComponent();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        SetResult(entry.Text);

        IPopupService.Current.PopAsync(this);
    }
}