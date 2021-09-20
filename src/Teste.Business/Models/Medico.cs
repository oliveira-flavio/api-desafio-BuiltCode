using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Business.Models
{
    public class Medico : Entity
    {
        public string Nome { get; set; }
        public string Crm { get; set; }
        public string UfCrm { get; set; }
        public string Especialidade { get; set; }
        public List<Paciente> Pacientes { get; set; }
    }
}
