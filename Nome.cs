using System.ComponentModel.DataAnnotations;

namespace SeuNamespace.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        // Adicione mais propriedades conforme necessário
    }
}