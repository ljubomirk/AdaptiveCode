using _2_NewCodeSmell.Interfaces;
using _2_NewCodeSmell.Models;
using Ninject;
using Ninject.Syntax;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace _2_NewCodeSmell.Infrastructure {
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