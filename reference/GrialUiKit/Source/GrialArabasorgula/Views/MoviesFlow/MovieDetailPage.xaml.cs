/* [grial-metadata] id: Grial#MovieDetailPage.xaml version: 1.1.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class MovieDetailPage : ContentPage
    {
        public MovieDetailPage()
            : this(null)
        {
        }

        public MovieDetailPage(FlowMovieData movie)
        {
            InitializeComponent();

            BindingContext = new MovieDetailViewModel(movie);
        }
        
        private void OnPlayClicked(object sender, EventArgs e)
        {
        }

        private void OnFullScreenClosed(object sender, EventArgs e)
        {
        }
    }
}