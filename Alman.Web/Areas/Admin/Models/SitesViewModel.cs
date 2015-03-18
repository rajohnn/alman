using Alman.Domain;
using Alman.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alman.Web.Areas.Admin.Models
{
    public class SitesViewModel
    {
        public List<SiteHostDto> Sites { get; set; }
        public List<SiteHostDto> SelectedSites { get; set; }
        
        public SitesViewModel() :this(null) { }

        public SitesViewModel(IEnumerable<VirtualHost> hosts)
        {            
            this.Sites = new List<SiteHostDto>();
            this.SelectedSites = new List<SiteHostDto>();

            foreach(var host in hosts) {
                var model = new SiteHostDto();
                model.HostId = host.Id;
                model.PartitionName = host.DataPartition.Name;
                model.HostName = host.DomainName;
                model.HostDescription = host.Description;
                model.IsDeleted = host.IsDeleted;
                model.LastModifiedBy = host.ModifiedBy.UserName;
                this.Sites.Add(model);
            }
        }
    }

    
}