/* [grial-metadata] id: Grial#ChatTimelinePage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ChatTimelinePage : ContentPage
    {
        public ChatTimelinePage()
        {
            InitializeComponent();

            BindingContext = new ChatMessagesListViewModel(variantPageName: $"{GetType().Name}.xaml");
        }
    }
}
