/* [grial-metadata] id: Grial#QuizCategoryItemTemplate.xaml version: 1.0.4 */
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula;

public partial class QuizCategoryItemTemplate : ContentView
{
    public static readonly BindableProperty OnItemTappedCommandProperty = BindableProperty.Create(
        nameof(OnItemTappedCommand),
        typeof(ICommand),
        typeof(QuizCategoryItemTemplate));

    public ICommand OnItemTappedCommand
    {
        get { return (ICommand)GetValue(OnItemTappedCommandProperty); }
        set { SetValue(OnItemTappedCommandProperty, value); }
    }

    public QuizCategoryItemTemplate()
	{
		InitializeComponent();
	}

    private async void OnItemTapped(object sender, EventArgs e)
    {
        var dialog = new QuizGamePage();

        await Navigation.PushModalAsync(dialog);
    }
}

