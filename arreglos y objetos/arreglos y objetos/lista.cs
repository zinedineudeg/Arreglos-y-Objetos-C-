using System;
using System.Collections.Generic;
using System.Text;

namespace arreglos_y_objetos
{
    class lista
    {// atributos
        public clientes[] datos; //Arreglo
        public int Rdatos; //Variable que me contara cuantos datos tengo en el arreglo
       


        public lista() {//constructor
            Rdatos = 0;
            Console.WriteLine("Cuantas personas va a ingresar al arreglo");
            Rdatos = Convert.ToInt32(Console.ReadLine());
            datos = new clientes[Rdatos]; 

        }
        //metodos
        public void adatos()
        {
            int i, j;
           
            bool encontrado = false;

            for (i = 0; i < Rdatos; i++)
            {
                datos[i] = new clientes();
                datos[i].identidad = 0; 
            }
            clientes clientes1 = new clientes(); //objeto
            for (i = 0; i < Rdatos; i++)
            {

                encontrado = false;
                Console.WriteLine("\n Cliente numero: " + i);
                clientes1.Ridentidad();
                for (j = 0; j < Rdatos; j++)
                {
                    if (clientes1.identidad == datos[j].identidad)
                    {
                        encontrado = true;
                        i--;
                        break;
                    }
                }
                if (encontrado == true)
                {
                    Console.WriteLine("\n La indentidad ya ha sido registrada, digite una nueva");

                }
                else
                {
                    clientes1.Registrodedatos();
                   
                    datos[i].nombre = clientes1.nombre;
                    datos[i].identidad = clientes1.identidad;
                    datos[i].Porigen = clientes1.Porigen;
                    datos[i].Pdestino = clientes1.Pdestino;
                    Console.WriteLine("\nDatos agrgados correctamente ☺");
                    Console.WriteLine("\n Oprima enter para continuar");
                    Console.ReadKey();

                }
                

            }
           

        }

           public void Mostrardatos()
           {
            
           
            
            for (int i = 0; i < Rdatos; i++) {
                Console.WriteLine("\n cliente numero: " + i);
                datos[i].Mostrard();
             
            }
            Console.WriteLine("\n Oprima enter para continuar");
            Console.ReadKey();
        
           }
        public void buscarid(int id)
        {
            
            
            for (int i = 0; i < Rdatos; i++)
            {
                if (id == datos[i].identidad)
                {

                    Console.WriteLine("\nDatos encontrados ");
                    Console.WriteLine("\ncliente numero: " + i);
                    datos[i].Mostrard();
                }
            }
            Console.WriteLine("\n Oprima enter para continuar");
            Console.ReadKey();
        }
        
       
        
    }
    
}
