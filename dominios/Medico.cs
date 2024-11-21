using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominios
{
    public class Medico
    {
        private int idDoctor;
        private string nombreDoctor;
        private string apellidosDoctor;
        private string cI_Doctor;
        private string especialidad;

        public Medico(int idDoctor, string nombreDoctor, string apellidosDoctor, string cI_Doctor, string especialidad)
        {
            this.idDoctor = idDoctor;
            this.nombreDoctor = nombreDoctor;
            this.apellidosDoctor = apellidosDoctor;
            this.cI_Doctor = cI_Doctor;
            this.especialidad = especialidad;
        }

        public int IdDoctor { get => idDoctor; set => idDoctor = value; }
        public string NombreDoctor { get => nombreDoctor; set => nombreDoctor = value; }
        public string ApellidosDoctor { get => apellidosDoctor; set => apellidosDoctor = value; }
        public string CI_Doctor { get => cI_Doctor; set => cI_Doctor = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }

    }

    public class designar
    {
        private int num;

        public int Num { get => num; set => num = value; }
        public string designarr(int codigo)
        {
            this.num = num;
           
            string codigos="";

            switch (codigo)
            {
                case 1:
                    Medico doctor1 = new Medico(1, "DR. JON OSCAR", "PAREDES BURGOA", "1234567", "TRAUMATOLOGO");
                    codigos = doctor1.ToString();
                    break;
                case 2:
                    Medico doctor2 = new Medico(2, "DR. RODRIGO", " JORDAN SALVATIERRA", "987456", "NEUROLOGO");
                    codigos = doctor2.ToString(); 
                    break;
                case 3:
                    Medico doctor3 = new Medico(3, "DR. DIEGO", "ARTEAGA RIVERO", "123698", "TRAUMATOLOGO");
                    codigos = doctor3.ToString();
                    break;
                case 4:
                    Medico doctor4 = new Medico(3, "DR. JOSE", "DUMAY", "745632", "CARDIOLOGO");
                    codigos = doctor4.ToString();
                    break;
                default:
                    break;
            }
        return codigos;

        }

        
    }
}
