using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CodeCampSdq.Data.Entities
{
    public class Speaker : BaseEntity
    {
        public Speaker()
        {
            Sessions = new Collection<Session>();
        }

        public string Name { get; set; }
        public string Bio { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public string PhotoUrl { get; set; }
        public string TwitterAccount { get; set; }
        public string FacebookAccount { get; set; }
        public string GitHubAccount { get; set; }
        public string LinkedInAccount { get; set; }
        public string GooglePlusAccount { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}