/* [grial-metadata] id: Grial#ChatMessagesListPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ChatMessagesListPage : ContentPage
    {
        public ChatMessagesListPage()
        {
            InitializeComponent();

            BindingContext = new ChatMessagesListViewModel();
        }
    }
}