using UserRepositoryInterfaces.Interfaces;
using Ninject;
using Ninject.Syntax;
using SecurityServiceImplementation;
using SecurityServiceInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using UserRepositoryImplementation;

namespace DependencyInjector
{
    public class NinjectDependencyResolver : IDependencyResolver {
        private IKernel kernel;

        public NinjectDependencyResolver() {
            kernel = new StandardKernel();
            AddBindings();
        }

        public object GetService(Type serviceType) {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType) {
            return kernel.GetAll(serviceType);
        }

        public IBindingToSyntax<T> Bind<T>() {
            return kernel.Bind<T>();
        }

        public void AddBindings() {
            Bind<IUserRepository>().To<UserRepository>();
            Bind<ISecurityService>().To<SecurityService>();
        }
    }

}
