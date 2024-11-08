﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominios
{
    public class Paciente
    {
        private int idPaciente;
        private String nombrePaciente;
        private String apellidoPaciente;
        private String cI_Paciente;
        private DateTime fechaNac_Paciente;

        public Paciente(int idPaciente, string nombrePaciente, string apellidoPaciente, string cI_Paciente, DateTime fechaNac_Paciente)
        {
            this.idPaciente = idPaciente;
            this.nombrePaciente = nombrePaciente;
            this.apellidoPaciente = apellidoPaciente;
            this.cI_Paciente = cI_Paciente;
            this.fechaNac_Paciente = fechaNac_Paciente;
        }

        public int IdPaciente { get => idPaciente; set => idPaciente = value; }
        public string NombrePaciente { get => nombrePaciente; set => nombrePaciente = value; }
        public string ApellidoPaciente { get => apellidoPaciente; set => apellidoPaciente = value; }
        public string CI_Paciente { get => cI_Paciente; set => cI_Paciente = value; }
        public DateTime FechaNac_Paciente { get => fechaNac_Paciente; set => fechaNac_Paciente = value; }






        //creamos los pacientes directamente para hacer la prueba
        public String nombre1 = "Miguel";
        public String nombre2 = "Maximo";
        public String nombre3 = "Emerson";

        Paciente paciente1 = new Paciente(1, "Miguel", "Tuno Loayza", "14205561", DateTime.Parse("17-06-2005"));
        Paciente paciente2 = new Paciente(1, "Maximo", "Tuno Loayza", "14205560", DateTime.Parse("29-06-2005"));
        Paciente paciente3 = new Paciente(1, "Emerson", "Cabral Moreno", "9478236", DateTime.Parse("19-02-2005"));
    }
}
