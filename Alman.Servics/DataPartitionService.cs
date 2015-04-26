using Alman.Data;
using Alman.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alman.Servics
{
    public class DataPartitionService : ServiceBase
    {
        public DataPartitionService() : base() {}
        public DataPartitionService(AlmanContext context) : base(context) { }

        public IEnumerable<DataPartition> GetValidPartitions(User user)
        {
            var list = new List<DataPartition>();
            if (user.IsRoot()) {
                list = _ctx.DataPartitions.ToList();
            }
            else
            {
                list = _ctx.DataPartitions.Where(dp => dp.Id == user.DataPartitionId).ToList();
            }
            return list;
        }
    }
}
