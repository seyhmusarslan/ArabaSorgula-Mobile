/* [grial-metadata] id: Grial#BookingReservationPage.xaml version: 1.1.6 */
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula;

public partial class BookingReservationPage : ContentPage
{
    public BookingReservationPage()
    {
        InitializeComponent();

        BindingContext = new BookingReservationViewModel(Navigation);      
    }
}
