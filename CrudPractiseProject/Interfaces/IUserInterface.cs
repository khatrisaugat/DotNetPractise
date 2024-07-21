using CrudPractiseProject.Models;

namespace CrudPractiseProject.Interfaces;

public interface IUserInterface
{
    Task<IEnumerable<UserModel>> GetUsers();
    Task<UserModel> AddUser(UserModel user);
    Task<UserModel> GetDetailUser(string userId);
    Task<UserModel> UpdateUser(UserModel user);
    Task<UserModel> DeleteUser(string userId);
}