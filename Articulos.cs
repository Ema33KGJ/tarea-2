using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlInventario
{
    
    internal class Articulos
    {
        public static int[] id = new int[3];            // codigo del articulo
        public static string[] nombre = new string[3];  // nombre del articulo

        // metodo para inicializar arreglos
        public static void inicializarArreglos() {

            for (int i = 0; i < id.Length; i++)
            {
                id[i] = 0;
                nombre[i] = "";
            }
            Console.WriteLine("Los arreglos han sido inicializados");
            Console.Clear();

        }

        // metodo para ingresar productos
        public static void ingresarProductos() {
            Console.Clear();
            int indice = 0;
            while (indice<id.Length) {

                Console.Write("Digite un codigo: ");
                id[indice] = int.Parse(Console.ReadLine());
                Console.Write("Digite un articulo: ");
                nombre[indice] = Console.ReadLine();
                indice++;
                Console.Clear() ;
            }
            Console.WriteLine("Los articulos han sido ingresados");
        }

        // metodo para modificar productos
        public static void modificarProductos() {

            Console.Clear();
            Console.Write("Digite el codigo del articulo que desea modificar: ");
            int nuevocodigo = int.Parse(Console.ReadLine()) ;

            for (int i = 0; i < id.Length; i++)
            {
                if (nuevocodigo == id[i])
                {
                    Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]}");
                    Console.Write("Digite un nombre: ");
                    nombre[i] = Console.ReadLine();
                    break;
                }
             
            }

        }

        // metodo para consultar productos
        public static void consultarProductos() {
            Console.Clear ();
            Console.WriteLine("*** REPORTE DE ARTICULOS ***");
            for (int i = 0; i < id.Length; i++)
            {
                Console.WriteLine($"Codigo: {id[i]} Nombre: {nombre[i]}");
            }
            Console.WriteLine("*** FIN DEL REPORTE ***");
        }

        // metodo para eliminar productos
        public static void excluirProductos() { }

       
    }
}
