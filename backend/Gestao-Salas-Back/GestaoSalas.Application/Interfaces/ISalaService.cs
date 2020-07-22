using GestaoSalas.Application.Models.Inputs;
using GestaoSalas.Application.Models.Outputs;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoSalas.Application.Interfaces
{
    public interface ISalaService
    {
        void AddNewRoom(RoomInput room);
        void UpdateRoom(RoomInput room, int id);
        void DeleteRoom(int id);
        IEnumerable<RoomOutput> GetList();
        RoomOutput Get(int id);
    }
}
