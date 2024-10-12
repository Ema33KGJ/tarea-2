using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea__2
{
    internal class Articulos
    {
    }

namespace ControlInventario
    {
        internal class Articulo
        {
            public int Codigo { get; set; }
            public string Nombre { get; set; }
            public decimal Precio { get; set; }
            public int Cantidad { get; set; }
            public string Bodega { get; set; }
        }

        internal class Inventario
        {
            public static Articulo[] articulos = new Articulo[3];

            public static void InicializarArreglos()
            {
                for (int i = 0; i < articulos.Length; i++)
                {
                    articulos[i] = new Articulo();
                }
                Console.WriteLine("Los arreglos han sido inicializados");
                Console.Clear();
            }

            public static void IngresarProductos()
            {
                Console.Clear();
                for (int i = 0; i < articulos.Length; i++)
                {
                    Console.Write("Digite un codigo: ");
                    articulos[i].Codigo = int.Parse(Console.ReadLine());

                    Console.Write("Digite un nombre: ");
                    articulos[i].Nombre = Console.ReadLine();

                    Console.Write("Digite un precio: ");
                    articulos[i].Precio = decimal.Parse(Console.ReadLine());

                    Console.Write("Digite la cantidad: ");
                    articulos[i].Cantidad = int.Parse(Console.ReadLine());

                    Console.Write("Digite la bodega: ");
                    articulos[i].Bodega = Console.ReadLine();

                    Console.Clear();
                }
                Console.WriteLine("Los articulos han sido ingresados");
            }

            public static void ModificarProductos()
            {
                Console.Clear();
                Console.Write("Digite el codigo del articulo que desea modificar: ");
                int codigo = int.Parse(Console.ReadLine());

                for (int i = 0; i < articulos.Length; i++)
                {
                    if (codigo == articulos[i].Codigo)
                    {
                        Console.WriteLine($"Codigo: {articulos[i].Codigo}, Nombre: {articulos[i].Nombre}, Precio: {articulos[i].Precio}, Cantidad: {articulos[i].Cantidad}, Bodega: {articulos[i].Bodega}");
                        Console.Write("Digite un nuevo nombre: ");
                        articulos[i].Nombre = Console.ReadLine();

                        Console.Write("Digite un nuevo precio: ");
                        articulos[i].Precio = decimal.Parse(Console.ReadLine());

                        Console.Write("Digite una nueva cantidad: ");
                        articulos[i].Cantidad = int.Parse(Console.ReadLine());

                        Console.Write("Digite una nueva bodega: ");
                        articulos[i].Bodega = Console.ReadLine();
                        Console.WriteLine("Articulo modificado con éxito.");
                        return;
                    }
                }

                Console.WriteLine("Codigo no encontrado.");
            }

            public static void ConsultarProductos()
            {
                Console.Clear();
                Console.WriteLine("*** REPORTE DE ARTICULOS ***");
                foreach (var articulo in articulos)
                {
                    Console.WriteLine($"Codigo: {articulo.Codigo}, Nombre: {articulo.Nombre}, Precio: {articulo.Precio}, Cantidad: {articulo.Cantidad}, Bodega: {articulo.Bodega}");
                }
                Console.WriteLine("*** FIN DEL REPORTE ***");
            }

            public static void ExcluirProductos()
            {
                Console.Clear();
                Console.Write("Digite el codigo del articulo que desea excluir: ");
                int codigoAExcluir = int.Parse(Console.ReadLine());

                for (int i = 0; i < articulos.Length; i++)
                {
                    if (codigoAExcluir == articulos[i].Codigo)
                    {
                        articulos[i] = new Articulo(); // Reinicia el objeto
                        Console.WriteLine("Articulo excluido con éxito.");
                        return;
                    }
                }

                Console.WriteLine("Codigo no encontrado. No se ha excluido ningún articulo.");
            }

            public static void BuscarArticulo()
            {
                Console.Clear();
                Console.WriteLine("Buscar por:\n1. Código\n2. Nombre");
                int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1)
                {
                    Console.Write("Digite el codigo del articulo a buscar: ");
                    int codigo = int.Parse(Console.ReadLine());
                    foreach (var articulo in articulos)
                    {
                        if (articulo.Codigo == codigo)
                        {
                            Console.WriteLine($"Encontrado: Codigo: {articulo.Codigo}, Nombre: {articulo.Nombre}, Precio: {articulo.Precio}, Cantidad: {articulo.Cantidad}, Bodega: {articulo.Bodega}");
                            return;
                        }
                    }
                    Console.WriteLine("Articulo no encontrado.");
                }
                else if (opcion == 2)
                {
                    Console.Write("Digite el nombre del articulo a buscar: ");
                    string nombre = Console.ReadLine();
                    foreach (var articulo in articulos)
                    {
                        if (articulo.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Encontrado: Codigo: {articulo.Codigo}, Nombre: {articulo.Nombre}, Precio: {articulo.Precio}, Cantidad: {articulo.Cantidad}, Bodega: {articulo.Bodega}");
                            return;
                        }
                    }
                    Console.WriteLine("Articulo no encontrado.");
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
        }
    }
}
}
