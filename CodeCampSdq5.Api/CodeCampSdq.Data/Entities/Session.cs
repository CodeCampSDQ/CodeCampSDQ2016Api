using System;

namespace CodeCampSdq.Data.Entities
{
    public class Session : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int SpeakerId { get; set; }
        public Speaker Speaker { get; set; }
    }
}