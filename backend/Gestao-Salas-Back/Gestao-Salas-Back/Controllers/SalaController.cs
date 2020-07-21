using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCore.Dominio;
using EFCore.Dominio.Entities;
using EFCore.Repo;
using Gestao_Salas_Back.Controllers.Base;
using Microsoft.AspNetCore.Mvc;

namespace Gestao_Salas_Back.Controllers
{
    public class SalaController : BaseController
    {

        public readonly AgendamentoContext _context;

        public SalaController(AgendamentoContext context)
        {
            _context = context;
        }

        //GET api/salas
        [HttpGet]
        public ActionResult Get()
        {
            var listSalas = _context.Salas.ToList();
            return Ok(listSalas);
        }

        //GET api/sala/{id}
        [HttpGet("{id}")]
        public ActionResult GetSala(int id)
        {
            var sala = _context.Salas
                        .Where(s => s.Id.Equals(id))
                        .ToList();

            if(sala != null)
            {
                return Ok(sala);
            } else
            {
                return NotFound();
            }

        }

        //UPDATE api/sala/atualizar/{id}
        [HttpPut("{id}")]
        public ActionResult PutSala(int id, Sala sala)
        {

            var salaEncontrada = _context.Salas
                           .Where(s => s.Id.Equals(id))
                           .FirstOrDefault();

            if(salaEncontrada != null)
            {
                salaEncontrada.Nome = sala.Nome;
                salaEncontrada.Descricao = sala.Descricao;

                _context.SaveChanges();
            } else
            {
                return NotFound();
            }

            return Ok();
        }

        //DELETE 
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var sala = _context.Salas
                               .Where(s => s.Id == id)
                               .Single();

            _context.Salas.Remove(sala);

            _context.SaveChanges();

            return Ok();
        }
    }
}
