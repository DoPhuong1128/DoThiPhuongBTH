using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiThucHanh1704.Models;

[Table("Posts")]
public class Post
{
    [Key]
    public string PostID { get; set; }
    public string PostName { get; set; }
}

