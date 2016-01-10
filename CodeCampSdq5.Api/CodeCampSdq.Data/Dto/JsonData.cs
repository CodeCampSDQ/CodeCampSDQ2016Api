using System.Collections.Generic;
using CodeCampSdq.Data.Entities;

namespace CodeCampSdq.Data.Dto
{
    public class JsonData
    {
        public JsonData()
        {
            Speakers = new List<Speaker>();
            Sessions = new List<Session>();
        }

        public List<Speaker> Speakers { get; set; }
        public List<Session> Sessions { get; set; }
    }
}