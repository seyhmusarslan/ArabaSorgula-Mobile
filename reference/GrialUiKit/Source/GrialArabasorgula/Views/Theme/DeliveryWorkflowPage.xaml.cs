/* [grial-metadata] id: Grial#DeliveryWorkflowPage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class DeliveryWorkflowPage : ContentPage
{
	public DeliveryWorkflowPage()
	{
		InitializeComponent();

        BindingContext = new DeliveryWorkflowViewModel(Navigation);
    }
}
