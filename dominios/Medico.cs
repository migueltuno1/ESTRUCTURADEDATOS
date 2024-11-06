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



        // crear medicos

        Medico doctor1 = new Medico(1, "Zora", "Loayza", "478952", "Medicina General");
        Medico doctor2 = new Medico(2, "Leandro", "Tuno Loayza", "123456", "Odontologo");
        Medico doctor3 = new Medico(3, "Maikol", "Rivero", "986354", "Traumatologia");

    }
}
