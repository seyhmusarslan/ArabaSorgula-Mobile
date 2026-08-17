/* [grial-metadata] id: Grial#SmartHomeScheduleCardTemplate.xaml version: 1.0.1 */
using System.Runtime.CompilerServices;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula;

public partial class SmartHomeScheduleCardTemplate : ContentView
{
    public static readonly BindableProperty EditScheduleCommandProperty = BindableProperty.Create(
        nameof(EditScheduleCommand),
        typeof(ICommand),
        typeof(SmartHomeScheduleCardTemplate),
        null);

    public ICommand EditScheduleCommand
    {
        get { return (ICommand)GetValue(EditScheduleCommandProperty); }
        set { SetValue(EditScheduleCommandProperty, value); }
    }

    public static readonly BindableProperty DeleteScheduleCommandProperty = BindableProperty.Create(
        nameof(DeleteScheduleCommand),
        typeof(ICommand),
        typeof(SmartHomeScheduleCardTemplate),
        null);

    public ICommand DeleteScheduleCommand
    {
        get { return (ICommand)GetValue(DeleteScheduleCommandProperty); }
        set { SetValue(DeleteScheduleCommandProperty, value); }
    }

    public static readonly BindableProperty SecondaryContentProperty = BindableProperty.Create(
        nameof(SecondaryContent),
        typeof(View),
        typeof(SmartHomeScheduleCardTemplate),
        null);

    public View SecondaryContent
    {
        get { return (View)GetValue(SecondaryContentProperty); }
        set { SetValue(SecondaryContentProperty, value); }
    }

    public SmartHomeScheduleCardTemplate()
	{
		InitializeComponent();
	}
}
