using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{
    public interface IManagerPanelInformationService
    {
        List<ManagerPanelInformation> GetAll();
        List<ManagerPanelInformation> Get();
        List<ManagerPanelInformation> GetManagerPanelInformationById(int managerPanelInformation);
        void Add(ManagerPanelInformation managerPanelInformation);
        
        void Update(ManagerPanelInformation managerPanelInformation);
        void Delete(ManagerPanelInformation managerPanelInformation);
    }
}
