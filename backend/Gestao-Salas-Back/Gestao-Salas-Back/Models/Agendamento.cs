using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_Salas_Back.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Sala Sala { get; set; }
        public int IdSala { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
    }
}
