/* [grial-metadata] id: Grial#ArticlesBrowserPage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class ArticlesBrowserPage : ContentPage
    {
        public ArticlesBrowserPage()
        {
            InitializeComponent();

            BindingContext = new ArticlesBrowserViewModel();
        }
    }
}
