using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Domain.Models
{
    public class ProductComingHistory
    {
        public Guid Id { get; }
        public Customer CustomerId { get; }
        public Product ProductId { get; }
        public DateTime Date { get; }
        public decimal TotalPrice { get; }  
    }
}
