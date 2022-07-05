using System;
using System.Collections.Generic;
using System.Text;

namespace arreglos_y_objetos
{
    class clientes
    {
        //atributos
        public string nombre { set; get; }

        public int identidad { set; get; }

        public string Pdestino { set; get; }

        public string Porigen { set; get; }


        //metodo constructor 
        public clientes()
        {
            nombre = "";
            identidad = 0;
            Pdestino = "";
            Porigen = "";

        }
       
        public void Registrodedatos()
        {
            Console.WriteLine("\n Digite su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("\n Digite el pais de origen: ");
            Porigen = Console.ReadLine();
            Console.WriteLine("\n Digite el pais de destino: ");
            Pdestino = Console.ReadLine();

        }

        public void Ridentidad()
        {
            Console.WriteLine("\n Digite su identidad: ");
            identidad = Convert.ToInt32(Console.ReadLine());
        }
        
       public void Mostrard()
        {
            Console.WriteLine("Nombre: " + nombre + "\nIdentificación: " + identidad + "\nPasis de origén: " + Porigen + "\nPais de destino: " + Pdestino);
        }
    };
}
