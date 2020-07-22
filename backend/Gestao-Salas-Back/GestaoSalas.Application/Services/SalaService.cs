using EFCore.Dominio;
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
    public class SalaService : ISalaService
    {
        private readonly IRoomRepository _repository;
        private readonly IUnitOfWork _unitOfWork;

        public SalaService(IRoomRepository roomRepository, IUnitOfWork unitOfWork)
        {
            _repository = roomRepository;
            _unitOfWork = unitOfWork;
        }

        public void AddNewRoom(RoomInput input)
        {
            var room = RoomMapping.Map(input);

            _repository.Add(room);
            _unitOfWork.Commit();
        }

        public void DeleteRoom(int id)
        {
            var room = _repository.Get(id);

            _repository.Remove(room);
            _unitOfWork.Commit();
        }

        public RoomOutput Get(int id)
        {
            var room = _repository.Get(id);

            return RoomMapping.Map(room);
        }

        public IEnumerable<RoomOutput> GetList()
        {
            var room = _repository.Get();

            var roomOutput = room.Select(s => RoomMapping.Map(s));

            return roomOutput;
        }

        public void UpdateRoom(RoomInput input, int id)
        {
            var room = RoomMapping.Map(input);

            var oldRoom = _repository.Get(id);

            oldRoom.Nome = room.Nome;
            oldRoom.Descricao = room.Descricao;

            _repository.Update(oldRoom);
            _unitOfWork.Commit();
        }
    }
}
