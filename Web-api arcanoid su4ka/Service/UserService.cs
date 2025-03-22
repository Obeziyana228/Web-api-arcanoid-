using Microsoft.EntityFrameworkCore;
using Web_api_arcanoid_su4ka.DatabaseContextblinept;
using Web_api_arcanoid_su4ka.Interface;
using Web_api_arcanoid_su4ka.Model;

namespace Web_api_arcanoid_su4ka.Service
{
    public class UserService : IUserInterface
    {
        private readonly DatabaseContextsu4ka _context;
        public UserService(DatabaseContextsu4ka context)
        {
            _context = context;
        }
        public async Task<bool> DeleteUser(int id)
        {
            var userzxc = await _context.Usermodels.FindAsync(id);
            if (userzxc == null)
            {
                return false;
            }

            _context.Usermodels.Remove(userzxc);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> Edituserbyid(Usermodel Usermodel)
        {
            var userzxc = await _context.Usermodels.FindAsync(Usermodel.Id_user);
            if (userzxc == null) 
            {
                return false;
            }
            userzxc.Id_user = Usermodel.Id_user;
            userzxc.Username = Usermodel.Username;
            userzxc.password = Usermodel.password;
            userzxc.Balance = Usermodel.Balance;
            userzxc.ID_Skin_user = Usermodel.ID_Skin_user;

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Usermodel>> GetallUsers()
        {
            return await _context.Usermodels.ToListAsync();
        }

        public async Task<Usermodel> Getuserbyid(int id)
        {
            return await _context.Usermodels.FindAsync(id);
        }

        public async Task<bool> PostNewUser(Usermodel usermodel)
        {
            _context.Usermodels.Add(usermodel);
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
