using System.Data.Entity;
using System.Reflection;
using CodeCampSdq.Data.Entities;

namespace CodeCampSdq.Data.Storage
{
    public class CodeCampSdqContext : DbContext
    {
        public CodeCampSdqContext()
            : base("CodeCampSdqDb")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new NullDatabaseInitializer<CodeCampSdqContext>());
        }

        public DbSet<Session> Sessions { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

            modelBuilder
                .Properties()
                .Where(x => x.Name.Contains("Account"))
                .Configure(x => x.HasMaxLength(200));

            modelBuilder
                .Properties()
                .Where(x => x.Name.Equals("Name"))
                .Configure(x =>
                {
                    x.HasMaxLength(200);
                    x.IsRequired();
                });
        }
    }
}