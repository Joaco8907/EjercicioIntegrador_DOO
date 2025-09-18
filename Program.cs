namespace EjercicioIntegrador_DOO
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Instancia_de_aplicacion inst_app = new Instancia_de_aplicacion("joaquin", "1", "Windows", 
                0,"joaquin", "lautaro");

            inst_app.cambiarEstado();


            Instancia_de_proceso inst_proceso = new Instancia_de_proceso("joaquin", "1", "Windows",
                0,"java", "10", "java.com");


            inst_proceso.cambiarEstado();


        }
        
    }
}
