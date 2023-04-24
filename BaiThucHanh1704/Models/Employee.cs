using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaiThucHanh1704.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public string EmployeeCode { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string FacultyID { get; set; }
        [ForeignKey("FacultyID")]
        public Faculty? Faculty { get; set; }
        public string PostID {get; set;}
        [ForeignKey ("PostID")]
        public Post? Post {get; set;}

        
    }
}