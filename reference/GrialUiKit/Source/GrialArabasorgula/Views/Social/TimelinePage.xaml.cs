/* [grial-metadata] id: Grial#TimelinePage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class TimelinePage : ContentPage
    {
        public TimelinePage()
        {
            InitializeComponent();

            BindingContext = new TimelineViewModel();
        }
    }
}