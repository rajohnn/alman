using Alman.Domain;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Servics
{
    public class SiteService : ServiceBase
    {
        public IEnumerable<VirtualHost> GetSites()
        {
            // partion 1 is root, partion 2 is for templates
            //var sites = _ctx.VirtualHost.Where(vh=>vh.DataPartition.Id > 2);
            IQueryable<VirtualHost> sites = _ctx.VirtualHost.
                Include(vh=>vh.DataPartition).Include(vh=>vh.ModifiedBy).
                Where(vh => vh.DataPartitionId > 2);
            
            return sites;
        }
    }
}
