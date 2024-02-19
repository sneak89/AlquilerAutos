using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    internal class Agencia
    {
        //Atributos 
        public string nombreEmpresa;
        public int telefono;
        public int noCuentaBancaria;

        //Constructor
        public Agencia()
        {

        }

        //métodos
        public void AlquilerDeAutos()
        {
            Console.WriteLine("Estas llamando al método alquiler de autos");
        }
    }
}
