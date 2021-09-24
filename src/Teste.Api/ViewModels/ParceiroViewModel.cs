using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Api.ViewModels
{
    public class ParceiroViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public Guid ApiKey { get; set; }
    }
}
