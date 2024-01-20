using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLBH.Models
{
    internal class Employee
    {
        

        public long RoleID { get; set; }
        [Required]
        public virtual Role Roles { get; set; }
        public long EmployeeID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        public bool? Gender { get; set; }
        [Column(TypeName = "Date")]
        public DateTime BirthDay { get; set; }
        [StringLength(250)]
        public string Address { get; set; }
        [StringLength(10, MinimumLength = 10), Column(TypeName = "nchar(10)")]
        public string Phone { get; set; }
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        public string Email { get; set; }
        public bool Status { get; set; }
        
        [StringLength(100)]
        public string Password { get; set; }

       

    }

}

    
