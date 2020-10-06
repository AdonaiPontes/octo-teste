using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCTOTeste.Models
{
    public class Endereco
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int Tipo { get; set; }

        [Required]
        public string Logradouro { get; set; }
    }
}