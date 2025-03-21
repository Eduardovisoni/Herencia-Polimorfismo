using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Vehiculo
    {
        protected string Color { get; set; }
        protected string Modelo { get; set; }
        protected int Year { get; set; }

        protected int velocidad = 0;

        protected bool encendido = false;


        public Vehiculo(int elAnio, string elColor, string elModelo)
        {
            this.Color = elColor;
            this.Modelo = elModelo;
            this.Year = elAnio;
        }

        public void InformacionVehiculo()
        {
            Console.Write("--> Informaciones de 'Vehiculo':");
            Console.Write("\n| Color: {0} |", this.Color);
            Console.Write(" Modelo: {0} |", this.Modelo);
            Console.Write(" Año: {0} |\n\n", this.Year);
        }
        //Métodos de Vehiculos
        public virtual int acelerar(int cuanto)
        {
            if (!encendido)
            {
                Console.WriteLine("El vehículo está apagado. No se puede acelerar.");
                return velocidad;
            }

            velocidad += cuanto;
            Console.WriteLine("Vas a {0} KMS/Hora", velocidad);
            return velocidad;
        }
        public virtual int frenar(int cuanto)
        {
            if (!encendido)
            {
                Console.WriteLine("El vehículo está apagado. No se puede frenar.");
                return velocidad;
            }

            velocidad -= cuanto;
            if (velocidad < 0)
            {
                velocidad = 0;
            }
            Console.WriteLine("Vas a {0} KMS/Hora", velocidad);
            return velocidad;
        }
        public virtual void encender()
        {
            if (encendido)
            {
                Console.WriteLine("El vehículo ya está encendido.");
                return;
            }

            else
            {
                encendido = true;
                Console.WriteLine("El vehículo está encendido.");
            }
        }
        public virtual void Apagar()
        {
            if (!encendido)
            {
                Console.WriteLine("El vehículo ya está apagado.");
                return;
            }
            else
            {
                encendido = false;
                velocidad = 0;
                Console.WriteLine("El vehiculo freno a {0} y el vehiculo se apago", this.velocidad);
            }
        }
    }
}
