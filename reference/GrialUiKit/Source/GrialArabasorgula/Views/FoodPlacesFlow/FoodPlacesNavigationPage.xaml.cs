/* [grial-metadata] id: Grial#FoodPlacesNavigationPage.xaml version: 1.0.3 */
using System;
using System.Collections.Generic;
using UXDivers.Grial;

namespace arabasorgula
{ 
    public partial class FoodPlacesNavigationPage
    {
        public FoodPlacesNavigationPage()
        {
            InitializeComponent();
        }

        public FoodPlacesNavigationPage(Page root)
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
