using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web_api_arcanoid_su4ka.Model
{
    public class Usermodel
    {
        [Key]
        public int Id_user { get; set; }
        public string Username { get;set; }
        public string password { get; set; }
        public int Balance { get; set; }
        [ForeignKey("Skinmodel")]
        public int ID_Skin_user { get; set; }
    }
}
