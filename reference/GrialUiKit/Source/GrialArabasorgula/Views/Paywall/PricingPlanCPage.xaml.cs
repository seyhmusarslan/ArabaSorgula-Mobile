/* [grial-metadata] id: Grial#PricingPlanCPage.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class PricingPlanCPage : ContentPage
{
	public PricingPlanCPage()
	{
		InitializeComponent();

        BindingContext = new PricingPlanCViewModel();
    }
}