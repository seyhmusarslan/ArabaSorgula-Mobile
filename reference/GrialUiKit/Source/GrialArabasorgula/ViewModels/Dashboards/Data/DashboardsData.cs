/* [grial-metadata] id: Grial#DashboardsData.cs version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public class DashboardCardItemData
    {
        public string Title { get; set; }
        public string Section { get; set; }
        public string Author { get; set; }
        public string Avatar { get; set; }
        public string BackgroundImage { get; set; }
        public string BackgroundColor { get; set; }

        //Workaround with binding colors on MAUI
        public Color BackgroundColorColor => Color.FromArgb(BackgroundColor);
    }

    public class DashboardMultipleTileItemData
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string Avatar { get; set; }
        public string BackgroundColor { get; set; }
        public string BackgroundImage { get; set; }
        public bool ShowBackgroundColor { get; set; }
        public bool IsNotification { get; set; }
        public string Icon { get; set; }
        public int Badge { get; set; }

        //Workaround with binding colors on MAUI
        public Color BackgroundColorColor => Color.FromArgb(BackgroundColor);
    }

    public class DashboardItemData
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
        public Color LightColorColor => Color.FromArgb(LightColor);
        public Color DarkColorColor => Color.FromArgb(DarkColor);
        public Color BackgroundColorColor => Color.FromArgb(BackgroundColor);
    }

    public class DashboardCategoryData
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Emoji { get; set; }
    }
}
