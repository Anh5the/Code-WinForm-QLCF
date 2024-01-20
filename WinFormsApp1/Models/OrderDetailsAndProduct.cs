using Microsoft.EntityFrameworkCore;

namespace QLBH
{

    internal class OrderDetailsAndProduct
    {
        public long OrderDetailID { get; set; }
        public long OrderID { get; set; }
        public long ProductID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get { return Quantity * Price; } }

        
    }
}