using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestao_Salas_Back.Controllers.Base;
using GestaoSalas.Application.Interfaces;
using GestaoSalas.Application.Models.Inputs;
using Microsoft.AspNetCore.Mvc;


namespace Gestao_Salas_Back.Controllers
{
    public class AgendamentoController : BaseController
    {

        private readonly IAgendamentoService _service;
        public AgendamentoController(IAgendamentoService service)
        {
            _service = service;
        }


        /// <summary>
        /// Lista de Agendamentos
        /// </summary>
        /// <returns></returns>
        // GET: api/<AgendamentoController>
        [HttpGet]
        public IActionResult Get()
        {
            var schedulings = _service.GetList();
            return Ok(schedulings);
        }

        // GET api/<AgendamentoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }

        // POST api/<AgendamentoController>
        [HttpPost]
        public IActionResult Post([FromBody] SchedulingInput schedulingInput)
        {
            _service.AddNewScheduling(schedulingInput);
            return Ok();
        }

        // PUT api/<AgendamentoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] SchedulingInput schedulingInput)
        {
            _service.UpdateScheduling(schedulingInput, id);
            return Ok();
        }

        // DELETE api/<AgendamentoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteScheduling(id);
            return Ok();
        }
    }
}
