/* [grial-metadata] id: Grial#TabControlCustomSamplePage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class TabControlCustomSamplePage : ContentPage
    {
        public TabControlCustomSamplePage()
        {
            InitializeComponent();

            BindingContext = new
            {
                Timeline = new TimelineViewModel(),
                Social = new SocialViewModel(),
                Chat = new ChatMessagesListViewModel()
            };
        }
    }
}