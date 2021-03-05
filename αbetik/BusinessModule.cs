using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IInformationService>().To<InformationManager>().InSingletonScope();
            Bind<IInformationDal>().To<EfInformationDal>().InSingletonScope();
            Bind<IManagerPanelInformationService>().To<ManagerPanelInformationManager>().InSingletonScope();
            Bind<IManagerPanelInformationDal>().To<EfManagerPanelInformationDal>().InSingletonScope();
            Bind<IPublishingInformationService>().To<PublishingInformationManager>().InSingletonScope();
            Bind<IPublishingInformationDal>().To<EfPublishingInformationDal>().InSingletonScope();
        }
    }
}
