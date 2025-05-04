using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Domain.Models
{
    public class Product
    {
        public Guid ID { get; }
        public string Name { get; }
        public int ArticleNumber { get; }
        public int PiecesPerPack { get; }
        public int CurrentCount { get; }
        public Sector Id;
        public string Description;
    }
}
