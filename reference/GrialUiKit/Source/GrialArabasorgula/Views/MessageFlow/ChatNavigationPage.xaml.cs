/* [grial-metadata] id: Grial#ChatNavigationPage.xaml version: 1.0.3 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ChatNavigationPage
    {
        public ChatNavigationPage()
        {
        }

        public ChatNavigationPage(Page root)
            : base(root)
        {
            InitializeComponent();
        }

        private async void OnClose(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
