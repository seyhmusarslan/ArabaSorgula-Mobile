/* [grial-metadata] id: Grial#QuizResultsPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class QuizResultsPage : ContentPage
{
	public QuizResultsPage()
	{
		InitializeComponent();

        BindingContext = new QuizResultsViewModel(Navigation);
    }
}
