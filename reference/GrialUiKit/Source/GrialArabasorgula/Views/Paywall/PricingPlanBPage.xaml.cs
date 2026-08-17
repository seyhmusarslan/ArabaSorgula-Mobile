/* [grial-metadata] id: Grial#PricingPlanBPage.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class PricingPlanBPage : ContentPage
{
	public PricingPlanBPage()
	{
		InitializeComponent();

        BindingContext = new PricingPlanBViewModel();
    }
}