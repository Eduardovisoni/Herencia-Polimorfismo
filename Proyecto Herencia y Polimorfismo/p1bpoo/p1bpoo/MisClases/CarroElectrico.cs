using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p1bpoo.MisClases
{
    public class CarroElectrico : Vehiculo
    {
        private int cargaBateria;
        public CarroElectrico(int anio, string elColor, string elModelo) : base (anio, elColor, elModelo)
        {
            cargaBateria = 60;
        }
        public override int acelerar(int cuanto)
        {
            int velocidadActual = base.acelerar(cuanto);
            cargaBateria--;
            return velocidadActual;
        }
        public int NivelBateria() { return cargaBateria; }
        public void cargarBateria()
        {
            cargaBateria++;
        }


    }
}
