using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh1704.Models;

    [Table("Address")]
    public class Address
    {
        [Key]
        public string AddressID { get; set; }
        public string AddressNane { get; set; }
    }