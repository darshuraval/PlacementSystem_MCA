using Microsoft.EntityFrameworkCore;
using PlacementSystem.Models.Jobs;
using PlacementSystem.Models.Users;

namespace PlacementSystem.Data
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Job> Jobs { get; set; }
	    //public DbSet<Job> Job { get; set; } = default!;
		//public DbSet<Student> Students { get; set; }
		//public DbSet<Company> Companies { get; set; }
		//public DbSet<JobApplication> JobApplications { get; set; }
	}
}
