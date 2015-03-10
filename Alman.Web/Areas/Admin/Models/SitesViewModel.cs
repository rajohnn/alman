using Alman.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alman.Web.Areas.Admin.Models
{
    public class SitesViewModel
    {
        public List<SiteViewModel> Sites { get; set; }
        public List<SiteViewModel> SelectedSites { get; set; }
        
        public SitesViewModel() :this(null) { }

        public SitesViewModel(IEnumerable<VirtualHost> hosts)
        {            
            this.Sites = new List<SiteViewModel>();
            this.SelectedSites = new List<SiteViewModel>();

            foreach(var host in hosts) {
                var model = new SiteViewModel();
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

    public class SiteViewModel {
        public int HostId { get; set; }
        public string PartitionName { get; set; }
        public string HostName { get; set; }
        public string HostDescription { get; set; }
        public bool IsDeleted { get; set; }
        public string LastModifiedBy { get; set; }
    }
}