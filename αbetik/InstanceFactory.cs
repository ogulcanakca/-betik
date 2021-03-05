using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace αbetik
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            StandardKernel kernel = new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
