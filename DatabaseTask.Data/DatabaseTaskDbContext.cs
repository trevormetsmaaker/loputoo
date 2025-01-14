using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<galerii> galerii { get; set; }
        public DbSet<klient> klient { get; set; }
        public DbSet<kunstiteos> kunstiteos { get; set; }
        public DbSet<kunstnik> Kunstnik { get; set; }
        public DbSet<maal> maal { get; set; }
        public DbSet<omanik> omanik { get; set; }
        public DbSet<skulptuur> skulptuur { get; set; }
        public DbSet<tootaja> tootaja { get; set; }
    }
}
