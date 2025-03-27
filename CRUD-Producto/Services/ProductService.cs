using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Producto.Interfaces;
using CRUD_Producto.Models;

namespace CRUD_Producto.Services
{
    public class ProductService : IProductService
    {
        private List<Product> productos = new();
        public void AgregarProducto(Product producto)
        {
            productos.Add(producto);
        }

        public Product BuscarPorId(int id)
        {
            return productos.FirstOrDefault(p => p.Id == id);
        }

        public bool EliminarProducto(int id)
        {
            var producto = BuscarPorId(id);
            if (producto != null)
            {
                productos.Remove(producto);
                return true;
            }
            return false;
        }

        public List<Product> ListarProductos() => productos;
    }
}
