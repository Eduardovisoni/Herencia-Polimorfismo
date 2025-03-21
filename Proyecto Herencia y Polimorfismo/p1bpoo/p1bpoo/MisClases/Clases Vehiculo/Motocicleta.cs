using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class Motocicleta : Vehiculo
    {
        public string frenos { get; set; }
        private string motor { get; set; }
        protected string modelo { get; set; }
        protected string suspension { get; set; }

        public Motocicleta(string frenos, string motor, string modelo, int elAnio, string elColor, string suspension)
            : base(elAnio, elColor, modelo)
        {
            this.frenos = frenos;
            this.motor = motor;
            this.modelo = modelo;
            this.suspension = suspension;
        }

        public void InformacionDeMoto()
        {
            Console.WriteLine("\n\n\n--> Informaciones de 'Motocicleta': ");
            Console.Write("| Frenos: {0} ", this.frenos);
            Console.Write("| Motor: {0} ", this.motor);
            Console.Write("| Suspension: {0} ", this.suspension);
            Console.WriteLine("| Modelo: {0} |", this.modelo);
        }
        //----------Sobreescrituras----------

        public override void encender()
        {
            encendido = true;
            Console.WriteLine("La motocicleta está encendida.");
            Console.WriteLine("Pantallas TFT de la moto: BIENVENUE DANS UN AUTRE VOYAGE!!");
        }

        //----------Sobreescrituras----------
        public override int acelerar(int cuanto)
        {
            int incremento = cuanto * 2;
            velocidad += incremento;
            Console.WriteLine("La motocicleta es mas rapida, va a {0} KMS/Hora", velocidad);
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

            if (llanta.ToLower() == "delantera")
            {
                Console.WriteLine("Frenando con la llanta delantera. Vas a {0} KMS/Hora", velocidad);
            }
            else if (llanta.ToLower() == "trasera")
            {
                Console.WriteLine("Frenando con la llanta trasera. Vas a {0} KMS/Hora", velocidad);
            }
            else
            {
                Console.WriteLine("Llanta no especificada correctamente. Vas a {0} KMS/Hora", velocidad);
            }
            return velocidad;
        }
    }
}
