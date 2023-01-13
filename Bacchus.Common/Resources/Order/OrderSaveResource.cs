using Bacchus.Common.Core;
using Bacchus.Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacchus.Common.Resources.Order
{
    public class OrderSaveResource : Resource
    {
        public int UserId { get; set; }
        public int DeliveryAddressId { get; set; }
        public int TypeId { get; set; }
        public int StatusId { get; set; }
        public List<int> WinesId { get; set; }

        public OrderSaveResource()
        {
            WinesId= new List<int>();
        }
    }
}
