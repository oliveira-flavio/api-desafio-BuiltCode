using Desafio.Business.Interfaces;
using Desafio.Business.Models;
using Desafio.Business.Models.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Business.Services
{
    public class MedicoService : BaseService, IMedicoService
    {
        private readonly IMedicoRepository _medicoRepository;

        public MedicoService(IMedicoRepository medicoRepository, INotificador notificador) : base(notificador)
        {
            _medicoRepository = medicoRepository;
        }

        public async Task<bool> Adicionar(Medico medico)
        {
            if (!ExecutarValidacao(new MedicoValidation(), medico)) return false;

            if (_medicoRepository.Buscar(m => m.Crm == medico.Crm && m.UfCrm == medico.UfCrm).Result.Any())
            {
                Notificar("Já existe um médico cadastrado com o CRM informado na Unidade Federativa.");
                return false;
            }

            await _medicoRepository.Adicionar(medico);
            return true;
        }

        public async Task<bool> Atualizar(Medico medico)
        {
            if (!ExecutarValidacao(new MedicoValidation(), medico)) return false;

            if (_medicoRepository.Buscar(m => m.Crm == medico.Crm && m.UfCrm == medico.UfCrm && m.Id != medico.Id).Result.Any())
            {
                Notificar("Já existe um fornecedor com este documento infomado.");
                return false;
            }

            await _medicoRepository.Atualizar(medico);
            return true;
        }

        public void Dispose()
        {
            _medicoRepository?.Dispose();
        }

        public async Task<bool> Remover(Guid id)
        {
            await _medicoRepository.Remover(id);
            return true;
        }
    }
}
