/* [grial-metadata] id: Grial#MoviesSectionTemplate.xaml version: 1.1.6 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class MoviesSectionTemplate : ContentView
    {
        public static readonly BindableProperty ScrollPaddingProperty = BindableProperty.Create(
           nameof(ScrollPadding),
           typeof(Thickness),
           typeof(MoviesSectionTemplate));

        public Thickness ScrollPadding
        {
            get { return (Thickness)GetValue(ScrollPaddingProperty); }
            set { SetValue(ScrollPaddingProperty, value); }
        }

        public static readonly BindableProperty TitleMarginProperty = BindableProperty.Create(
           nameof(TitleMargin),
           typeof(Thickness),
           typeof(MoviesSectionTemplate));

        public Thickness TitleMargin
        {
            get { return (Thickness)GetValue(TitleMarginProperty); }
            set { SetValue(TitleMarginProperty, value); }
        }

        public MoviesSectionTemplate()
        {
            InitializeComponent();
        }
    }
}
