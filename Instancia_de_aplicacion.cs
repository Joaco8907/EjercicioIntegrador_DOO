using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegrador_DOO
{
    public class Instancia_de_aplicacion : Aplicacion, IVerificacion
    {
        private string datos_de_origen { get; set; }
        private string datos_de_fin { get; set; }
        public Instancia_de_aplicacion()
        {
        }

        public Instancia_de_aplicacion(string nombre, string version, string sistema_operativa, int estado, string datos_de_origen, string datos_de_fin) : base(nombre, version, sistema_operativa, estado)
        {
            this.datos_de_fin = datos_de_fin;
            this.datos_de_origen = datos_de_origen;
        }

        public override void cambiarEstado()
        {
            if (verificarAcceso())
            {
                Console.WriteLine("Levantando estado a 1");
                estado = 1;
            }
            else {
                estado = 0;
            }
        }

        public bool verificarAcceso()
        {
            Console.WriteLine("Ingrese los datos de origen: ");
            string datos_origen_ingresado = Console.ReadLine();
            Console.WriteLine("Ingrese los datos de fin: ");
            string datos_fin_ingresado = Console.ReadLine();

            if (datos_de_origen.Equals(datos_de_origen) && datos_fin_ingresado.Equals(datos_de_fin))
            {
                Console.WriteLine($"Posee acceso a {datos_de_origen} y a {datos_de_fin}");
                return true;
            }
            else
            {
                Console.WriteLine("Acceso denegado");
                return false;
            }
        }

        public void clonar() {
            Console.WriteLine("Clonando repositorio...");
            Console.WriteLine("Repositorio clonado...");
        }

        public void filtrar() {
            Console.WriteLine("filtrando datos.....");
        }

        public void almacenar() {
            Console.WriteLine("Almacenando datos....");
        } 
    }
}
