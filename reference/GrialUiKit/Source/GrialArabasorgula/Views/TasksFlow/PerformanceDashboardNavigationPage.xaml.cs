/* [grial-metadata] id: Grial#PerformanceDashboardNavigationPage.xaml version: 1.0.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class PerformanceDashboardNavigationPage
    {
        public PerformanceDashboardNavigationPage()
        {
        }

        public PerformanceDashboardNavigationPage(Page root)
            : base(root)
        {
            InitializeComponent();
        }

        private async void OnClose(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();

            if (RootPage?.BindingContext != null)
            {
                RootPage.BindingContext = null;
            }
        }
    }
}
