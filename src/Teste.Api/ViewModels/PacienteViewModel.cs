using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Api.ViewModels
{
    public class PacienteViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid MedicoId { get; set; }
        [StringLength(255)]
        public string Nome { get; set; }
        [Required]
        [StringLength(11, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 11)]
        public string Cpf { get; set; }
        [StringLength(20)]
        public string Telefone { get; set; }
        [ScaffoldColumn(false)]
        public string NomeMedico { get; set; }
    }
}
