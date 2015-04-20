using Alman.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alman.Web.Areas.Admin.Models
{
    public class ServicesViewModel
    {
        public int SelectedDataPartition { get; set; }
        public List<DataPartition> Partitions { get; set; }



        public ServicesViewModel()
        {
            this.Partitions = new List<DataPartition>();
        }
    }

    public class ServiceCategoryViewModel
    {
        public List<ServiceCategory> ServiceCategories { get; set; }
        public ServiceCategory ServiceCategory { get; set; }
        public int SelectedDataPartition { get; set; }
        public List<DataPartition> Partitions { get; set; }
    }


}