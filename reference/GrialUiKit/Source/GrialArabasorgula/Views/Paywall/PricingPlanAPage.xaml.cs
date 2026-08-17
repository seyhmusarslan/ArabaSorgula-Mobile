/* [grial-metadata] id: Grial#PricingPlanAPage.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class PricingPlanAPage : ContentPage
{
	public PricingPlanAPage()
	{
		InitializeComponent();

        BindingContext = new PricingPlanAViewModel();
    }
}
