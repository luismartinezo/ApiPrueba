using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPrueba.Models
{
    [Table("users")]
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Full_Names { get; set; }
        public string? Address { get; set; }
        public int Telephone { get; set; }
        public string? Email { get; set; }
        public int Age { get; set; }
        public ICollection<Role>? Roles { get; set; }

    }
}
