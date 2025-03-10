using System.ComponentModel.DataAnnotations;
using PlacementSystem.Models.Users;
using PlacementSystem.Models.Jobs;

namespace PlacementSystem.Models.Reports
{
	public class PlacementReport
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public int StudentId { get; set; }
		public Student Student { get; set; }

		[Required]
		public int JobId { get; set; }
		public Job Job { get; set; }

		public DateTime PlacedOn { get; set; }
		public decimal SalaryPackage { get; set; }
	}
}
