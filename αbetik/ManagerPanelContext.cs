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
        
    }
}
