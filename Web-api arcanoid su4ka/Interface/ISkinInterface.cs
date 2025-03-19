using Web_api_arcanoid_su4ka.Model;

namespace Web_api_arcanoid_su4ka.Interface
{
    public interface ISkinInterface
    {
        Task<List<Skinmodel>> GetAllskins();
        Task<Skinmodel> Getskinbyid(int id);
        Task<bool> PostNewSkin(Skinmodel skinmodel);
        Task<bool> Editskinbyid(Skinmodel skinmodel);
        Task<bool> DeleteSkin(int id);
    }
}
