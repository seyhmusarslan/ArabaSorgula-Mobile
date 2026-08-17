/* [grial-metadata] id: Grial#NewsDetailPage.cs version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula;

public partial class NewsDetailPage : ContentPage
{
    public NewsDetailPage()
    {
        InitializeComponent();

        BindingContext = new NewsDetailViewModel();
    }

    public NewsDetailPage(NewsArticleData article)
    {
        InitializeComponent();

        BindingContext = new NewsDetailViewModel(article);
    }
}
