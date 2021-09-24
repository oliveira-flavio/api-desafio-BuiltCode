using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Business.Models
{
    public class Parceiro : Entity
    {
        public string Nome { get; set; }
        public Guid ApiKey { get; set; }

        protected Guid ApiGuid()
        {
         return ApiKey = Guid.NewGuid();
        }
    }
}
