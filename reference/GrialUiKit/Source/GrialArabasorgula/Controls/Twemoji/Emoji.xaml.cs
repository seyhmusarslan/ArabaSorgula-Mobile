/* [grial-metadata] id: Grial#Emoji.xaml version: 2.0.3 */
using UXDivers.Grial;
namespace arabasorgula
{
    /// <summary>
    /// Twemoji: https://github.com/jdecked/twemoji
    /// Fluent family: https://github.com/AdvenaHQ/fluent-emoji
    /// </summary>
    public partial class Emoji
    {
        public enum EmojiFamily
        {
            Twemoji,
            Fluent
        }

        public static readonly BindableProperty FamilyProperty = BindableProperty.Create(
            nameof(Family),
            typeof(EmojiFamily),
            typeof(Emoji),
            defaultValue: EmojiFamily.Twemoji,
            propertyChanged: (b, o, n) => ((Emoji)b).GetEmojiUnicodeFromTwemoji());

        public EmojiFamily Family
        {
            get { return (EmojiFamily)GetValue(FamilyProperty); }
            set { SetValue(FamilyProperty, value); }
        }

        public static readonly BindableProperty UnicodeProperty = BindableProperty.Create(
           nameof(Unicode),
           typeof(string),
           typeof(Emoji),
           propertyChanged: (b, o, n) => ((Emoji)b).GetEmojiUnicodeFromTwemoji());

        public string Unicode
        {
            get { return (string)GetValue(UnicodeProperty); }
            set { SetValue(UnicodeProperty, value); }
        }

        public Emoji()
        {
            InitializeComponent();
        }

        private void GetEmojiUnicodeFromTwemoji()
        {
            image.Source = Unicode != null ? GetImageSource(Unicode.ToLower()) : null;
        }

        private ImageSource GetImageSource(string code) => new UriImageSource
        {
            Uri = new Uri(GetCdnUri(code)),
            CachingEnabled = true,
            CacheValidity = TimeSpan.FromDays(7)
        };

        private string GetCdnUri(string code) =>
            Family == EmojiFamily.Fluent ?
                $"https://emoji.fluent-cdn.com/1.0.0/100x100/{code}.png" :
                $"https://cdn.jsdelivr.net/gh/jdecked/twemoji@latest/assets/72x72/{code}.png";
    }
}
