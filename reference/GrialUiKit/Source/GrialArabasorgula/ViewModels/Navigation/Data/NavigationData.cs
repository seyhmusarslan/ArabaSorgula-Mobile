/* [grial-metadata] id: Grial#NavigationData.cs version: 1.1.5 */
using UXDivers.Grial;
namespace arabasorgula
{
    public class NavigationItemData
    {
        public string Name { get; set; }
        public string BackgroundColor { get; set; }
        public string BackgroundImage { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public int Badge { get; set; }
        public int ItemCount { get; set; }
        public string Emoji { get; set; }
        public string LightColor { get; set; }
        public string DarkColor { get; set; }

        //Workaround with binding colors on MAUI
        public Color BackgroundColorColor => Color.FromArgb(BackgroundColor);
    }

    public class NavigationCategoryData
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Emoji { get; set; }
    }

    public class MovieData : ObservableObject
    {
        private bool _isPlaying;

        public string Name { get; set; }
        public string Director { get; set; }
        public string Year { get; set; }
        public string PosterImage { get; set; }
        public string BackgroundImage { get; set; }
        public string Overview { get; set; }
        public string TrailerVideo { get; set; }
        public int Rating { get; set; }
        public string RatingLabel { get; set; }
        public string AlternativeImage { get; set; }
        public string BackdropImage { get; set; }
        public string Color { get; set; }
        public string[] Genres { get; set; }

        public bool IsPlaying
        {
            get => _isPlaying;
            set => SetProperty(ref _isPlaying, value);
        }
    }

    public class SurveyData
    {
        public string Icon { get; set; }
        public string IconColor { get; set; }

        //Workaround with binding colors on MAUI
        public Color IconColorColor => Color.FromArgb(IconColor);
    }

    public class SurveyListData
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string StepsCompleted { get; set; }
        public string TotalSteps { get; set; }
        public double Progress { get; set; }
    }    
}
