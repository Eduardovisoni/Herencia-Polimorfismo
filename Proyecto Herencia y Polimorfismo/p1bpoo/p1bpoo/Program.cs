
using p1bpoo.MisClases;
using System;

namespace p1boo
{
    class Program
    {
        static void Main(string[] args)
        {

            Vehiculo elOtro = new Vehiculo(2000, "Rojo", "DELOREAN");
            elOtro.InformacionVehiculo();
            elOtro.encender();
            elOtro.acelerar(0);
            elOtro.frenar(20);
            elOtro.Apagar();

            AutoDeCombustión oCombustion = new AutoDeCombustión("Sillon de Cuero", 2, "Chevrolet Camaro", 2019, "Rojo vino", "Michellin");
            oCombustion.InformacionDelCarro();
            oCombustion.encender();
            oCombustion.acelerar(51);
            oCombustion.frenar(30);
            oCombustion.Apagar();
            oCombustion.ApagarLucesTraseras();


            Motocicleta oMotocicleta = new Motocicleta("ABS", "Seis Cilindros", "BMW K1600", 2018, "Rojo", "Telescópica y Tijera (brazo oscilante)");
            oMotocicleta.InformacionDeMoto();
            oMotocicleta.encender();
            oMotocicleta.acelerar(150); //override   
            oMotocicleta.frenar(140, "trasera"); //override
            oMotocicleta.Apagar();

            Camión oCamion = new Camión("Carga", "Volvo", "VNL 860", 2020, "Blanco", "Diurna");
            oCamion.InformacionDeCamión();
            oCamion.encender();
            oCamion.acelerar(23);
            oCamion.frenar(1, "disco");
            oCamion.Apagar();

            //Vehiculo miCarrito = new Vehiculo(2026, "Azul", "Alfa Romeo");
            //CarroElectrico miBYD = new CarroElectrico(2026, "Amarillo", "BYD");
            //miBYD.InformacionVehiculo();
            //Console.WriteLine("El nivel de bateria es: {0}",miBYD.NivelBateria());
            //miBYD.cargarBateria();
        }
    }
}

