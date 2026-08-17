/* [grial-metadata] id: Grial#ChatPreviewItemTemplate.xaml version: 1.0.6 */

using UXDivers.Popups.Services;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ChatPreviewItemTemplate : ContentView
    {
        public ChatPreviewItemTemplate()
        {
            InitializeComponent();
        }

        private async void OnAvatarTapped(object sender, EventArgs e)
        {
            var bindable = (BindableObject)sender;
            var popup = new ContactPreviewPopup(GetNavigation())
            {
                BindingContext = (bindable.BindingContext as FlowConversationData).From
            };

            await IPopupService.Current.PushAsync(popup);
        }

        private INavigation GetNavigation()
        {
            // If the item is rendered inside a CollectionView we need to get the navigation proxy
            // from the CollectionView itself for navigation methods to work
            if (Parent is Cell cell)
            {
                if (cell.Parent is CollectionView list)
                {
                    return list.Navigation;
                }
            }

            return Navigation;
        }
    }
}
