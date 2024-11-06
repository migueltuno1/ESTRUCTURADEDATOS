using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominios
{
    internal class Consulta
    {
        private int idConsulta;
        private string descripcion;
        private double precio;
        private DateTime hora;
        private Medico medicoEncargado;
        private Paciente pacienteReserva;
        private string estado;

        public Consulta(int idConsulta, string descripcion, double precio, DateTime hora, Medico medicoEncargado, Paciente pacienteReserva, string estado)
        {
            this.idConsulta = idConsulta;
            this.descripcion = descripcion;
            this.precio = precio;
            this.hora = hora;
            this.medicoEncargado = medicoEncargado;
            this.pacienteReserva = pacienteReserva;
            this.estado = estado;
        }

        public int IdConsulta { get => idConsulta; set => idConsulta = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public double Precio { get => precio; set => precio = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public Medico MedicoEncargado { get => medicoEncargado; set => medicoEncargado = value; }
        public Paciente PacienteReserva { get => pacienteReserva; set => pacienteReserva = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
