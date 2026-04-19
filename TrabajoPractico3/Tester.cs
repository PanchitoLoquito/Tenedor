using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    internal class Tester
    {
        static void Main(string[] args)
        {
            Tenedor tenedor = new Tenedor(5);

            Console.WriteLine("=== TEST TENEDOR ===");

            Console.WriteLine("Vida inicial: " + tenedor.ObtenerVida());

            tenedor.RecibirDaño(50);
            Console.WriteLine("Vida despues de recibir daño: " + tenedor.ObtenerVida());

            int vidaJugador = 100;
            tenedor.Ataque(vidaJugador);
            Console.WriteLine("Vida jugador despues de ataque: " + vidaJugador);

            Console.WriteLine("Probando seguir jugador...");
            tenedor.SeguirJugador(0);

            Console.WriteLine("Forzando muerte...");
            tenedor.Muerte();

            Console.WriteLine("=== FIN TEST ===");
        }
    }
    
}
