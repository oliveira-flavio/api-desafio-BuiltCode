using AutoMapper;
using Desafio.Api.ViewModels;
using Desafio.Business.Interfaces;
using Desafio.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Desafio.Api.Controllers
{
    [Route("api/[controller]")]
    public class MedicosController : MainController
    {
        private readonly IMedicoRepository _medicoRepository;
        private readonly IMedicoService _medicoService;
        private readonly IMapper _mapper;

        public MedicosController(IMedicoRepository medicoRepository, IMapper mapper, IMedicoService medicoService)
        {
            _medicoRepository = medicoRepository;
            _mapper = mapper;
            _medicoService = medicoService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicoViewModel>>> ObterTodos()
        {
            var medico = _mapper.Map<IEnumerable<MedicoViewModel>>(await _medicoRepository.ObterTodos());
            return Ok(medico);
        }
        [HttpGet("{id:guid}")]
        public async Task<ActionResult<MedicoViewModel>>ObterPorId(Guid id)
        {
            var medico = _mapper.Map<MedicoViewModel>(await _medicoRepository.ObterPorId(id));

            if (medico == null)
            {
                return NotFound();
            }
            return medico;
        }

        [HttpPost]
        public async Task<ActionResult<MedicoViewModel>> Adicionar(MedicoViewModel medicoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var medico = _mapper.Map<Medico>(medicoViewModel);
            await _medicoService.Adicionar(medico);

            return Ok();
        }
    }
}
