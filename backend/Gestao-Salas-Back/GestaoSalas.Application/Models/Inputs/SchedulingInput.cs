using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoSalas.Application.Models.Inputs
{
    public class SchedulingInput
    {
        public string Title { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
