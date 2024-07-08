using System.Data.Entity;

namespace StudentManagement.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
