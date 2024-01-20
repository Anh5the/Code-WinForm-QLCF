using System.ComponentModel.DataAnnotations;

namespace QLBH.Models
{
    internal class Order
    {
        public long? OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public TimeSpan OrderTime { get; set; }
        public DateTime? ReceiveDate { get; set; }
        public TimeSpan?     ReceiveTime { get; set; }
        [StringLength(250)]
        public string ReceiveAddress { get; set; }
        //[ForeignKey(nameof(Propress))]
        public int ProgressID { get; set; }
        //[ForeignKey(nameof(Customer))]
        public long CustomerID { get; set; }
        
        public virtual Customer Customer { get; set; }

        //[InverseProperty("Orders")]
        public virtual Progress Progress { get; set; }
       

        public Order()
        {
            this.OrderDetails = new HashSet<OrderDetail>();
        }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
