using AutoMapper;
using Desafio.Api.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Api.Controllers
{
    [Route("api/[controller]")]
    public class PacientesController : MainController
    {
        private readonly IPacienteRepository _pacienteRepository;
        private readonly IPacienteService _pacienteService;
        private readonly IMapper _mapper;
        public PacientesController(IPacienteRepository pacienteRepository, IMapper mapper)
        {
            _pacienteRepository = pacienteRepository;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PacienteViewModel>>> ObterTodos()
        {
            var paciente = _mapper.Map<IEnumerable<PacienteViewModel>>(await _pacienteRepository.ObterTodos());
            return Ok(paciente);
        }
    }
}
