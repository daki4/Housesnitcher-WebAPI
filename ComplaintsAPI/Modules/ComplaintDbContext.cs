using Microsoft.EntityFrameworkCore;

namespace ComplaintsAPI.Modules
{
    public class ComplaintDbContext : DbContext
    {
        public ComplaintDbContext(DbContextOptions<ComplaintDbContext> options) : base(options) { }
        public DbSet<Complaint> Complaints { get; set; } = null!;
    }
}
