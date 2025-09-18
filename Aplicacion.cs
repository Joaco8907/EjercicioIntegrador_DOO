using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador_DOO
{
    public abstract class Aplicacion
    {
        protected string nombre { get; set; }
        protected string version { get; set; }
        protected string sistema_operativa { get; set; }
        protected int estado { get; set; }

        public Aplicacion(string nombre, string version, string sistema_operativa, int estado)
        {
            this.nombre = nombre;
            this.version = version;
            this.sistema_operativa = sistema_operativa;
            this.estado = estado;
        }

        public Aplicacion()
        {
        }

        public abstract void cambiarEstado();
    }
}
