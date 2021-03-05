using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{

    internal class InformationManager : IInformationService
    {
        public IInformationDal _informationDal;
        

        public InformationManager()
        {

        }

        public InformationManager(IInformationDal informationDal)
        {
            _informationDal = informationDal;
        }

       

        public void Add(ELibraryInformation eLibraryInformation)
        {
            _informationDal.Add(eLibraryInformation);
        }

        public void Delete(ELibraryInformation eLibraryInformation)
        {
            try
            {
                _informationDal.Delete(eLibraryInformation);
            }
            catch
            {

                throw new Exception("Silme gerçekleşemedi");
            }
        }
        public void Update(ELibraryInformation eLibraryInformation)
        {
            _informationDal.Update(eLibraryInformation);
        }


        public List<ELibraryInformation> GetAll()
        {
            return _informationDal.GetAll();
        }

        public List<ELibraryInformation> GetELibraryInformationByELibraryInformationsName(string eLibraryInformationName)
        {
            throw new NotImplementedException();
        }



        public List<ELibraryInformation> GetId()
        {
            return _informationDal.GetId();
        }




    }
}
