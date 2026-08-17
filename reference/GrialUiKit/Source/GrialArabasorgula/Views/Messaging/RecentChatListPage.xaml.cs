/* [grial-metadata] id: Grial#RecentChatListPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class RecentChatListPage : ContentPage
    {
        public RecentChatListPage()
        {
            InitializeComponent();

            BindingContext = new ChatMessagesListViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}
