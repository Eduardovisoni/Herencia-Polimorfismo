using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class AutoDeCombustión : Vehiculo
    {
        public string sillon { get; set; }
        private int asientos { get; set; }
        public string llantas { get; set; }

        private bool lucesTraserasEncendidas = false;
        protected string modelo { get; set; }

        public AutoDeCombustión(string sillon, int asientos, string modelo, int elAnio, string elColor, string llantas) 
            : base(elAnio, elColor, modelo)
        {
            this.llantas = llantas;
            this.Color = elColor;
            this.sillon = sillon;
            this.asientos = asientos;
            this.modelo = modelo;
        }

        public void InformacionDelCarro()
        {
            Console.WriteLine("\n\n\n--> Informaciones de 'Auto de Combustión':");
            Console.Write("| Sillon: {0} ", this.sillon);
            Console.Write("| Color: {0} ", this.Color);
            Console.Write("| Filas de asientos: {0} ", this.asientos);
            Console.Write("| Llantas: {0} ", this.llantas);
            Console.WriteLine("| Modelo: {0} |\n", this.modelo);

        }
        //----------Sobreescrituras----------

        public override void encender()
        {
            encendido = true;
            Console.WriteLine("El vehículo está encendido.");
            Console.WriteLine("Pantallas TFT del carro: SEJA BEM-VINDO A MAIS UMA VIAJEM!!");
        }

        //----------Sobreescrituras----------

        public override int frenar(int cuanto)
        {
            velocidad -= cuanto;
            if (velocidad < 0)
            {
                velocidad = 0;
            }
            if (velocidad == 0)
            {
                Console.WriteLine("El vehículo está detenido. No se puede frenar.");
                return velocidad;
            }
            lucesTraserasEncendidas = true;
            Console.WriteLine("Ahora, las luces traseras están encendidas.");
            return velocidad;
        }
        public void ApagarLucesTraseras()
        {
            lucesTraserasEncendidas = false;
            Console.WriteLine("Las luces traseras están apagadas.");
        }

        //----------Sobreescrituras----------
        public override int acelerar(int cuanto)
        {
            if (!encendido)
            {
                Console.WriteLine("El vehículo está apagado. No se puede acelerar.");
                return velocidad;
            }

            if (velocidad + cuanto >= 50)
            {
                velocidad += cuanto * 2;
                Console.WriteLine("Con turbo, vas a: {0} KMS/Hora", velocidad);
            }
            else
            {
                velocidad += cuanto;
                Console.WriteLine("Vas a {0} KMS/Hora", velocidad);
            }
            return velocidad;
        }
    }
}
