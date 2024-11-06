using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominios
{
    public class Cita
    {
        private int idCita;
        private DateTime fechaDeCita;
        private Paciente paciente;
        private Medico medico;
        private Consulta consulta;
        private string estado;

        public Cita(int idCita, DateTime fechaDeCita, Paciente paciente, Medico medico, Consulta consulta, string estado)
        {
            this.idCita = idCita;
            this.fechaDeCita = fechaDeCita;
            this.paciente = paciente;
            this.medico = medico;
            this.consulta = consulta;
            this.estado = estado;
        }

        public int IdCita { get => idCita; set => idCita = value; }
        public DateTime FechaDeCita { get => fechaDeCita; set => fechaDeCita = value; }
        public Paciente Paciente { get => paciente; set => paciente = value; }
        public Medico Medico { get => medico; set => medico = value; }
        public string Estado { get => estado; set => estado = value; }
        internal Consulta Consulta { get => consulta; set => consulta = value; }
    }
}
