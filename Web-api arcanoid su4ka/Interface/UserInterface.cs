using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Web_api_arcanoid_su4ka.Model;

namespace Web_api_arcanoid_su4ka.Interface
{
    public interface IUserInterface
    {
        Task<List<Usermodel>> GetallUsers();
        Task<Usermodel> Getuserbyid(int id);
        Task<bool> PostNewUser(Usermodel usermodel);
        Task<bool> Edituserbyid(Usermodel Usermodel);
        Task<bool> DeleteUser(int id);
    }
}
