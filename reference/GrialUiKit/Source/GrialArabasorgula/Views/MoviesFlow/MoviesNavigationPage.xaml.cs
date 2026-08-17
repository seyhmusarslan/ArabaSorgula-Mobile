/* [grial-metadata] id: Grial#MoviesNavigationPage.xaml version: 1.0.3 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class MoviesNavigationPage
    {
        public MoviesNavigationPage()
        {
        }

        public MoviesNavigationPage(Page root)
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
