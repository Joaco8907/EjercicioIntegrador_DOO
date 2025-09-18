using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador_DOO
{
    public  class Instancia_de_proceso : Aplicacion, IVerificacion
    {
        private string lenguaje_de_programacion { get; set; }
        private string version_de_lenguaje { get; set; }
        private string URL_bd { get; set; }
        public Instancia_de_proceso()
        {
        }

        public Instancia_de_proceso(string nombre, string version, string sistema_operativa, 
            int estado, string lenguaje_de_programacion, string version_de_lenguaje, string URL_bd ) 
            : base(nombre, version, sistema_operativa, estado)
        {
            this.lenguaje_de_programacion = lenguaje_de_programacion;
            this.version_de_lenguaje = version_de_lenguaje;
            this.URL_bd = URL_bd;
        }

        public override void cambiarEstado()
        {
            if (verificarAcceso())
            {
                Console.WriteLine("Levantando estado a 1");
                estado = 1;
            }
            else
            {
                estado = 0;
            }
        }

        public bool verificarAcceso()
        {
            Console.WriteLine("Ingrese el lenguaje de programacion: ");
            string lenguaje_ingresado = Console.ReadLine();

            Console.WriteLine("Ingrese la version de lenguaje: ");
            string version_ingresada = Console.ReadLine();
            
            Console.WriteLine("Ingrese la URL: ");
            string URL_ingresada = Console.ReadLine();

            if (lenguaje_ingresado.Equals(lenguaje_de_programacion) && version_ingresada.Equals(version_de_lenguaje)
                && URL_bd.Equals(URL_bd))
            {
                Console.WriteLine($"Lenguaje isntalado {lenguaje_de_programacion}, version: {version_de_lenguaje}" +
                    $", URL de la base de datos: {URL_bd} Correctos");
                return true;
            }
            else
            {
                Console.WriteLine("Acceso denegado");
                return false;
            }
        }
    }
}
