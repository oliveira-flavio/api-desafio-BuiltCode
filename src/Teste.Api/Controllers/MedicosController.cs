using AutoMapper;
using Desafio.Api.ViewModels;
using Desafio.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.Api.Controllers
{
    [Route("api/[controller]")]
    public class MedicosController : MainController
    {
        private readonly IMedicoRepository _medicoRepository;
        private readonly IMapper _mapper;

        public MedicosController(IMedicoRepository medicoRepository, IMapper mapper)
        {
            _medicoRepository = medicoRepository;
            _mapper = mapper;
        }
        public async Task<ActionResult<IEnumerable<MedicoViewModel>>> ObterTodos()
        {
            var medico = _mapper.Map<IEnumerable<MedicoViewModel>>(await _medicoRepository.ObterTodos());
            return Ok(medico);
        }

    }
}
