using Microsoft.EntityFrameworkCore;
using Web_api_arcanoid_su4ka.DatabaseContextblinept;
using Web_api_arcanoid_su4ka.Interface;
using Web_api_arcanoid_su4ka.Model;

namespace Web_api_arcanoid_su4ka.Service
{
    public class SkindService : ISkinInterface
    {
        private readonly DatabaseContextsu4ka _context;
        public SkindService(DatabaseContextsu4ka context)
        {
            _context = context;
        }
        public async Task<bool> DeleteSkin(int id)
        {
            var skinmodel = await _context.Skinmodels.FindAsync(id);
            if (skinmodel == null)
            {
                return false;
            }

            _context.Skinmodels.Remove(skinmodel);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Editskinbyid(Skinmodel skinmodel)
        {
            var skinddd = await _context.Skinmodels.FindAsync(skinmodel.ID_Skin);
            if (skinddd == null)
            {
                return false;
            }
            skinddd.ID_Skin = skinmodel.ID_Skin;
            skinddd.name_ball = skinmodel.name_ball;
            skinddd.Price = skinmodel.Price;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Skinmodel>> GetAllskins()
        {
            return await _context.Skinmodels.ToListAsync();
        }

        public async Task<Skinmodel> Getskinbyid(int id)
        {
            return await _context.Skinmodels.FindAsync(id);
        }

        public async Task<bool> PostNewSkin(Skinmodel skinmodel)
        {
            _context.Skinmodels.Add(skinmodel);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Usermodel> AuthAsync(string login, string password)
        {
            var user = await _context.Usermodels.FirstOrDefaultAsync(u => u.Username == login && u.password == password);
            return user;
        }
    }
}
