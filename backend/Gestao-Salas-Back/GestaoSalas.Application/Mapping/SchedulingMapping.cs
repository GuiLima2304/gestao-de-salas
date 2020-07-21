using EFCore.Dominio;
using EFCore.Dominio.Entities;
using GestaoSalas.Application.Models.Inputs;
using GestaoSalas.Application.Models.Outputs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoSalas.Application.Mapping
{
    public static class SchedulingMapping
    {
        public static SchedulingOutput Map(Agendamento s)
        {
            return new SchedulingOutput
            {
                Id = s.Id,
                Title = s.Titulo,
                RoomId = s.IdSala,
                StartDate = s.DataHoraInicio,
                EndDate = s.DataHoraFim,
                RoomName = s.Sala.Nome
            };
        }

        public static Agendamento Map(SchedulingInput s)
        {
            return new Agendamento
            {
                Titulo = s.Title,
                IdSala = s.RoomId,
                DataHoraInicio = s.StartDate,
                DataHoraFim = s.EndDate
            };
        }
    }
}
