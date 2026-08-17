/* [grial-metadata] id: Grial#SurveyListPage.xaml version: 1.0.5 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class SurveyListPage : ContentPage
{
	public SurveyListPage()
    {
        InitializeComponent();

        BindingContext = new SurveyListViewModel();
    }
}
