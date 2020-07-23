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

        /// <summary>
        /// agendamento especifico
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<AgendamentoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_service.Get(id));
        }

        /// <summary>
        /// novo agendamento
        /// </summary>
        /// <param name="schedulingInput"></param>
        /// <returns></returns>
        // POST api/<AgendamentoController>
        [HttpPost]
        public IActionResult Post([FromBody] SchedulingInput schedulingInput)
        {
            _service.AddNewScheduling(schedulingInput);
            return Ok();
        }

        /// <summary>
        /// update de agendamento
        /// </summary>
        /// <param name="id"></param>
        /// <param name="schedulingInput"></param>
        /// <returns></returns>
        // PUT api/<AgendamentoController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] SchedulingInput schedulingInput)
        {
            _service.UpdateScheduling(schedulingInput, id);
            return Ok();
        }

        /// <summary>
        /// deletar um agendamento
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // DELETE api/<AgendamentoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteScheduling(id);
            return Ok();
        }
    }
}
