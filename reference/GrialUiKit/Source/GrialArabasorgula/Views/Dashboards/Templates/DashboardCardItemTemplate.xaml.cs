/* [grial-metadata] id: Grial#DashboardCardItemTemplate.xaml version: 1.0.1 */
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class DashboardCardItemTemplate : ContentView
    {
        public static readonly BindableProperty CommandProperty =
           BindableProperty.Create(
               nameof(Command),
               typeof(ICommand),
               typeof(DashboardCardItemTemplate),
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
                typeof(DashboardCardItemTemplate),
                defaultValue: null);

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public DashboardCardItemTemplate()
        {
            InitializeComponent();
        }
    }
}