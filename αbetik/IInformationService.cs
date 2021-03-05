using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{
    public interface IInformationService
    {
        List<ELibraryInformation> GetAll();
        
        List<ELibraryInformation> GetELibraryInformationByELibraryInformationsName(string eLibraryInformationName);
        void Add(ELibraryInformation eLibraryInformation);
        void Update(ELibraryInformation eLibraryInformation);
        void Delete(ELibraryInformation eLibraryInformation);
        List<ELibraryInformation> GetId();

    }
}
