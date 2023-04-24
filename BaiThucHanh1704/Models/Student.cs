using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BaiThucHanh1704.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string FacultyID {get; set;}
        [ForeignKey("FacultyID")]
        public Faculty? Faculty { get; set; }
        public string AddressID {get; set;}
        [ForeignKey ("AddressID")]
        public Address? Address {get; set;}
       
        
    }
}