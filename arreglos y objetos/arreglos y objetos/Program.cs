using System;

namespace arreglos_y_objetos
{
    class Program
    {
        static void Main(string[] args) 
        { 
           lista lista1 = new lista();
            
           
            int num = 0;
            while (num != 4)
            {
                Console.WriteLine("\n---------- ♣ BIENVENIDO ♣ ----------");
                Console.WriteLine("\nMENU");
                Console.WriteLine("1. Agregar");
                Console.WriteLine("2. Mostrar");
                Console.WriteLine("3. Buscar");
                Console.WriteLine("4. Salir");
                Console.WriteLine("");
                Console.WriteLine("Digite una opcion");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        {
                            Console.WriteLine("\n---------- ♣ AGREGAR DATOS ♣ ----------");
                            lista1.adatos();
                           
                        }
                        
                        break;
                       
                    case 2:
                        {
                            Console.WriteLine("\n---------- ♣ LISTA ♣ ----------");
                            lista1.Mostrardatos();
                           
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("\n---------- ♣ BUSQUEDA ♣ ----------");
                            Console.WriteLine("\nDigite el numero  de identidad a buscar");
                            int ident = 0;
                            ident = Convert.ToInt32(Console.ReadLine());
                            lista1.buscarid(ident);
                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine("\n---------- ♣  ♣ ----------");
                            Console.WriteLine("\n ♥♥♥ Gracias por escoger nuestro servicio ♥♥♥");
                            Console.WriteLine("\n Oprima enter para salir");
                            Console.ReadKey();

                        }
                        break;

                }

            }







        }
    }
}
