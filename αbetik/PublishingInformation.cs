using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{
    public class PublishingInformation : IEntity
    {
        
        public int Id { get; set; }
        public int TC { get; set; }
        public string Kurallar { get; set; }
    }
}
