using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{
    public class ManagerPanelInformationManager : IManagerPanelInformationService
    {
        public IManagerPanelInformationDal _managerPanelInformationDal;
        public ManagerPanelInformationManager()
        {

        }
        public ManagerPanelInformationManager(IManagerPanelInformationDal iManagerPanelInformationDal)
        {
            _managerPanelInformationDal = iManagerPanelInformationDal;
        }

        public void Add(ManagerPanelInformation managerPanelInformation)
        {
            ValidationTool.Validate(new Validator(), managerPanelInformation);
            _managerPanelInformationDal.Add(managerPanelInformation);
        }

        public void Update(ManagerPanelInformation managerPanelInformation)
        {
            _managerPanelInformationDal.Update(managerPanelInformation);
        }

        public void Delete(ManagerPanelInformation managerPanelInformation)
        {
            _managerPanelInformationDal.Delete(managerPanelInformation);
        }

        

        public List<ManagerPanelInformation> Get()
        {
            return _managerPanelInformationDal.Get();
        }

        public List<ManagerPanelInformation> GetAll()
        {
            return _managerPanelInformationDal.GetAll();
        }

        public List<ManagerPanelInformation> GetManagerPanelInformationByTC(long managerPanelInformation)
        {
            return _managerPanelInformationDal.GetAll(p => p.TC == managerPanelInformation);
            
        }
        public List<ManagerPanelInformation> GetManagerPanelInformationById(int managerPanelInformation)
        {
            return _managerPanelInformationDal.GetAll(p => p.Id == managerPanelInformation);

        }

        public List<ManagerPanelInformation> GetTC()
        {
            return _managerPanelInformationDal.GetTC();
        }
        public List<ManagerPanelInformation> GetId()
        {
            return _managerPanelInformationDal.GetId();
        }
    }
}
