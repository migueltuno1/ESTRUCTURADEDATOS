using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using dominios;
namespace gestiones
{
    public class COLA_CITAS
    {
        private int id_cola;
        private List<Cita> cita;
        private string estado;

        public COLA_CITAS(int id_cola, List<Cita> cita, string estado)
        {
            this.id_cola = id_cola;
            this.cita = cita;
            this.estado = estado;
        }

        public List<Cita> Cita { get => cita; set => cita = value; }
        public int Id_cola { get => id_cola; set => id_cola = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
