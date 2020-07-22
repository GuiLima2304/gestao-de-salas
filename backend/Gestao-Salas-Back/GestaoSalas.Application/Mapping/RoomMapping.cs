using EFCore.Dominio.Entities;
using GestaoSalas.Application.Models.Inputs;
using GestaoSalas.Application.Models.Outputs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoSalas.Application.Mapping
{
    public static class RoomMapping
    {
        public static RoomOutput Map(Sala s)
        {
            return new RoomOutput
            {
                Id = s.Id,
                Name = s.Nome,
                Description = s.Descricao
            };
        }

        public static Sala Map(RoomInput s)
        {
            return new Sala
            {
                Nome = s.Name,
                Descricao = s.Description
            };
        }
    }
}
