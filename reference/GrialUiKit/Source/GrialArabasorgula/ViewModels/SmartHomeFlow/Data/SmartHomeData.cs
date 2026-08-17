/* [grial-metadata] id: Grial#SmartHomeData.cs version: 2.0.4 */
using System.Collections.ObjectModel;
using UXDivers.Grial;

namespace arabasorgula
{
    public class DashboardRoomItemData
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public bool ScheduledActivity { get; set; }
        public int DeviceCount { get; set; }
    }

    public class RoomDeviceItemData
    {
        public string Icon { get; set; }
        public string Name { get; set; }
        public string Info { get; set; }
        public bool ScheduledActivity { get; set; }
        public bool IsOn { get; set; }

        public string BackgroundColor { get; set; }
        public string Where { get; set; }
        public string DeviceColor { get; set; }
        public ObservableCollection<Schedule> Schedules { get; set; }

        public bool IsLamp { get; set; }
        public bool IsAir { get; set; }

        public Color DeviceColorColor => Color.FromArgb(DeviceColor);
        public Color BackgroundColorColor => Color.FromArgb(BackgroundColor);
    }

    public class Schedule
    {
        public string From { get; set; }
        public string To { get; set; }
        public List<string> Days { get; set; }
        public string When { get; set; }
    }

    public class MainDashboardItemData
    {
        public string Icon { get; set; }
        public string IconColor { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public bool IsOn { get; set; }

        public Color IconColorColor => Color.FromArgb(IconColor);
    }

    public class DashboardRoomChartItemData
    {
        public int Value { get; set; }
        public string Label { get; set; }
        public string ValueLabel { get; set; }
        public string ChartColor { get; set; }
        public string ValueLabelColor { get; set; }
    }
    
    public class AirDevice : RoomDeviceItemData
    {
        public double OutdoorTemp { get; set; }
        public double RoomTemp { get; set; }
        public AirMode Mode { get; set; }
        public AirSpeed Speed { get; set; }

        public AirDevice()
        {
            IsAir = true;
        }
    }

    public enum AirMode
    {
        Dry, Cool, Heat, Fan, Auto
    }

    public enum AirSpeed
    {
        Low, Medium, High, Auto
    }

    public class AirSchedule : Schedule
    {
        public double Temperature { get; set; }
        public AirMode Mode { get; set; }
        public AirSpeed Speed { get; set; }
    }

    public class AirSettingsData
    {
        public string Icon { get; set; }
        public string Name { get; set; }
    }
    
    public class LightDevice : RoomDeviceItemData
    {
        public double Intensity { get; set; }
        public string ColorScene { get; set; }

        public LightDevice()
        {
            IsLamp = true;
        }
    }

    public class LightSchedule : Schedule
    {
        public string ColorScene { get; set; }
        public double Intensity { get; set; }
    }
}