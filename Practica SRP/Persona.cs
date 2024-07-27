
namespace Practica_SRP
{
    // Clase principal que mantiene los datos personales
    public class Persona
    {
        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Direccion { get; set; }
        public string? CorreoElectronico { get; set; }
    }

    // Clase para manejar la impresión de datos
    public class ImpresorDatosPersona
    {
        public void ImprimirDatos(Persona persona)
        {
            Console.WriteLine($"Nombre: {persona.Nombre}");
            Console.WriteLine($"Edad: {persona.Edad}");
            Console.WriteLine($"Dirección: {persona.Direccion}");
            Console.WriteLine($"Correo electrónico: {persona.CorreoElectronico}");
        }
    }

    // Clase para manejar el envío de correos electrónicos
    public class EnviadorCorreo
    {
        public void EnviarCorreo(Persona persona, string mensaje)
        {
            // Lógica para enviar correo electrónico
            Console.WriteLine($"Enviando correo a {persona.CorreoElectronico}: {mensaje}");
        }
    }
}
