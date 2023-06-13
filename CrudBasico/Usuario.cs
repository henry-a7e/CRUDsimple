using System.ComponentModel.DataAnnotations;

namespace CrudBasico
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
