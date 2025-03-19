using System.ComponentModel.DataAnnotations.Schema;

namespace Web_api_arcanoid_su4ka.Model
{
    public class UserSkinSvaz
    {
        public int ID_Svaz { get; set; }
        [ForeignKey("Usermodel")]
        public string User_id { get; set; }
        [ForeignKey("Skinmodel")]
        public int Skind_id { get; set; }
        public bool IsActive { get; set; }
    }
}
