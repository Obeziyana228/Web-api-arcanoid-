using Microsoft.EntityFrameworkCore;
using Web_api_arcanoid_su4ka.DatabaseContextblinept;
using Web_api_arcanoid_su4ka.Interface;
using Web_api_arcanoid_su4ka.Model;

namespace Web_api_arcanoid_su4ka.Service
{
    public class SvazServie : ISvazkaInterface
    {
        private readonly DatabaseContextsu4ka _context;
        public SvazServie(DatabaseContextsu4ka context)
        {
            _context = context;
        }
        public async Task<bool> DeleteSvaz(int id)
        {
            var svazz = await _context.Userskinmodel.FindAsync(id);
            if (svazz == null)
            {
                return false;
            }

            _context.Userskinmodel.Remove(svazz);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> EditSvazbyid(UserSkinSvaz userSkinSvaz)
        {
            var svazzzxczxcc = await _context.Userskinmodel.FindAsync(userSkinSvaz.ID_Svaz);
            if (svazzzxczxcc == null)
            {
                return false;
            }
            svazzzxczxcc.ID_Svaz = userSkinSvaz.ID_Svaz;
            svazzzxczxcc.User_id = userSkinSvaz.User_id;
            svazzzxczxcc.Skind_id = userSkinSvaz.Skind_id;
            svazzzxczxcc.IsActive = userSkinSvaz.IsActive;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<UserSkinSvaz>> GetallSvaz()
        {
            return await _context.Userskinmodel.ToListAsync();
        }

        public async Task<UserSkinSvaz> GetSvazbyId(int id)
        {
            return await _context.Userskinmodel.FindAsync(id);
        }

        public async Task<bool> PostNewSvaz(UserSkinSvaz userSkinSvaz)
        {
            _context.Userskinmodel.Add(userSkinSvaz);
            await _context.SaveChangesAsync();
            return true;
        }
        public async Task<Usermodel> AuthAsync(string login, string password)
        {
            var user = await _context.Usermodels.FirstOrDefaultAsync(u => u.Username == login && u.password == password);
            return user;
        }
        public async Task<bool> HasSkinAsync(int userId, int ballId)
        {
            var userSkin = await _context.Userskinmodel
                .FirstOrDefaultAsync(us => us.User_id == userId && us.Skind_id == ballId);

            return userSkin != null;
        }
    }
}
