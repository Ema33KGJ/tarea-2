using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlinventario
{
    internal class menu

        //menu principal
    {

        public static void principal()
        {

            int opcion = 0;

            do
            {
                Console.WriteLine("1- Inicializar arreglos");
                Console.WriteLine("2- Ingresar Articulos");
                Console.WriteLine("3- Modificar Articulos");
                Console.WriteLine("4- Borrar Articulos");
                Console.WriteLine("5- Consultar Articulos");
                Console.WriteLine("6- Salir");
                Console.WriteLine("Digite una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1: Program.inicializarArreglos(); break;
                    case 2:;break;
                    case 3:;break;
                    case 4:;break;
                    case 5:; break;
                    case 6:;Console.WriteLine("Saliendo del sistema") break;
                    default: Console.WriteLine("*** Opcion incorecta ***"); break;


                }

            }
            while (opcion != 6); // mientras oppcion sea diferente de 6==> true

        }
    }
}
