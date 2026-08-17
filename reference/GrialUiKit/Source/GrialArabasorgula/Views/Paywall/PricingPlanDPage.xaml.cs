/* [grial-metadata] id: Grial#PricingPlanDPage.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class PricingPlanDPage : ContentPage
{
	public PricingPlanDPage()
	{
		InitializeComponent();

        BindingContext = new PricingPlanDViewModel();
    }
}
