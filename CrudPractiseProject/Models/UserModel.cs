namespace CrudPractiseProject.Models;

public class UserModel
{
    public string Id { get; set; }
    public required string UserName { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public required string Email { get; set; }
}