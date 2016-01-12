using System;
using System.Collections.Generic;
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
            var sessions = GetSessions();

            foreach (var session in sessions)
                context.Sessions.AddOrUpdate(session);

            context.SaveChanges();
        }

        private IEnumerable<Session> GetSessions()
        {
            var result = new List<Session>();

            #region Jonathan Montero

            var jonathanMontero = BuildSpeaker("Jonathan Montero", email: "jmrxto@linux.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/jonathanmontero.jpg",
                gp: "https://plus.google.com/+JonathanMontero", li: "https://do.linkedin.com/in/monterojonathan");

            var samba4 = BuildSession("Samba 4.0 como Active Directory",
                @"Se mostrará como se puede prescindir de un Windows Server 2003/2008/2012 y obtener el mismo resultado con Software Libre.",
                TimeSpan.Zero, TimeSpan.Zero, "", jonathanMontero);

            result.Add(samba4);

            #endregion

            #region Raul Roa

            var raulRoa = BuildSpeaker(name: "Raúl Roa", email: "raul.roa@gmail.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/RaulRoa.jpg",
                twitter: "https://twitter.com/rgroag", fb: "https://www.facebook.com/profile.php?id=840540186&fref=ts",
                gp: "https://www.facebook.com/profile.php?id=840540186&fref=ts", li: "https://www.linkedin.com/in/raulroa",
                gh: "https://github.com/rroa");

            var automatingPortabilityAnalysis =
                BuildSession("Automating portability analysis and performance optimization of native code",
                    @"Software portability rarely receives systematic attention in the software development process. With the Web becoming a viable distribution platform for software, interest of migrating native code applications to the browser is growing. This presentation describes a study that aims to describe native code portability rules that allow for optimal computational performance when using Emscripten and Native Client to cross-compile to the Web with special attention to graphic accelerated applications. It introduces ConConJS, a diagnosis tool that evaluates graphics applications written using native code to target the Web as a platform.",
                    TimeSpan.Zero, TimeSpan.Zero, "", raulRoa);

            result.Add(automatingPortabilityAnalysis);

            #endregion

            #region David Hemmat

            var davidHemmat = BuildSpeaker(name: "David Hemmat",
                photoUrl:
                    "http://codecampsdq.com/wp-content/uploads/2015/02/12394591_10156441873730347_1532536231_o.jpg",
                email: "riazhack@gmail.com", gp: "https://plus.google.com/u/0/112822407069926046063/posts",
                li: "https://www.linkedin.com/in/dhemmat");

            var desarrolloRapidoRails = BuildSession("Desarrollo rápido en Rails ",
                @"En esta charla hablaremos un poco acerca de el uso de Rails para el desarrollo de MVPs y otras aplicaciones que deben ser desarrolladas de manera rápida.Veremos en que casos Rails tiene sentido y en que casos no, y algunas ventajas y desventajas de Rails vs.otras plataformas.

Veremos algunas de las herramientas y acuerdos que nos provee Rails(generadores, scaffolding, ActiveRecord, convention over configuration, ciertas gemas, 'The Rails Way') para ayudarnos a desarrollar de manera rápida.

Idealmente, trataríamos algo como 10 pedacitos de magia distintos que ilustren como Rails nos ayuda a desarrollar rápido con ejemplos de código para cada uno.", 
                TimeSpan.Zero, TimeSpan.Zero, "", davidHemmat);

            var frelanceando = BuildSession("Freelanceando 101",
                @"Discutir primeros pasos para un Developer que quiere trabajar como freelancer.Un overview general de algunos temas importantes para un freelancer empezando.

- Como encontrar los primeros clientes
- Como establecer una reputación
- Como establecer un precio por servicios
- Otras consideraciones", 
                TimeSpan.Zero, TimeSpan.Zero, "", davidHemmat);

            result.Add(frelanceando);
            result.Add(desarrolloRapidoRails);

            #endregion

            #region Arturo Mejia

            var arturoMejia = BuildSpeaker(name: "Arturo Mejia", photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/arturo_mejia_marmol.jpg",
                email: "arturomejiamarmol@gmail.com", fb: "https://www.facebook.com/amejiamarmol", gp: "https://plus.google.com/u/0/102386605749597633831/posts");

            var comoConvertirteEnAndroidExpert = BuildSession("Como convertirte en un Android Expert desde cero",
                @"La charla estaría enfocada en que los participantes puedan tener un lineamiento  o un conjunto de pasos a seguir para  convertirse en expertos en desarrollo Android, sin tener que invertir nada más que su tiempo.

Sin importar el nivel de conocimiento que tengas con la plataforma algo aprenderás;

            Si no tienes conocimientos previos.

¡Excelente!Al concluir la charla saldrás con un lineamiento(Paso a paso) para pasar de 0 a experto.

Si conoces la plataforma.

¡Mucho mejor!Compartiremos conocimientos, refrescaras lo que sabes y aprenderás nuevas cosas que te ayudaran a llegar a otro nivel.

Quiero compartir lo que he aprendido, seguir aprendiendo y  conocer personas que sientan pación por la plataforma.", 
            TimeSpan.Zero, TimeSpan.Zero, "", arturoMejia);

            result.Add(comoConvertirteEnAndroidExpert);

            #endregion

            #region Onil Pereyra

            var onilPereyra = BuildSpeaker(name: "Onil Pereyra", email: "onil.pereyra@gmail.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2015/12/onilpereyra.jpg",
                twitter: "https://twitter.com/onilpereyra", fb: "https://www.facebook.com/OnilPereyraCabrera/?fref=ts",
                gp: "https://plus.google.com/u/0/109786577398293898664/posts",
                li: "https://www.linkedin.com/in/onilpereyra",
                gh: "https://github.com/OnilPereyra");

            var skillsEveryStarupTn = BuildSession("Skills Every Startup Team Needs",
                @"Landing a job at a promising startup is a lucrative opportunity. This talk is about how to make yourself attractive to the founders who could become the next titans of tech. ", 
                TimeSpan.Zero, TimeSpan.Zero, "", onilPereyra);

            result.Add(skillsEveryStarupTn);

            #endregion

            #region Mitra Mejía

            var mitraMejia = BuildSpeaker(name: "Mitra Mejía", email: "mitra@mitramejia.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/mitramejia.jpg", 
                twitter: "https://twitter.com/mitramejia", fb: "https://www.facebook.com/MitraMejia",
                gp: "https://plus.google.com/u/0/102566572520992378762/posts",
                li: "https://www.linkedin.com/in/mitra-mej%C3%ADa-57372968",
                gh: "https://github.com/mitramejia");

            var tiendasECommerce = BuildSession("Desarollo de tiendas eCommerce con Shopify",
                @"Esta charla resalta el importante rol que jugamos los developers en el desarrollo eCommerce y cómo los nuevos devs pueden insertarse en este mercado.

Shopify como CMS para tiendas eCommerce presenta una solucion rapida y robusta para el desarrollo de tiendas eCommerce.Goza de amplia popularidad entre los clientes y administradores de tiendas online, pero y los developers ? Exploraremos las ventajas y desventajas de este CMS.", 
                TimeSpan.Zero, TimeSpan.Zero, "", mitraMejia);

            result.Add(tiendasECommerce);

            #endregion

            #region Leonardo Jimenez

            var leonardoJimenez = BuildSpeaker(name: "Leonardo Jimenez", email: "leonardo@codetiger.co",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2015/12/leonardojimenez.jpg",
                fb: "https://www.facebook.com/leonardoajim?fref=ts",
                gp: "https://plus.google.com/u/0/107589842563566172538/posts",
                li: "https://www.linkedin.com/in/leonardoajimenez");

            var refactoring = BuildSession("Refactoring: Keeping your code healthy",
                @"Your code will decay, that’s a law of software, entropy will win… if you don’t work hard on improving the way your code works. The purpose of this talk is to illustrate a few estrategies for finding and improving the hygiene of your code in order to keep your application easy to change and healthier.

The main problems we will deal through refactoring are:

-Duplication
- Excess Copling
- Quick Fixes
- Technical Debt

This talk is aim at beginners developers willing to improve as software developers.", 
                TimeSpan.Zero, TimeSpan.Zero, "", leonardoJimenez);

            result.Add(refactoring);

            #endregion

            #region Raydelto Hernandez

            var raydelto = BuildSpeaker(name: "Raydelto Hernandez", email: "raydelto@gmail.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2015/12/raydeltohernandez.jpg",
                url: "http://www.raydelto.org/new_site/", twitter: "https://twitter.com/raydelto",
                fb: "https://www.facebook.com/raydelto?fref=ts", gp: "https://plus.google.com/110043763476935930884/posts",
                li: "https://www.linkedin.com/in/raydelto-hernandez-53977a36", gh: "https://github.com/raydelto");

            var cocos = BuildSession("Desarrollo Rápido de Videojuegos Con Javascript y Cocos2d-x",
                @"Hoy día existen muchas herramientas para crear videojuegos, todas tienen sus ventajas y desventajas. Esta charla te enseñará a  crear videojuegos utilizando solamente  un editor de texto y un browser como herramientas y posteriormente como empaquetar tu juego de manera nativa para las plataformas Android y iOS  utilizando como herramienta Cocos2d-x.", 
                TimeSpan.Zero, TimeSpan.Zero, "", raydelto);

            result.Add(cocos);

            #endregion

            #region Vivian Guillen

            var vivianGuillen = BuildSpeaker(name: "Vivian Guillen", email: "vivian@viviangb.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2015/12/vivianguillen-e1452091222796.jpg",
                fb: "https://www.facebook.com/vivian.guillen.37?fref=ts", gp: "https://plus.google.com/+vivianguillen",
                li: "https://www.linkedin.com/in/vivian-guillen-07299ab9", gh: "https://github.com/viviangb");

            var uiKit = BuildSession("UiKit - A better alternative to bootstrap",
                @"Nowadays it’s very common to use a css framework to develop web applications, from MVP’s to full fledged production applications. The most used of these frameworks is Bootstrap. This talk aims to open the mind of the attendees to a particular alternative to bootstrap called UIkit and how it compares to other css frameworks.", 
                TimeSpan.Zero, TimeSpan.Zero, "", vivianGuillen); 

            result.Add(uiKit);

            #endregion

            #region Eduardo Burgos

            var burguito = BuildSpeaker(name: "Eduardo Burgos", email: "eburgos@gmail.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/eduardoburgos.jpg",
                fb: "https://www.facebook.com/eduardoburgosm?fref=ts",
                gp: "https://plus.google.com/114963581984393777773/posts",
                gh: "https://github.com/eburgos");

            var fileNewProject =
                BuildSession("File -> New -> Project | Una aplicación desde cero con NineJS y TypeScript",
                    @"Esta charla es un resumen de como iniciar un proyecto de una aplicación web single - page desde cero utilizando NineJS(framework de mi autoría), Node, y desarrollando en TypeScript.

Durante el proceso pretendo explicar los siguientes conceptos:
-Server side con Node.js
- NineJS
  - Concepto de módulos y dependencias
  - Interoperabilidad(y reusabilidad de codigo) entre cliente y servidor
  - Conceptos de Widgets(client - side)

- Conceptos del lifecycle de parte del cliente(algo rapido)
  - Preprocesadores de CSS
  - Templating Engines
  - Module loaders
  - Optimizacion de JS
- TypeScript
  - Como aprovechar sus ventajas en una aplicacion empresarial

- Aplicacion desde cero en practica(Prefabricada y vista rapidamente commit tras commit)
  - Escrita sobre Node.js con NineJS y CouchDB",
                    TimeSpan.Zero, TimeSpan.Zero, "", burguito);

            result.Add(fileNewProject);

            #endregion

            #region Julissa Mateo

            var julissaMateo = BuildSpeaker(name: "Julissa Mateo", email: "julissa0115@gmail.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/julissamateo.jpg",
                fb: "https://www.facebook.com/MateoJulissa?fref=ts", gp: "https://plus.google.com/114323010523905229118/posts",
                li: "https://www.linkedin.com/in/julissamateo", gh: "https://github.com/MateoJulissa");

            var softwareTestingForDevelopers = BuildSession("Software Testing para Desarrolladores",
                @"Introducir a los presentes a las pruebas no manuales de software, ver técnicas y desafíos a la hora de automatizar, y  mostrarles demos de herramientas para distintos tipos de pruebas(Desktop, Web y Mobile.) utilizadas en el mercado el dia de hoy.

Especialmente:

Testing en enfoques tradicionales
Testing en enfoques ágiles

Para la charla seria bueno que los participantes tengan pre instalado un trial de 30 de Días del HP UFT - QTP solo para el demo, pero ademas se mostraran otras alternativas.", TimeSpan.Zero, TimeSpan.Zero, "", julissaMateo); 

            
            result.Add(softwareTestingForDevelopers);

            #endregion

            #region Lorenzo Solano

            var lorenzoSolano = BuildSpeaker(name: "Lorenzo Solano", email: "lorenzo.sm@gmail.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/lorenzosolano.jpg",
                twitter: "https://twitter.com/lorenzo_solano", fb: "https://www.facebook.com/lorenzo.sm",
                li: "https://www.linkedin.com/in/lorenzo-solano-a8455133", gh: "https://github.com/lsolano");

            var solidPrinciples = BuildSession("Diseño Orientado a Objetos: Principios SOLID",
                @"
Breve explicación del acrónimo S.O.L.I.D.utilizando ejemplos de código, se realizarán ejemplos para demostrar los siguientes principios:
 *Responsabilidad única(Single responsibility)
 * Abierto - Cerrado(Open - closed)
 * Sustitución de Liskov(Liskov substitution)
 * Segregación de Interfaces(Interface segregation)
 * Inversión de dependencias(Dependency inversion)

Dado que los principios obedecen al paradigma de Orientación a Objetos, se utilizarán lenguajes como C# y/o Java en las demostraciones.", 
                TimeSpan.Zero, TimeSpan.Zero, "", lorenzoSolano);


            var systemThinkingAndSoftware = BuildSession("Systems Thinking and Software Craftsmanship: Una visión holística sobre la Ingeniería de Software",
                @"Analiza la Ingeniería de Software en el contexto de la teoría de sistemas para aterrizar los problemas que presenta nuestra profesión en el país, conectando todo esto con la necesidad de pasar del empirismo y labor mecánica al profesionalismo (craftsmanship).", 
                TimeSpan.Zero, TimeSpan.Zero, "", lorenzoSolano);

            result.Add(systemThinkingAndSoftware);
            result.Add(solidPrinciples);

            #endregion

            #region Luis Ramirez

            var luisRamirez = BuildSpeaker(name: "Luis Ramirez", email: "lyrc@outlook.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2015/02/luis-e1448989493290.jpg",
                bio: @"Luis Ramirez tiene mas de 8 años de experiencia escribiendo software tanto el mercado local como internacional en la plataforma .NET y es una de las personas responsables de que comunidades como c#.do y Mobile.Do existan. Ademas de que es un apasionado a las buenas practicas y del buen software.",
                twitter: "https://twitter.com/luisyaram", fb: "https://www.facebook.com/luisyamille.ramirezcastillo?fref=ts",
                gp: "https://plus.google.com/102417462123409313753/posts", gh: "https://github.com/luis-ramirez");

            var cualEsElMiedo = BuildSession("Cual es el miedo? sal de tu zona de confort.",
                @"En nuestro día a día nos olvidamos que existe algo mas allá de nuestro 8~5 y nos cerramos a conocer otros horizontes.Nuestra negación a aprender cosas nuevas nos hace que lamentablemente, nos perdamos de cosas mas interesantes.Nuestro miedo a cambiar de trabajo, ambiente y sobre todo comodidad virtual, aveces nos estanca profesionalmente.

Te mostrare como salir de tu zona de confort y cambiar tu manera de pensar; como convertirte en un desarrollador remoto y que tools de la vida diaria necesitas para hacer que todos los días sean domingos :).

Deja de esperar que las cosas pasen, sal ahi afuera y haz que pasen.", 
                TimeSpan.Zero, TimeSpan.Zero, "", luisRamirez); 

            result.Add(cualEsElMiedo);

            #endregion

            #region David Contreras

            var davidContreras = BuildSpeaker(name: "David Contreras", email: "davidcv9@gmail.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/davidcontreras1.jpg",
                bio:
                    "Ingeniero en Sistema egresado de la Universidad O&M ,amante de la tecnologia, la buena comida y  del billar.");

            var elPoderDeEmber = BuildSession("El poder de EmberJS",
                @"Ember.js es un framework JavaScript, basado inicialmente en MVC(model - view - Controller).Esto permite a los desarrolladores crear SPA(single page aplication) incorporando un lenguaje común y el uso de mejores practicas dentro del framework.

Ember es usado en diferentes sitios webs  pero también  es posible construir aplicaciones mobiles y de escritorio.El mas notable ejemplo de una aplicación de escritorio es Apple Music, una característica del Itune.", 
                TimeSpan.Zero, TimeSpan.Zero, "", davidContreras); 

            result.Add(elPoderDeEmber);

            #endregion

            #region Yelidi Caballero

            var yelidiCaballero = BuildSpeaker(name: "Yelidi Caballero", email: "yelidyc@gmail.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/yelidicaballero.jpg",
                bio:
                    @"Coordinadora de GPS en Philip Morris Internationa, analista en corrección de factor de potencia y reparadora de equipos eléctricos. Tecnología en Mecatronica ITLA, casi Lic. en Matemáticas UASD y futura Ing. Eléctrica INTEC. Emprendedora, visionaria, amante y apasionada por la electricidad y electrónica, soñadora con que este sera un país en el cual desarrollaremos nuevas tecnologías.",
                gp: "https://plus.google.com/111969940824885315915/posts");

            var domotica = BuildSession("Domotica",
                @"Elektra fue mi proyecto ganador en Startup Weekend Santigo este año, consiste en domotizar las viviendad para de esa forma ahorrar energía, de que forma, la siguiente: instalando kits de comunicación blutue o wifi para que si se te olvida apagar el aire lo puedas hacer desde tu celular, si no apagaste el bombillo del baño, lo pueda apagar desde tu teléfono inteligente, cosas así, pues mi idea es presentar este proyecto en que hice en pequeña escala. ¿Como en pequeña escala? Pues hice una maquetado de como seria mi casa inteligente y así llevarlo a grande. Mi charla es motivar a los jóvenes con el tema de la electrónica y la programación ver que de la basura que recolecto como radio viejos, televisores, los mismos moden de comunicación a Internet se pueden hacer grandes cosas con la basura electrónica y de esa forma intuir y enseñar como lo hice.", 
                TimeSpan.Zero, TimeSpan.Zero, "", yelidiCaballero); 

            result.Add(domotica);

            #endregion

            #region Jose Gregorio Taveras

            var joseGregorio = BuildSpeaker(name: "Jose Gregorio Taveras", email: "jose.taveras@gmail.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/josegregorio.jpg",
                bio:
                    @"Jose Gregorio Taveras tiene mas de 7 años de experiencia en asp.net y c#,cuenta con amplia experiencia en arquitectura SOA y ambientes Oracle. actualmente trabajando para la empresa aseguradora mas grande del país como líder de proyectos, trabajando desde la concepción hasta la implementación de diferentes proyectos.",
                twitter: "https://twitter.com/JGTaveras", fb: "https://www.facebook.com/jgtaveras?fref=ts",
                gp: "https://plus.google.com/108002271064501252755/posts", li: "https://www.linkedin.com/in/jose-gregorio-taveras-taveras-16738952",
                gh: "https://github.com/jgtaveras");

            var securingAspWebApi = BuildSession("Securing Asp.Net Web Api Like a Boss",
                @"Asegurar tu api con un simple usuario y clave, ya no es suficiente. En esta charla vamos ver como podemos autenticar nuestro web api basado en OWIN, usando OAUTH y Json Web Tokens (JWT). Si no sabes que es nada de esto, tranquilo No previous experience required!!", 
                TimeSpan.Zero, TimeSpan.Zero, "", joseGregorio); 

            result.Add(securingAspWebApi);

            #endregion

            #region Ariel Santana

            var arielSantana = BuildSpeaker(name: "Ariel Santana", email: "arielsant@gmail.com",
                photoUrl: "http://codecampsdq.com/wp-content/uploads/2016/01/arielsantana.jpg",
                twitter: "https://twitter.com/relsantana", fb: "http://t.co/uUimRZKMoR");

            var laVocacionDelProgramador = BuildSession("La vocación del programador",
                @"Mónologo de Stand Up Comedy sobre lo cómico de ser desarrollador en la República Dominicana.", 
                TimeSpan.Zero, TimeSpan.Zero, "", arielSantana); 

            result.Add(laVocacionDelProgramador);

            #endregion

            return result;
        }

        private Session BuildSession(string name, string description, TimeSpan startTime, TimeSpan endTime,
            string location, Speaker speaker)
        {
            var result = new Session
            {
                Name = name,
                Description = description,
                Location = location,
                StartTime = startTime,
                EndTime = endTime,
                Speaker = speaker
            };

            return result;
        }
        
           
        private Speaker BuildSpeaker(string name, string bio = "", string url = "", string photoUrl = "", string twitter = "", 
            string fb = "", string gp = "", string li = "", string gh = "", string email = "")
        {
            var result = new Speaker
            {
                Name = name,
                Bio = bio,
                Url = url,
                PhotoUrl = photoUrl,
                TwitterAccount = twitter,
                GitHubAccount = gh,
                FacebookAccount = fb,
                GooglePlusAccount = gp,
                LinkedInAccount = li,
                Email = email
            };

            return result;
        }
    }
}
