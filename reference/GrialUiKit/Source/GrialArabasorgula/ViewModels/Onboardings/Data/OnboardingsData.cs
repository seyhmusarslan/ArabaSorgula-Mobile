/* [grial-metadata] id: Grial#OnboardingsData.cs version: 1.1.5 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public class HighlightData
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
        public string Color { get; set; }
    }

    public class WalkthroughBaseItemData
    {
        public string Header { get; set; }
        public string Text { get; set; }
        public string IconText { get; set; }
        public string ButtonText { get; set; }
        public string BackgroundColor { get; set; }
        public string IconColor { get; set; }
        public string ButtonBackgroundColor { get; set; }
        public string StepBackgroundImage { get; set; }

        public Color BackgroundColorColor => Color.FromArgb(BackgroundColor);
        public Color IconColorColor => Color.FromArgb(IconColor);
        public Color ButtonBackgroundColorColor => Color.FromArgb(ButtonBackgroundColor);
    }
    
    public class PermissionsAppData
    {
        public string Emoji { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public string PrimaryActionText { get; set; }
        public string PrimaryActionOutlineText { get; set; }
        public string StepIcon { get; set; }
    }
}