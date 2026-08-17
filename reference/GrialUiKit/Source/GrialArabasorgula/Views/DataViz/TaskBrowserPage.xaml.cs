/* [grial-metadata] id: Grial#TaskBrowserPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class TaskBrowserPage : ContentPage
    {
        public TaskBrowserPage()
        {
            InitializeComponent();

            BindingContext = new TaskBrowserViewModel();
        }
    }
}
