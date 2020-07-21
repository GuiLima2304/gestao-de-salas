using EFCore.Dominio;
using GestaoSalas.Application.Models.Inputs;
using GestaoSalas.Application.Models.Outputs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoSalas.Application.Interfaces
{
    public interface IAgendamentoService
    {
        void AddNewScheduling(SchedulingInput scheduling);
        void UpdateScheduling(SchedulingInput scheduling, int id);
        void DeleteScheduling(int id);
        IEnumerable<SchedulingOutput> GetList();
        SchedulingOutput Get(int id);

    }
}
