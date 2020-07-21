using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoSalas.Application.Models.Outputs
{
    public class SchedulingOutput
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int RoomId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string RoomName { get; set; }
    }
}
