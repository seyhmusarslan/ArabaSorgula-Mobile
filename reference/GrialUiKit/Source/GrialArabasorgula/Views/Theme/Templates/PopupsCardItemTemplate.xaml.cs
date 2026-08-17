/* [grial-metadata] id: Grial#PopupsCardItemTemplate.xaml version: 1.0.6 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXDivers.Grial;

namespace arabasorgula;

public partial class PopupsCardItemTemplate : ContentView
{
    public event EventHandler Tapped;

    public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title),
        typeof(string),
        typeof(PopupsCardItemTemplate),
        null);

    /// <summary>
    /// Gets or sets the title text displayed in the popup.
    /// </summary>
    public string Title
    {
        get { return (string)GetValue(TitleProperty); }
        set { SetValue(TitleProperty, value); }
    }

    public static readonly BindableProperty IsNewProperty = BindableProperty.Create(
        nameof(IsNew),
        typeof(bool),
        typeof(PopupsCardItemTemplate),
        false);

    /// <summary>
    /// Gets or sets the IsNew text displayed in the popup.
    /// </summary>
    public bool IsNew
    {
        get { return (bool)GetValue(IsNewProperty); }
        set { SetValue(IsNewProperty, value); }
    }

    public static readonly BindableProperty TextProperty = BindableProperty.Create(
        nameof(Text),
        typeof(string),
        typeof(PopupsCardItemTemplate),
        null);

    /// <summary>
    /// Gets or sets the Text text displayed in the popup.
    /// </summary>
    public string Text
    {
        get { return (string)GetValue(TextProperty); }
        set { SetValue(TextProperty, value); }
    }

    public PopupsCardItemTemplate()
    {
        InitializeComponent();
    }

    private void OnTapped(object sender, EventArgs e)
    {
        Tapped?.Invoke(this, e);
    }
}