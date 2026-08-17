/* [grial-metadata] id: Grial#QuizProfileAchievementsPage.xaml version: 2.0.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class QuizProfileAchievementsPage : ContentPage
{
	public QuizProfileAchievementsPage()
	{
		InitializeComponent();

        BindingContext = new QuizProfileAchievementsViewModel();
    }

    public QuizProfileAchievementsPage(QuizProfileAchievementsViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}
