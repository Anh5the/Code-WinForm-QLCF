using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    internal class Progress
    {
        public Progress()
        {
            this.Orders = new HashSet<Order>();
        }

        public int ProgressID { get; set; }
        [Column(TypeName = "nchar(15)")]
        public string Name { get; set; }
        //[InverseProperty("Propress")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}