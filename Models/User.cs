using System.ComponentModel.DataAnnotations;

namespace mvcgitexample.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Role { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
