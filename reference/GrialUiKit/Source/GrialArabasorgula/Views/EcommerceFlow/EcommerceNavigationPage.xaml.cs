/* [grial-metadata] id: Grial#EcommerceNavigationPage.xaml version: 1.0.3 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class EcommerceNavigationPage
    {
        public EcommerceNavigationPage()
        {
        }

        public EcommerceNavigationPage(Page root)
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
