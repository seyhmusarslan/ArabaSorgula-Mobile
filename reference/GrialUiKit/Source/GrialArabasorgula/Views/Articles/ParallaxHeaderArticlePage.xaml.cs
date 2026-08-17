/* [grial-metadata] id: Grial#ParallaxHeaderArticlePage.xaml version: 1.0.6 */
using arabasorgula.Resx;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class ParallaxHeaderArticlePage : ContentPage
    {
        public ParallaxHeaderArticlePage()
        {
            InitializeComponent();

            BindingContext = new ComplexArticleDetailViewModel(variantPageName: $"{GetType().Name}.xaml");
        }

        public void OnPrimaryActionButtonClicked(object sender, EventArgs e)
        {
            DisplayAlertAsync(AppResources.StringButtonTapped, AppResources.ButtonAddComment, AppResources.StringOK);
        }
    }
}
