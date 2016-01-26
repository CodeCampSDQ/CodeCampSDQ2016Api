using System.Data.Entity;
using System.Threading.Tasks;
using System.Web.Http;
using CodeCampSdq.Data.Dto;
using CodeCampSdq.Data.Storage;

namespace CodeCampSdq5.Api.Controllers
{
    public class CodeCampSdqController : ApiController
    {
        public async Task<JsonData> GetData()
        {
            using (var context = new CodeCampSdqContext())
            {
                var result = new JsonData
                {
                    Sessions = await context.Sessions.ToListAsync(),
                    Speakers = await context.Speakers.ToListAsync()
                };

                result.Speakers.ForEach(x => x.Sessions = null);
                result.Sessions.ForEach(x => x.Speaker = null);

                return result;
            }
        }
    }
}
