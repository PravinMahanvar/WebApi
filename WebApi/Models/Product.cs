using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPIProject.Models
{
    [Table("Product1")]
    public class Product
    {

        [Key]
        public int P_id { get; set; }
        [Required]
        public string? P_name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string? Image { get; set; }
        public int c_id { get; set; }
        [ScaffoldColumn(false)]
        public string? C_name { get; set; }
    }
}