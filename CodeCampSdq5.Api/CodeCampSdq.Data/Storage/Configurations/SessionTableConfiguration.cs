using System.Data.Entity.ModelConfiguration;
using CodeCampSdq.Data.Entities;

namespace CodeCampSdq.Data.Storage.Configurations
{
    public class SessionTableConfiguration : EntityTypeConfiguration<Session>
    {
        public SessionTableConfiguration()
        {
            Property(x => x.Description).IsRequired();
            Property(x => x.Location).IsRequired().HasMaxLength(200);
            Property(x => x.StartTime).IsRequired().HasColumnType("time").HasPrecision(7);
            Property(x => x.EndTime).IsRequired().HasColumnType("time").HasPrecision(7);
        }
    }
}