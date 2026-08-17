/* [grial-metadata] id: Grial#CurvedHeaderArticlePage.xaml version: 1.0.6 */
using System;
using arabasorgula.Resx;
using UXDivers.Grial;

namespace arabasorgula
{
    public partial class CurvedHeaderArticlePage : ContentPage
    {
        public CurvedHeaderArticlePage()
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
