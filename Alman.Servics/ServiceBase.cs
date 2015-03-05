using Alman.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Servics
{
    public class ServiceBase : IDisposable
    {
        protected AlmanContext _ctx;
        private bool _disposed = false;

        public ServiceBase(AlmanContext ctx)
        {
            _ctx = ctx;
        }

        public ServiceBase()
        {
            _ctx = new AlmanContext();
        }

        ~ServiceBase()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // todo: There should be a way to call dispose on the context itself, but I cannot find 
                // any references to this on the web or MSDN documentation.
            }
            _disposed = true;
        }
    }
}
