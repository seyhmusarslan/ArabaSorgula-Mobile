/* [grial-metadata] id: Grial#DashboardAppNotificationItemTemplate.xaml version: 1.0.1 */
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class DashboardAppNotificationItemTemplate : ContentView
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(
                nameof(Command),
                typeof(ICommand),
                typeof(DashboardAppNotificationItemTemplate),
                defaultValue: null);

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly BindableProperty CommandParameterProperty =
        BindableProperty.Create(
            nameof(CommandParameter),
            typeof(object),
            typeof(DashboardAppNotificationItemTemplate),
            defaultValue: null);

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(
                nameof(TextColor),
                typeof(Color),
                typeof(DashboardAppNotificationItemTemplate),
                defaultValue: Colors.White,
                defaultBindingMode: BindingMode.OneWay);

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public DashboardAppNotificationItemTemplate()
        {
            InitializeComponent();
        }
    }
}