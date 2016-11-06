using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http.Dependencies;
using Ninject;

namespace NetReviewed.DependencyResolver
{
    public class NinjectResolver :  NinjectWebApiScope, IDependencyResolver
    {
        private readonly Ninject.IKernel _kernel;

        public NinjectResolver(Ninject.IKernel kernel) :base(kernel)
        {
            // TODO: Complete member initialization
            this._kernel = kernel;
        }
        public IDependencyScope BeginScope() {

            return new NinjectWebApiScope(_kernel.BeginBlock());
        }
    }


}
