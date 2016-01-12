using System.IO;
using System.Web.Http;
using CodeCampSdq.Data.Dto;
using Newtonsoft.Json;

namespace CodeCampSdq5.Api.Controllers
{
    public class CodeCampSdqController : ApiController
    {
        public JsonData GetSessions()
        {
            var rawData = string.Empty;

            var jsonFileName = System.Web.Hosting.HostingEnvironment.MapPath(@"~/sessions.json");

            if (File.Exists(jsonFileName))
                rawData = File.ReadAllText(jsonFileName);

            if (string.IsNullOrWhiteSpace(rawData)) return null;

            var result = JsonConvert.DeserializeObject<JsonData>(rawData, new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            return result;
        }
    }
}
