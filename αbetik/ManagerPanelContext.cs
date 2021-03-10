using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{
    public class ManagerPanelContext : DbContext
    {
        public DbSet<ManagerPanelInformation> ManagerPanelInformations { get; set; }
        public DbSet<PublishingInformation> PublishingInformations { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<ManagerPanelContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }
}
