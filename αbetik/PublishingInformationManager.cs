using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{
    public class PublishingInformationManager : IPublishingInformationService
    {
        public IPublishingInformationDal _iPublishingInformationDal;
        public PublishingInformationManager()
        {

        }
        public PublishingInformationManager(IPublishingInformationDal ipublishingInformationDal)
        {
            _iPublishingInformationDal = ipublishingInformationDal;
        }
        public void Add(PublishingInformation publishingInformation)
        {
            _iPublishingInformationDal.Add(publishingInformation);
        }

        public void Delete(PublishingInformation publishingInformation)
        {
            try
            {
                _iPublishingInformationDal.Delete(publishingInformation);
            }
            catch
            {

                throw new Exception("Silme gerçekleşemedi");
            }
            
        }
        public void Update(PublishingInformation publishingInformation)
        {
            _iPublishingInformationDal.Update(publishingInformation);
        }

        public List<PublishingInformation> GetAll()
        {
            return _iPublishingInformationDal.GetAll();
        }

        public List<PublishingInformation> GetPublishingInformationRulesByTC(int publishingInformationTC)
        {
            return _iPublishingInformationDal.GetAll(p => p.TC == publishingInformationTC);
        }

        public List<PublishingInformation> GetId()
        {
            return _iPublishingInformationDal.GetId();
        }

        
    }
}
