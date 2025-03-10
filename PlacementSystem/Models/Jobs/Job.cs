using PlacementSystem.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace PlacementSystem.Models.Jobs
{
	public class Job
	{
		[Key]
		public int Id { get; set; }
		public string CompanyName { get; set; }
		public string Location { get; set; }
		public string JobProfile { get; set; }
		public string InternshipDuration { get; set; }
		public string InternshipStipend { get; set; }
		public decimal Salary { get; set; }
		public string Description { get; set; }
		public DateTime PostedOn { get; set; } = DateTime.Now;

	}
}
