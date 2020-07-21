﻿using EFCore.Dominio;
using EFCore.Dominio.Entities;
using GestaoSalas.Application.Interfaces;
using GestaoSalas.Application.Interfaces.Repositories;
using GestaoSalas.Application.Mapping;
using GestaoSalas.Application.Models.Inputs;
using GestaoSalas.Application.Models.Outputs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestaoSalas.Application.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private readonly IAgendamentoRepository _repository;
        private readonly IUnitOfWork _unitOfWork;
        public AgendamentoService(IAgendamentoRepository repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }
        public void AddNewScheduling(SchedulingInput input)
        {
            var scheduling = SchedulingMapping.Map(input);

            ValidateScheduling(scheduling);

            _repository.Add(scheduling);
            _unitOfWork.Commit();

        }

        private void ValidateScheduling(Agendamento scheduling)
        {

            // to do: verificar se a sala existe

            var existScheduling = _repository.Exist(os =>
            (os.IdSala == scheduling.IdSala) &&
            (os.DataHoraInicio > scheduling.DataHoraInicio || os.DataHoraInicio < scheduling.DataHoraInicio) &&
            (os.DataHoraInicio > scheduling.DataHoraFim || os.DataHoraFim < scheduling.DataHoraFim) &&
            (scheduling.DataHoraFim > scheduling.DataHoraInicio));

            if (existScheduling)
            {
                throw new Exception("Sala Ocupada");
            }
        }

        public void DeleteScheduling(int id)
        {
            var scheduling = _repository.Get(id);

            _repository.Remove(scheduling);
            _unitOfWork.Commit();
        }

        public SchedulingOutput Get(int id)
        {
            var scheduling = _repository.Get(id);

            return SchedulingMapping.Map(scheduling);
        }

        public IEnumerable<SchedulingOutput> GetList()
        {
            var schedulings = _repository.Get();

            var schedulingsOutput = schedulings.Select(s => SchedulingMapping.Map(s));

            return schedulingsOutput;
        }

        public void UpdateScheduling(SchedulingInput input, int id)
        {
            var scheduling = SchedulingMapping.Map(input);

            var oldScheduling = _repository.Get(id);

            ValidateScheduling(scheduling);

            oldScheduling.DataHoraFim = scheduling.DataHoraFim;
            oldScheduling.DataHoraInicio = scheduling.DataHoraInicio;
            oldScheduling.Titulo = scheduling.Titulo;
            oldScheduling.IdSala = scheduling.IdSala;

            _repository.Update(oldScheduling);
            _unitOfWork.Commit();
        }
    }
}
