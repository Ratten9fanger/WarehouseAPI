using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Domain.Models
{
    public class ProductLeavingHistory
    {
        public Guid Id { get;  }
        public Supplier SupplierId { get; }
        public Product ProductId { get; }
        public DateTime Date { get; }
        public decimal TotalPrice { get; }
    }
}
