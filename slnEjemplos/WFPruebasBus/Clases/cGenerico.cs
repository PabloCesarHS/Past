using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFPruebasBus.Clases
{
    public class cGenerico
    {

    }

    public class cResultado
    {
        public int Nro { get; set; }
        public DateTime FechaHoraIni { get; set; }
        public int Duracion { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public string Concepto { get; set; }
        public string Estado { get; set; }
        public string Respuesta { get; set; }
    }

    public class cClientes
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }
}
