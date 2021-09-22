using Desafio.Business.Interfaces;
using Desafio.Business.Models;
using Desafio.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Data.Repository
{
    public class MedicoRepository : Repository<Medico>, IMedicoRepository
    {
        public MedicoRepository(DesafioDbContext context) : base(context)
        {
        }
    }
}
