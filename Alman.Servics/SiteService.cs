using Alman.Domain;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alman.Domain.DTO;

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

        public bool UpdateHost(SiteHostDto siteHostDto)
        {   
            var virtualHost = _ctx.VirtualHost.SingleOrDefault(vh => vh.Id == siteHostDto.HostId);
            if (virtualHost != null)
            {
                virtualHost.DomainName = siteHostDto.HostName;
                virtualHost.Description = siteHostDto.HostDescription;
                _ctx.VirtualHost.Attach(virtualHost);
                _ctx.Entry(virtualHost).State = EntityState.Modified;
                try
                {
                    int count = _ctx.SaveChanges();
                    return count > 0 ? true : false;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                }
                return false;
            }
            else
                return false;
            
        }
    }
}
