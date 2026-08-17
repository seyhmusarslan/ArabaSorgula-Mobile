/* [grial-metadata] id: Grial#DataVizFilterTemplate.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
	public partial class DataVizFilterTemplate : ContentView
	{
        public static readonly BindableProperty OptionsProperty =
            BindableProperty.Create(
                nameof(Options),
                typeof(IEnumerable<string>),
                typeof(DataVizFilterTemplate),
                defaultValue: null);

        public IEnumerable<string> Options
        {
            get { return (IEnumerable<string>)GetValue(OptionsProperty); }
            set { SetValue(OptionsProperty, value); }
        }

        public static readonly BindableProperty SelectedOptionProperty =
            BindableProperty.Create(
                nameof(SelectedOption),
                typeof(string),
                typeof(DataVizFilterTemplate),
                defaultValue: null);

        public string SelectedOption
        {
            get { return (string)GetValue(SelectedOptionProperty); }
            set { SetValue(SelectedOptionProperty, value); }
        }

        public DataVizFilterTemplate()
		{
			InitializeComponent();
		}
	}
}