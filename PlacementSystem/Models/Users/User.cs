using System;
using System.ComponentModel.DataAnnotations;

namespace PlacementSystem.Models.Users
{
	public class User
	{
		[Key]
		public int Id { get; set; }

		[Required, MaxLength(100)]
		public string FullName { get; set; }

		[Required, EmailAddress]
		public string Email { get; set; }

		public bool IsEmailVerified { get; set; } = false;

		[Phone, MaxLength(10)]
		public string? PhoneNumber { get; set; }

		public bool IsPhoneNumberVerified { get; set; } = false;

		[Required]
		public string PasswordHash { get; set; }

		[Required]
		public string Role { get; set; } = "Guest";  // Student, Admin, Company, etc.

		public DateTime? DateOfBirth { get; set; }

		public DateTime UpdatedAt { get; set; } = DateTime.Now;
		public DateTime CreatedAt { get; set; } = DateTime.Now;
	}
}
