using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCampSdq.Data.Entities
{
    public class Sponsor : BaseEntity
    {
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public string Url { get; set; }
        public int Level { get; set; }
    }
}
