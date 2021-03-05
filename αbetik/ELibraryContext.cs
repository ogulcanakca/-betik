using System.Data.Entity;

namespace αbetik
{
    public class ELibraryContext : DbContext
    {
        public DbSet<ELibraryInformation> ELibraryInformations { get; set; }
    }
}