/* [grial-metadata] id: Grial#QuizGamePage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class QuizGamePage : ContentPage
{
	public QuizGamePage()
	{
		InitializeComponent();

        BindingContext = new QuizGameViewModel(Navigation);
    }
}