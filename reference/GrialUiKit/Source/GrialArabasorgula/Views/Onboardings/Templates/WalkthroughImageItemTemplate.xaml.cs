/* [grial-metadata] id: Grial#WalkthroughImageItemTemplate.xaml version: 1.0.3 */
using UXDivers.Grial;
namespace arabasorgula
{
    public partial class WalkthroughImageItemTemplate : WalkthroughBaseItemTemplate
    {
        public static readonly BindableProperty IsLastPositionProperty = BindableProperty.Create(
           nameof(IsLastPosition),
           typeof(bool),
           typeof(WalkthroughImageItemTemplate));

        public bool IsLastPosition
        {
            get { return (bool)GetValue(IsLastPositionProperty); }
            set { SetValue(IsLastPositionProperty, value); }
        }

        public WalkthroughImageItemTemplate()
        {
            InitializeComponent();
        }
    }
}
