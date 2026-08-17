/* [grial-metadata] id: Grial#DashboardVariantItemTemplate.xaml version: 1.0.1 */
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class DashboardVariantItemTemplate : ContentView
    {
        public static readonly BindableProperty CommandProperty =
            BindableProperty.Create(
                nameof(Command),
                typeof(ICommand),
                typeof(DashboardVariantItemTemplate),
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
                typeof(DashboardVariantItemTemplate),
                defaultValue: null);

        public object CommandParameter
        {
            get { return (object)GetValue(CommandParameterProperty); }
            set { SetValue(CommandParameterProperty, value); }
        }

        public static readonly BindableProperty ShowBackgroundImageProperty =
            BindableProperty.Create(
                nameof(ShowBackgroundImage),
                typeof(bool),
                typeof(DashboardVariantItemTemplate),
                true,
                defaultBindingMode: BindingMode.OneWay);

        public bool ShowBackgroundImage
        {
            get { return (bool)GetValue(ShowBackgroundImageProperty); }
            set { SetValue(ShowBackgroundImageProperty, value); }
        }

        public static readonly BindableProperty ShowBackgroundColorProperty =
            BindableProperty.Create(
                nameof(ShowBackgroundColor),
                typeof(bool),
                typeof(DashboardVariantItemTemplate),
                false,
                defaultBindingMode: BindingMode.OneWay);

        public bool ShowBackgroundColor
        {
            get { return (bool)GetValue(ShowBackgroundColorProperty); }
            set { SetValue(ShowBackgroundColorProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(
                nameof(TextColor),
                typeof(Color),
                typeof(DashboardVariantItemTemplate),
                defaultValue: Colors.White,
                defaultBindingMode: BindingMode.OneWay);

        public Color TextColor
        {
            get { return (Color)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public DashboardVariantItemTemplate()
        {
            InitializeComponent();
        }
    }
}