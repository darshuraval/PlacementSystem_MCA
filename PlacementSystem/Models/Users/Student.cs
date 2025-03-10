using System.ComponentModel.DataAnnotations;
using PlacementSystem.Models.Jobs;

namespace PlacementSystem.Models.Users
{
	public class Student : User
	{
		public string? Resume { get; set; }
		public string? SSC { get; set; }
		public string? HSC { get; set; }
		public string? Diploma { get; set; }

		// Navigation property
		public ICollection<JobApplication>? JobApplications { get; set; }
	}
}
