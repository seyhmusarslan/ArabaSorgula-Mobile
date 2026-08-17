/* [grial-metadata] id: Grial#DocumentTimelinePage.xaml version: 1.0.1 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class DocumentTimelinePage : ContentPage
    {
        public DocumentTimelinePage()
        {
            InitializeComponent();

            BindingContext = new DocumentTimelineViewModel();
        }
    }
}
