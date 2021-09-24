using Desafio.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Business.Interfaces
{
    public interface IMedicoService : IDisposable
    {
        Task<bool> Adicionar(Medico medico);
        Task<bool> Atualizar(Medico medico);
        Task<bool> Remover(Guid id);
    }
}
