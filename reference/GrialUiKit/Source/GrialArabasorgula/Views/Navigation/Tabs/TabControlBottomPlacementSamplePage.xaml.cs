/* [grial-metadata] id: Grial#TabControlBottomPlacementSamplePage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class TabControlBottomPlacementSamplePage : ContentPage
    {
        public TabControlBottomPlacementSamplePage()
        {
            InitializeComponent();

            BindingContext = new
            {
                Timeline = new TimelineViewModel(),
                Chat = new ChatMessagesListViewModel()
            };
        }
    }
}