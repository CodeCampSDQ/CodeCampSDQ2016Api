using System.IO;
using System.Web.Http;

namespace CodeCampSdq5.Api.Controllers
{
    public class CodeCampSdqController : ApiController
    {
        public string GetSessions()
        {
            var result = string.Empty;

            var jsonFileName = @"sessions.json";

            if (File.Exists(jsonFileName))
                result = File.ReadAllText(jsonFileName);

            return result;
        }
    }
}
