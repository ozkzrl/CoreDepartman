using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
    public class Departmanlar
    {
        [Key]
        public int id { get; set; }

        public string departmanad { get; set; }
        public List<Personel>Personels { get; set; }
    }
}
