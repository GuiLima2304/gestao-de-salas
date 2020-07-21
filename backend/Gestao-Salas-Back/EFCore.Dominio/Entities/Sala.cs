using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.Dominio.Entities
{
    public class Sala
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Status { get; set; }
        public virtual IEnumerable<Agendamento> Agendamentos { get; set; }
    }

    //OBS: Um agendamento contem apenas uma sala, mas uma sala pode conter muitos agendamentos
}
