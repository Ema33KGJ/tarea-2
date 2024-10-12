using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Clase3arreglos
{
    internal class Program
    {
        static float total = 0;              // global 
        static float num1 = 0, num2 = 0;     // variable locales
        static List<Articulo> articulos = new List<Articulo>();
        // los metodos utilizan la palabra reservada void
        static void Main(string[] args)
        {

            menu();

            Console.Read();

        }

        static void menu()
        {
            int opcion = 0;

            try
            {
                do
                {
                    Console.WriteLine("********** menu *************");
                    Console.WriteLine("1- Agregar Articulo");
                    Console.WriteLine("2- Modificar Articulo");
                    Console.WriteLine("3- Borrar Articulo");
                    Console.WriteLine("4- Consultar Articulo");
                    Console.WriteLine("5- Buscar Articulo");
                    Console.WriteLine("6- Facturacion");
                    Console.WriteLine("7- Salir");
                    Console.WriteLine("*****************************");
                    Console.WriteLine("digite una opcion");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                     
                        case 1: AgregarArticulos(); break;
                        case 2: ModificarArticulo(); break;
                        case 3: BorrarArticulo(); break;
                        case 4: ConsultarArticulos(); break;
                        case 5: BuscarArticulo(); break;
                        case 6: Facturar(); break;
                        case 7: break;
                        default:
                        Console.WriteLine("Opcion incorrecta");
                            break;
                     
                    }

                } while (opcion != 3); // false

            }
            catch (Exception)
            {

                Console.WriteLine(" opcion invalidad");
            }
            
        }

        static void AgregarArticulos() { }
        static void ModificarArticulo() { }
        static void BorrarArticulo() { }   
        static int ConsultarArticulos() { }
        static void BuscarArticulo() { }
        static void Facturar() { }
        static void cicloFor()
        {
            static void ModificarArticulo()
            {
                Console.WriteLine("Digite el codigo del articulo a modificar:");
                int codigo = int.Parse(Console.ReadLine());
                Articulo articulo = articulos.Find(a => a.Codigo == codigo);

                if (articulo != null)
                {
                    Console.WriteLine("Digite el nuevo nombre del articulo:");
                    articulo.Nombre = Console.ReadLine();
                    Console.WriteLine("Digite el nuevo precio del articulo:");
                    articulo.Precio = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite la nueva cantidad en la bodega:");
                    articulo.Cantidad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite la nueva bodega:");
                    articulo.Bodega = Console.ReadLine();
                    Console.WriteLine("Articulo modificado con exito.");
                }
                else
                {
                    Console.WriteLine("Articulo no encontrado.");
                }
            }

            static void BorrarArticulo()
            {
                Console.WriteLine("Digite el codigo del articulo a borrar:");
                int codigo = int.Parse(Console.ReadLine());
                Articulo articulo = articulos.Find(a => a.Codigo == codigo);

                if (articulo != null)
                {
                    articulos.Remove(articulo);
                    Console.WriteLine("Articulo borrado con exito.");
                }
                else
                {
                    Console.WriteLine("Articulo no encontrado.");
                }
            }
            static void ConsultarArticulos()
            {
                Console.WriteLine("Lista de articulos:");
                foreach (var articulo in articulos)
                {
                    Console.WriteLine(articulo);
                }
            }
            static void BuscarArticulo()
            {
                Console.WriteLine("Buscar por (1) Codigo o (2) Nombre:");
                int opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("Digite el codigo del articulo:");
                    int codigo = int.Parse(Console.ReadLine());
                    Articulo articulo = articulos.Find(a => a.Codigo == codigo);
                    Console.WriteLine(articulo != null ? articulo.ToString() : "Articulo no encontrado.");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Digite el nombre del articulo:");
                    string nombre = Console.ReadLine();
                    Articulo articulo = articulos.Find(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));
                    Console.WriteLine(articulo != null ? articulo.ToString() : "Articulo no encontrado.");
                }
                else
                {
                    Console.WriteLine("Opcion invalida.");
                }
            }
            static void Facturar()
            {
                // Implementación de facturación
                Console.WriteLine("Método de facturación no implementado.");
            }

        // Clase Articulo
        public class Articulo
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public float Precio { get; set; }
            public int Cantidad { get; set; }
            public string Bodega { get; set; }

            public Articulo(int codigo, string nombre, float precio, int cantidad, string bodega)
            {
                Codigo = codigo;
                Nombre = nombre;
                Precio = precio;
                Cantidad = cantidad;
                Bodega = bodega;
            }

            public override string ToString()
            {
                return $"Codigo: {Codigo}, Nombre: {Nombre}, Precio: {Precio}, Cantidad: {Cantidad}, Bodega: {Bodega}";
            }


        }

        

    }
}
