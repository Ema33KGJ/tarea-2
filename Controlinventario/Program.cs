using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

 namespace Controlinventario
{


    internal class Program
    {
        public static int[] id = new int[3]; //codigo del articulo
        public static string[] nombre = new string[3]; // nombre del articulo

        // metodo para inicializar arreglos
        public static void inicializarArreglos() {

            for (int i = 0; i < id.Length; i++)
            {
                id[i] = 0;
                nombre[i] = "";
            }
            Console.ReadKey();
            Console.WriteLine("Los arreglos han sido innicializados");
            Console.Clear();






        }

        // metodo para ingresar productos

        public static void ingresarProductos() {

            int indice = 0;
            while (indice < id.Length) {
                {

                    Console.WriteLine("Digite un codigo:");
                    id[indice] = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite un articulo: ");
                    nombre[indice] = Console.ReadLine();
                    indice++;
                    Console.Clear();



                }

                Console.WriteLine("Los articulos han sido ingresados");

            }
        }
            //metodo para modificar productos

            public static void modificarProductos() {


            Console.Clear();
            Console.Write("Digite el codigo del articulo que desea modificar: ");
            int nuevocodigo = int.Parse(Console.ReadLine());

            for (int i = 0;i < nuevocodigo;i++)

                    if (nuevocodigo == id[i])
                {
                    Console.WriteLine($"codigo:" { }
                }

            }
            public static void ConsultarProducto()
        {
            Console.Clear();
            Console.WriteLine("*** Reporte de los Articulos***");
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine($"Codigo: {id[i]} nombre: {nombre[i]}");

            }
              
            Console.WriteLine("*** FIN DEL REPORTE ***");
        }

            
    }
       