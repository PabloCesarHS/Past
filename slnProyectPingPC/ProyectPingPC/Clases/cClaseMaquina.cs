using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectPingPC.Clases
{
    public class cClaseMaquina
    {
        public cClaseMaquina()
        {
        }

        public cClaseMaquina(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; }
    }

    public class cClaseMaquinaFull
    {
        public cClaseMaquinaFull()
        {
        }

        public cClaseMaquinaFull(int nro, string nombre, string iP, string sistemaOperativo, string otros)
        {
            Nro = nro;
            Nombre = nombre;
            IP = iP;
            SistemaOperativo = sistemaOperativo;
            Otros = otros;
        }

        public int Nro { get; set; }
        public string Nombre { get; set; }
        public string IP { get; set; }
        public string SistemaOperativo { get; set; }
        public string Otros { get; set; }
    }

    public class cResultado
    {
        public cResultado()
        {
        }

        public cResultado(int nro, DateTime fechaHoraIni, int duracion, DateTime fechaHoraFin, string concepto, bool estado, string respuesta)
        {
            Nro = nro;
            FechaHoraIni = fechaHoraIni;
            Duracion = duracion;
            FechaHoraFin = fechaHoraFin;
            Concepto = concepto;
            Estado = estado;
            Respuesta = respuesta;
        }

        public cResultado PorDefecto()
        {
            cResultado oResultado = new cResultado();
            oResultado.Nro = 0;
            oResultado.FechaHoraIni = DateTime.Now;
            oResultado.Duracion = 0;
            oResultado.FechaHoraFin = DateTime.Now;
            oResultado.Concepto = "Defecto";
            oResultado.Estado = false;
            oResultado.Respuesta = "Vacio";

            return oResultado;
        }

        public int Nro { get; set; }
        public DateTime FechaHoraIni { get; set; }
        public int Duracion { get; set; }
        public DateTime FechaHoraFin { get; set; }
        public string Concepto { get; set; }
        public bool Estado { get; set; }
        public string Respuesta { get; set; }
    }
}
