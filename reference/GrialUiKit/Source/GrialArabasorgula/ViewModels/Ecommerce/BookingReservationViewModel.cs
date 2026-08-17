/* [grial-metadata] id: Grial#BookingReservationViewModel.cs version: 1.1.6 */
using System.Globalization;
using System.Windows.Input;
using UXDivers.Grial;

namespace arabasorgula
{
    public class BookingReservationViewModel : ObservableObject
    {
        private readonly INavigation _navigation;
        private HotelBookingData _hotelBooking;
        private DateTime _selectedDate;
        private (DateTime, DateTime)? _selectedRange;

        public BookingReservationViewModel(INavigation navigation)
        {
            _navigation = navigation;

            StartDate = DateTime.ParseExact($"01/{DateTime.Now.Month:00}/{DateTime.Now.Year}", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            EndDate = GetLastDayOfMonth(StartDate.AddMonths(5));

            LoadData();

            CloseCommand = new Command(OnClose);
            BookCommand = new Command(OnBook);
        }

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }

        public (DateTime, DateTime)? SelectedRange
        {
            get => _selectedRange;
            set => SetProperty(ref _selectedRange, value, nameof(RangeStart), nameof(RangeEnd));
        }

        public DateTime StartDate { get; }
        public DateTime EndDate { get; }

        public DateTime? RangeStart => SelectedRange?.Item1;
        public DateTime? RangeEnd => SelectedRange?.Item2;

        public HotelBookingData HotelBooking
        {
            get => _hotelBooking;
            set => SetProperty(ref _hotelBooking, value);
        }

        public ICommand CloseCommand { get; }
        public ICommand BookCommand { get; }

        private void OnClose()
        {
            _navigation.PopModalAsync();
        }

        private void OnBook()
        {
            if (Application.Current == null || Application.Current.Windows.Count == 0)
            {
                return;
            }

            string message = $"Booked {HotelBooking.Name} from ";

            if (SelectedRange != null && SelectedRange.HasValue)
            {
                message += SelectedRange.Value.Item1 < SelectedRange.Value.Item2 ?
                    $"{SelectedRange.Value.Item1.ToShortDateString()} to {SelectedRange.Value.Item2.ToShortDateString()} " :
                    $"{SelectedRange.Value.Item2.ToShortDateString()} to {SelectedRange.Value.Item1.ToShortDateString()} ";

                message += $"for {HotelBooking.Cost}";
            }
            else
            {
                message = "Please select a valid range.";
            }

            Application.Current?.Windows[0]?.Page.DisplayAlertAsync("Action", message, "Ok");
        }

        private void LoadData()
        {
            HotelBooking = null;

            JsonHelper.Instance.LoadViewModel(this, source: "Ecommerce.json");
        }

        private static DateTime GetLastDayOfMonth(DateTime dateTime) => new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
    }
}