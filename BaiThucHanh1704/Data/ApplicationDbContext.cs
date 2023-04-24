using Microsoft.EntityFrameworkCore;
using BaiThucHanh1704.Models;

namespace BaiThucHanh1704.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students {get; set;} // khai báo class student (class được tạo từ models)
        public DbSet<Employee> Employees {get; set;}
       public DbSet<Customer> Customers {get; set;}
        public DbSet<Faculty> Faculty {get; set;}
        public DbSet<Address> Address {get; set;}
        public DbSet<Post> Post {get; set;}
       
    }    
        
}
