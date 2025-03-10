using System.ComponentModel.DataAnnotations;
using PlacementSystem.Models.Users;
namespace PlacementSystem.Models.Jobs
{
	public class JobApplication
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int StudentId { get; set; }
		public Student Student { get; set; }

		[Required]
		public int JobId { get; set; }
		public Job Job { get; set; } // Use full namespace here

		public DateTime AppliedOn { get; set; } = DateTime.Now;

		[Required]
		public string Status { get; set; } = "Pending";  // Pending, Accepted, Rejected
	}
}
