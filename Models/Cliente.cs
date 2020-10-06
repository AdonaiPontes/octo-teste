using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OCTOTeste.Models
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(int id, string nome, string documento, string tipoDocumento, string telefone, string tipoTelefone, string endereco, string tipoEndereco)
        {
            Id = id;
            Nome = nome;
            Documento = documento;
            TipoDocumento = tipoDocumento;
            Telefone = telefone;
            TipoTelefone = tipoTelefone;
            Endereco = endereco;
            TipoEndereco = tipoEndereco;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string TipoDocumento { get; set; }

        [Required]
        public string Documento { get; set; }

        [Required]
        public string TipoTelefone { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string TipoEndereco { get; set; }

        [Required]
        public string Endereco { get; set; }
    }
}