using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chullacafe.Models
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
    }
}
