using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlquilerAutos
{
    internal class Cliente
    {
        //Atributos (variables o constantes)
        private int idUsuario;
        private string datosBancarios;
        private string direccion;
        private int telefono; 

        //Constructor parametros
        public Cliente(int idUsur, string datBancarios, string direc, int tel)
        {
            this.idUsuario = idUsur;
            this.datosBancarios = datBancarios;
            this.direccion = direc;
            this.telefono = tel;
        }

        //Método
        public int Reservacion(int a)
        {
            int opcion = a;
            int reserva = 0; 
            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Telefonica");
                    reserva = a;
                    break;
                case 2:
                    Console.WriteLine("Online");
                    reserva = a; 
                    break;
                case 3:
                    Console.WriteLine("Presencial");
                    reserva = a;
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;         
            }
            return reserva;
        }
    }
}
