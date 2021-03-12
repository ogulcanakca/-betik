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
        List<ManagerPanelInformation> GetManagerPanelInformationByTC(long managerPanelInformation);
        List<ManagerPanelInformation> GetManagerPanelInformationById(int managerPanelInformation);
        List<ManagerPanelInformation> GetTC();
        //List<ManagerPanelInformation> GetPublishingInformationRulesByTC(int publishingInformationTC);
        void Add(ManagerPanelInformation managerPanelInformation);
        
        void Update(ManagerPanelInformation managerPanelInformation);
        void Delete(ManagerPanelInformation managerPanelInformation);
    }
}
