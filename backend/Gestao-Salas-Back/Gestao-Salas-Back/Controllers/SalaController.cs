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

        //GET api/salas
        [HttpGet]
        public IActionResult Get()
        {

            var listSalas = _service.GetList();
            return Ok(listSalas);
        }

        //GET api/sala/{id}
        [HttpGet("{id}")]
        public IActionResult GetSala(int id)
        {
            return Ok(_service.Get(id));

        }

        //UPDATE api/sala/atualizar/{id}
        [HttpPut("{id}")]
        public IActionResult PutSala(int id, RoomInput room)
        {
            _service.UpdateRoom(room, id);
            return Ok();
        }

        //DELETE 
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteRoom(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(RoomInput room)
        {
            _service.AddNewRoom(room);
            return Ok();
        }
    }
}
