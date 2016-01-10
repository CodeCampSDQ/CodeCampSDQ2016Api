using System;
using System.Data.Entity.Migrations;
using CodeCampSdq.Data.Entities;
using CodeCampSdq.Data.Storage;

namespace CodeCampSdq.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<CodeCampSdqContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeCampSdqContext context)
        {
            var speaker = new Speaker
            {
                Name = "Luis Y. Ramirez",
                Bio = "Amo programar",
                PhotoUrl = "http://codecampsdq.com/wp-content/uploads/2015/02/luis-e1448989493290.jpg",
                FacebookAccount = "https://www.facebook.com/luisyamille.ramirezcastillo",
                GitHubAccount = "https://github.com/luis-ramirez"
            };

            var session = new Session
            {
                Name = "¿CUÁL ES EL MIEDO? SAL DE TU ZONA DE CONFORT!",
                Description =
                    @"En nuestro día a día nos olvidamos que existe algo mas allá de nuestro “8 a 5” y nos cerramos a conocer otros horizontes. Nuestra negación a aprender cosas nuevas hace que lamentablemente, nos perdamos de cosas más interesantes. Nuestro miedo a cambiar de trabajo, ambiente y sobre todo comodidad virtual, a veces nos estanca profesionalmente. Te mostraré como salir de tu zona de confort y cambiar tu manera de pensar; como convertirte en un desarrollador remoto y qué herramientas de la vida diaria necesitas para hacer que todos los días sean domingos :). Deja de esperar que las cosas pasen, sal ahí afuera y haz que pasen.",
                StartTime = DateTime.UtcNow.TimeOfDay,
                EndTime = DateTime.UtcNow.AddMinutes(45).TimeOfDay,
                Speaker = speaker,
                Location = "FD-412"
            };

            var sponsor = new Sponsor
            {
                Name = "Pizzahouse",
                Url = "http://pizzahouse.org",
                Level = 1,
                LogoUrl = "http://codecampsdq.com/wp-content/uploads/2015/02/luis-e1448989493290.jpg"
            };
            context.Sessions.AddOrUpdate(session);
            context.Sponsors.AddOrUpdate(sponsor);
            context.SaveChanges();
        }
    }
}
