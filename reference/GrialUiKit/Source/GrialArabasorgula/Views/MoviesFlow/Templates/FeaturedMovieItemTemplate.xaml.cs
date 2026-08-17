/* [grial-metadata] id: Grial#FeaturedMovieItemTemplate.xaml version: 1.0.1 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class FeaturedMovieItemTemplate : ContentView
    {
        public FeaturedMovieItemTemplate()
        {
            InitializeComponent();

            var displayService = Application.Current.Handler.MauiContext.Services.GetService<IDisplayInformationService>();

            grid.RowDefinitions.Add(new RowDefinition { Height = displayService.ActualScreenHeight });
            grid.RowDefinitions.Add(new RowDefinition { Height = displayService.ActualScreenHeight });
        }

        private void OnPlayClicked(object sender, EventArgs e)
        {
        }

        private void OnFullScreenClosed(object sender, EventArgs e)
        {
        }
    }
}
