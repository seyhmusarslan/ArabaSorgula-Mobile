/* [grial-metadata] id: Grial#SettingsData.cs version: 1.0.4 */
using UXDivers.Grial;
namespace arabasorgula
{
    public class SettingsUserData
    {
        public string Name { get; set; }
        public string NickName { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public bool IsPro { get; set; }
    }

    public class SettingsMainCategoryData
    {
        public string Category { get; set; }
        public string Icon { get; set; }
    }

    public class SettingsCategoryData
    {
        public string Category { get; set; }
        public string Icon { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public bool IsLink { get; set; }
        public bool IsToggle { get; set; }
        public bool IsToggled { get; set; }
        public bool IsSpacing { get; set; }
        public bool IsSignOut { get; set; }
        public bool IsHeader { get; set; }
        public bool HasDescription { get; set; }
        public string IconColor { get; set; }

        public Color IconColorColor => Color.FromArgb(IconColor);
    }

    public class SettingsMenuPromoData
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public string LightColor { get; set; }
        public string DarkColor { get; set; }

        public Color LightColorColor => Color.FromArgb(LightColor);
        public Color DarkColorColor => Color.FromArgb(DarkColor);
    }
}