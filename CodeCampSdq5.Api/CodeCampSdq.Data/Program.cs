using System;
using System.IO;
using System.Linq;
using CodeCampSdq.Data.Dto;
using CodeCampSdq.Data.Storage;
using Newtonsoft.Json;

namespace CodeCampSdq.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating data, please wait...");

            try
            {
                using (var context = new CodeCampSdqContext())
                {
                    var speakers = context.Speakers.ToList();
                    var sessions = context.Sessions.ToList();
                    var sponsors = context.Sponsors.ToList();

                    sessions.ForEach(x => x.Speaker = null);
                    speakers.ForEach(x => x.Sessions = null);

                    var jsonData = new JsonData
                    {
                        Speakers = speakers,
                        Sessions = sessions,
                        Sponsors = sponsors
                    };

                    var jsonDataValue = JsonConvert.SerializeObject(jsonData, new JsonSerializerSettings()
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    File.WriteAllText("sessions.json", jsonDataValue);

                    Console.WriteLine("Data generation successfully.");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

            Console.Read();
        }
    }
}
