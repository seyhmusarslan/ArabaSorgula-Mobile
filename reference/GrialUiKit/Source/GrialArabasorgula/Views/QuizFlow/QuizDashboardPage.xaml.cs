/* [grial-metadata] id: Grial#QuizDashboardPage.xaml version: 2.0.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class QuizDashboardPage : ContentPage
{
	public QuizDashboardPage()
	{
		InitializeComponent();

        BindingContext = new QuizDashboardViewModel(Navigation, ScrollToItem);
    }

    private async void ScrollToItem(QuizCategoryData item)
    {
        await Dispatcher.DispatchAsync(() =>
        {
            collection.ScrollTo(item, position: ScrollToPosition.Start);
        });
    }
}