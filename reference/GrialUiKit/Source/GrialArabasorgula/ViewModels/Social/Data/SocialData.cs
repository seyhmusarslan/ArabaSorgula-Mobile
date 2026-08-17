/* [grial-metadata] id: Grial#SocialData.cs version: 1.0.1 */
using System;
using UXDivers.Grial;

namespace arabasorgula
{
    public class FriendData
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
    }

    public class ProfileData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Avatar { get; set; }
    }

    public class TimelineEventData
    {
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public string Image { get; set; }
        public string When { get; set; }
    }

    public class TeamMemberData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string EmojiFlag { get; set; }
        public string Position { get; set; }
        public string About { get; set; }
        public string Picture { get; set; }
    }
}
