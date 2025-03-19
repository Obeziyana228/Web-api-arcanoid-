using Web_api_arcanoid_su4ka.Model;

namespace Web_api_arcanoid_su4ka.Interface
{
    public interface ISvazkaInterface
    {
        Task<List<UserSkinSvaz>> GetallSvaz();
        Task<UserSkinSvaz> GetSvazbyId(int id);
        Task<bool> PostNewSvaz(UserSkinSvaz userSkinSvaz);
        Task<bool> EditSvazbyid(UserSkinSvaz userSkinSvaz);
        Task<bool> DeleteSvaz(int id);
    }
}
