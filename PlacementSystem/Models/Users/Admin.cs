namespace PlacementSystem.Models.Users
{
	public class Admin : User
	{
		public string? ManagedUsers { get; set; } // Could be a list in the future
	}
}
