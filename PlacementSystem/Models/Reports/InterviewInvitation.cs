using System;
using System.ComponentModel.DataAnnotations;
using PlacementSystem.Models.Users;
using PlacementSystem.Models.Jobs;

namespace PlacementSystem.Models.Reports
{
	public class InterviewInvitation
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int JobId { get; set; }
		public Job Job { get; set; }

		[Required]
		public int StudentId { get; set; }
		public Student Student { get; set; }

		[Required]
		public DateTime InterviewDate { get; set; }

		public string Status { get; set; } = "Pending"; // Pending, Accepted, Rejected
	}
}
