using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    [Table("category1")]
    public class Category
    {
        public int c_id { get; set; }
        public string? c_name { get; set; }
    }
}
