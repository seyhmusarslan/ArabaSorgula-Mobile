/* [grial-metadata] id: Grial#TabControlAndroidSamplePage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class TabControlAndroidSamplePage : ContentPage
    {
        public TabControlAndroidSamplePage()
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