using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_api_arcanoid_su4ka.Model
{
    public class UserSkinSvaz
    {
        [Key]
        public int ID_Svaz { get; set; }
        public int User_id { get; set; }
        public int Skind_id { get; set; }
    }
}
