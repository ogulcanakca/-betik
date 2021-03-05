using System.Data.Entity;

namespace αbetik
{
    public class PublishingInformationContext : DbContext
    {
        public DbSet<PublishingInformation> PublishingInformations { get; set; }
    }
}