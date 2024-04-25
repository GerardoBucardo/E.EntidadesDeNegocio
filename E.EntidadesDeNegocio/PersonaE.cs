using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E.EntidadesDeNegocio
{
    public class PersonaE
    {
        public int Id { get; set; }
        public string? NombreE { get; set; }
        public string? ApellidoE { get; set; }
        public DateTime FechaNacimientoE { get; set; }
        public decimal SueldoE { get; set; }
        public string? EstatusE { get; set; }
        public string? ComentarioE { get; set; }
    }
}
