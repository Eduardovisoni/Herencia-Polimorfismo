using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Camión : Vehiculo
    {
        private string tipo { get; set; }
        private string marca { get; set; }
        protected string modelo { get; set; }
        public string cabina { get; set; }
        public Camión(string tipo, string marca, string modelo, int elAnio, string elColor, string cabina)
            : base(elAnio, elColor, modelo)
        {
            this.cabina = cabina;
            this.tipo = tipo;
            this.marca = marca;
            this.modelo = modelo;
        }
        public void InformacionDeCamión()
        {
            Console.WriteLine("\n\n\n--> Informaciones de 'Camion': ");
            Console.Write("| Tipo: {0} ", this.tipo);
            Console.Write("| Marca: {0} ", this.marca);
            Console.Write("| Cabina: {0} ", this.cabina);
            Console.WriteLine("| Modelo: {0} |", this.modelo);
        }
        //----------Sobreescrituras----------

        public override void encender()
        {
            encendido = true;
            Console.WriteLine("El camion está encendido.");
            Console.WriteLine("Pantallas TFT del camion: BIENVENIDO A OTRO VIAJE!!");
        }


        //----------Sobreescrituras----------

        public override int acelerar(int cuanto)
        {
            int incremento = cuanto / 2;
            velocidad += incremento;
            Console.WriteLine("El camion es mas lento, va a {0} KMS/Hora", velocidad);
            return velocidad;
        }

        //----------Sobreescrituras----------

        public int frenar(int cuanto, string llanta)
        {
            velocidad -= cuanto;
            if (velocidad < 0)
            {
                velocidad = 0;
            }

            if (llanta.ToLower() == "disco")
            {
                Console.WriteLine("Usando freno con disco. Vas a {0} KMS/Hora", velocidad);
            }
            else if (llanta.ToLower() == "aire")
            {
                Console.WriteLine("Usando freno de aire. Vas a {0} KMS/Hora", velocidad);
            }
            else if (llanta.ToLower() == "motor")
            {
                Console.WriteLine("Usando freno de motor. Vas a {0} KMS/Hora", velocidad);
            }
            else
            {
                Console.WriteLine("Freno no especificada correctamente. Vas a {0} KMS/Hora", velocidad);
            }
                return velocidad;
        }
    }
}
