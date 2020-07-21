using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Dominio.Entities
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public virtual Sala Sala { get; set; }
        public int IdSala { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
    }
}
