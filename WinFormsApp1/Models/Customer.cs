using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    internal class Customer
    {
        public Customer()
        {
            this.Order = new HashSet<Order>();
        }
        public long CustomerID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public bool? Gender { get; set; }
        [Column(TypeName = "Date")]
        public DateTime BirthDay { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(10, MinimumLength = 10), Column(TypeName ="nchar(10)")]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]

        [StringLength(100)]
        public string? Email { get; set; }
        public bool Status { get; set; }
        //[InverseProperty("Customer")]
        public virtual ICollection<Order> Order { get; set; }
    }
}