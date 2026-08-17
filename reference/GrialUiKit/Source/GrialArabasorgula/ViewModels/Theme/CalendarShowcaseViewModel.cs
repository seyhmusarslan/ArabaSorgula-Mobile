/* [grial-metadata] id: Grial#CalendarShowcaseViewModel.cs version: 1.0.5 */
using System.Globalization;
using UXDivers.Grial;

namespace arabasorgula
{
    public class CalendarShowcaseViewModel : ObservableObject
    {
        private CalendarSelectionMode _selectionMode = CalendarSelectionMode.NoSelection;
        private DateTime _selectedDate;
        private (DateTime, DateTime)? _selectedRange;

        private bool _showWeekDays = true;
        private bool _singleDaySelection, _multipleDaySelection, _rangeSelection, _showTodayDay = false;

        public CalendarShowcaseViewModel()
        {
        }

        public DateTime SelectedDate
        {
            get => _selectedDate;
            set => SetProperty(ref _selectedDate, value);
        }

        public (DateTime, DateTime)? SelectedRange
        {
            get => _selectedRange;
            set => SetProperty(ref _selectedRange, value);
        }

        public CalendarSelectionMode SelectionMode
        {
            get => _selectionMode;
            set => SetProperty(ref _selectionMode, value);
        }

        public bool ShowTodayDay
        {
            get => _showTodayDay;
            set => SetProperty(ref _showTodayDay, value);
        }

        public bool SingleDaySelection
        {
            get => _singleDaySelection;
            set
            {
                if (SetProperty(ref _singleDaySelection, value))
                {
                    if (value)
                    {
                        MultipleDaySelection = false;
                        RangeSelection = false;
                    }

                    UpdateSelectionMode();
                }
            }
        }

        public bool MultipleDaySelection
        {
            get => _multipleDaySelection;
            set
            {
                if (SetProperty(ref _multipleDaySelection, value))
                {
                    if (value)
                    {
                        SingleDaySelection = false;
                        RangeSelection = false;
                    }

                    UpdateSelectionMode();
                }
            }
        }
        
        public bool RangeSelection
        {
            get => _rangeSelection;
            set
            {
                if (SetProperty(ref _rangeSelection, value))
                {
                    if (value)
                    {
                        SingleDaySelection = false;
                        MultipleDaySelection = false;
                    }

                    UpdateSelectionMode();
                }
            }
        }

        public bool ShowWeekDays
        {
            get => _showWeekDays;
            set => SetProperty(ref _showWeekDays, value);
        }

        private void UpdateSelectionMode()
        {
            if (SingleDaySelection)
            {
                SelectionMode = CalendarSelectionMode.Single;
            }
            else if (MultipleDaySelection)
            {
                SelectionMode = CalendarSelectionMode.Multiple;
            }
            else if (RangeSelection)
            {
                SelectionMode = CalendarSelectionMode.Range;
            }
            else
            {
                SelectionMode = CalendarSelectionMode.NoSelection;
            }
        }
    }
}