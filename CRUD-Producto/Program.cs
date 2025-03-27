using CRUD_Producto.Interfaces;
using CRUD_Producto.Models;
using CRUD_Producto.Services;
using CRUD_Producto.Utils;

class Program
{
    static void Main()
    {
        IProductService servicio = new ProductService();

        bool salir = false;

        while (!salir)
        {
            Console.Clear();
            Console.WriteLine("=== GESTIÓN DE PRODUCTOS ===");
            Console.WriteLine("1. Agregar producto");
            Console.WriteLine("2. Listar productos");
            Console.WriteLine("3. Buscar producto por ID");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            switch(opcion)
            {
                case "1":
                    var producto = new Product
                    {
                        Id = InputHelper.LeerEntero("ID: "),
                        Nombre = InputHelper.LeerTexto("Nombre: "),
                        Precio = InputHelper.LeerDecimal("Precio: "),
                        Stock = InputHelper.LeerEntero("Stock: ")
                    };
                    servicio.AgregarProducto(producto);
                    Console.WriteLine("Producto agregado correctamente.");
                    break;
                case "2":
                    var lista = servicio.ListarProductos();
                    if (lista.Count == 0)
                        Console.WriteLine("No hay productos registrados.");
                    else
                    {
                        foreach (var p in lista)
                        {
                            Console.WriteLine($"ID: {p.Id}, Nombre: {p.Nombre}, Precio: {p.Precio}, Stock: {p.Stock}");
                        }
                    }
                    break;
                case "3":
                    int idBuscado = InputHelper.LeerEntero("Ingrese el ID del producto: ");
                    var encontrado = servicio.BuscarPorId(idBuscado);
                    if (encontrado == null)
                        Console.WriteLine("Producto no encontrado.");
                    else
                        Console.WriteLine($"ID: {encontrado.Id}, Nombre: {encontrado.Nombre}, Precio: {encontrado.Precio}, Stock: {encontrado.Stock}");
                    break;
                case "4":
                    int idEliminar = InputHelper.LeerEntero("Ingrese el ID a eliminar: ");
                    if (servicio.EliminarProducto(idEliminar))
                        Console.WriteLine("Producto eliminado.");
                    else
                        Console.WriteLine("No se encontró el producto.");
                    break;
                case "5":
                    salir = true;
                    break;

                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
