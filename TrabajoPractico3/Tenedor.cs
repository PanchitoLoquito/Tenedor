using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3
{
    internal class Tenedor
    {
        int vida = 50;
        int velocidad;
        int position; //lo hago un entero pq no existe Vector2 en C# base
        int daño;
        int sala;

        public Tenedor(int position)
        {
            this.position = position;
        }

        public void Muerte()
        {
            //quequefree(); al no ser una entidad no se puede eliminar
            Console.WriteLine("Muerto");
        }

        public void Ataque(int vidajugador)
        {
            vidajugador = vidajugador - daño;
        }

        public void RecibirDaño(int dañojugador)
        {
            vida = vida - dañojugador;
        }
        
        public void SeguirJugador(int salajugador)
        {
            if (salajugador == sala)
            {
                Console.WriteLine("Tenedor comenzo a seguirte");
            }
        }

        public int ObtenerVida()
        {
            return vida;
        }

        public int ObtenerSala()
        {
            return sala;
        }
    }
}
