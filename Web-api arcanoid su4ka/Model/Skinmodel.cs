using System.ComponentModel.DataAnnotations;

namespace Web_api_arcanoid_su4ka.Model
{
    public class Skinmodel
    {
        [Key]
        public int ID_Skin { get; set; }
        public string name_ball { get; set; }
        public int Price { get; set; }
    }
}
