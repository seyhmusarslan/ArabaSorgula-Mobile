/* [grial-metadata] id: Grial#TabControliOSSamplePage.xaml version: 1.1.6 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class TabControliOSSamplePage : ContentPage
    {
        public TabControliOSSamplePage()
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