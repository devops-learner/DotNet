using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Http.Dependencies;
using Ninject.Syntax;
using Ninject.Parameters;
using Ninject.Activation;

namespace NetReviewed.DependencyResolver
{
    public class NinjectWebApiScope : IDependencyScope
    {
        protected IResolutionRoot _resolutionRoot;
        public NinjectWebApiScope(IResolutionRoot resolutionRoot)
        {
            this._resolutionRoot = resolutionRoot;
        }
        public object GetService(Type serviceType)
        {
            return _resolutionRoot.Resolve(this.CreateRequest(serviceType)).SingleOrDefault();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _resolutionRoot.Resolve(this.CreateRequest(serviceType));
        }

        private IRequest CreateRequest(Type serviceType)
        {
            return _resolutionRoot.CreateRequest(serviceType, null, new Parameter[0], true, true);
        }

        public void Dispose()
        {
            _resolutionRoot = null;
        }
    }
}
