using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{
    public class ELibraryInformation : IEntity
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Telno { get; set; }
        public string Kitapadi { get; set; }
        public string Kitapturu { get; set; }
        public string Kitapyazari { get; set; }
        public int Kitapsayfasayisi { get; set; }
    }
}
