
using System.ComponentModel.DataAnnotations;


namespace QLBH.Models
{
    internal class Category
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        public long CategoryID { get; set; }
        public string CategoryName { get; set; }
        [StringLength(100)]
        public int Order { get; set; }
        public bool CategoryStatus { get; set; }
        //[InverseProperty("Category")]
        public virtual ICollection<Product> Products { get; set; }
       
    }
}