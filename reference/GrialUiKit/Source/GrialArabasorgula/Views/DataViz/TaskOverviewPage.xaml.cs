/* [grial-metadata] id: Grial#TaskOverviewPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class TaskOverviewPage : ContentPage
    {
        public TaskOverviewPage()
        {
            InitializeComponent();

            BindingContext = new TaskOverviewViewModel();
        }
    }
}
