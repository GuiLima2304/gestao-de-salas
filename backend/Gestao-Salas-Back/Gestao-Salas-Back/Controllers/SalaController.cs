using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Dominio;
using EFCore.Dominio.Entities;
using EFCore.Repo;
using Gestao_Salas_Back.Controllers.Base;
using GestaoSalas.Application.Interfaces;
using GestaoSalas.Application.Models.Inputs;
using Microsoft.AspNetCore.Mvc;

namespace Gestao_Salas_Back.Controllers
{
    public class SalaController : BaseController
    {

        public readonly ISalaService _service;

        public SalaController(ISalaService service)
        {
            _service = service;
        }

        /// <summary>
        /// Get de salas
        /// </summary>
        /// <returns></returns>
        //GET api/salas
        [HttpGet]
        public IActionResult Get()
        {

            var listSalas = _service.GetList();
            return Ok(listSalas);
        }

        /// <summary>
        /// Sala especifica
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //GET api/sala/{id}
        [HttpGet("{id}")]
        public IActionResult GetSala(int id)
        {
            return Ok(_service.Get(id));

        }

        /// <summary>
        /// update de sala
        /// </summary>
        /// <param name="id"></param>
        /// <param name="room"></param>
        /// <returns></returns>
        //UPDATE api/sala/atualizar/{id}
        [HttpPut("{id}")]
        public IActionResult PutSala(int id, RoomInput room)
        {
            _service.UpdateRoom(room, id);
            return Ok();
        }

        /// <summary>
        /// delete de sala
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //DELETE 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteRoom(id);
            return Ok();
        }

        /// <summary>
        /// nova sala
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post(RoomInput room)
        {
            _service.AddNewRoom(room);
            return Ok();
        }
    }
}
