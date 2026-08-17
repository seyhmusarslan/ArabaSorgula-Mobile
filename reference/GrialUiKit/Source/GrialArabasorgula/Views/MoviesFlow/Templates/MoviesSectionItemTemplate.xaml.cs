/* [grial-metadata] id: Grial#MoviesSectionItemTemplate.xaml version: 1.0.1 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class MoviesSectionItemTemplate : ContentView
    {
        public MoviesSectionItemTemplate()
        {
            InitializeComponent();
        }
        
        private async void OnTapGestureRecognizerTapped(object sender, EventArgs args) 
        {
            var movieDetailPage = new MovieDetailPage(((VisualElement)sender).BindingContext as FlowMovieData);

            await Navigation.PushAsync(movieDetailPage);
        }
    }
}
