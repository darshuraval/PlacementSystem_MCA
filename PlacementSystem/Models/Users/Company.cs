using PlacementSystem.Models.Jobs;

namespace PlacementSystem.Models.Users
{
	public class Company : User
	{
		public string CompanyName { get; set; }
		public string? PersonName { get; set; }
		public string? PersonMobileNumber { get; set; }
		public string? PersonEmail { get; set; }
		public string? CompanyAddress { get; set; }
		public string? CompanyProfile { get; set; }

		// Navigation property
		public ICollection<Job>? JobPostings { get; set; }
	}
}
