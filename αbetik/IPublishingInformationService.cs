using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{
    public interface IPublishingInformationService
    {
        List<PublishingInformation> GetAll();

        List<PublishingInformation> GetPublishingInformationRulesByTC(int publishingInformationTC);
        void Add(PublishingInformation publishingInformation);
        void Update(PublishingInformation publishingInformation);
        void Delete(PublishingInformation publishingInformation);
        List<PublishingInformation> GetId();
    }
}
