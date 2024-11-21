using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            
    }







    //creamos los pacientes directamente para hacer la prueba

    public class pacientetes
    {
        private string cedula;

        public  string pcliente(string cedula)
        {
            this.cedula = cedula;
            string datos = "";
            string ci;
            switch (cedula)
            {
                case "14205561":datos = "14205561";
                    break;

                case "14205560":datos = "14205560";
                    break;

                case "5706488":datos = "57064886";
                    break;
            }
            return datos;
        }

        public string Cdula { get => cedula; set => cedula = value; }
       
    }

}

