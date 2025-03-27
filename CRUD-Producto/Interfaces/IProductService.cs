using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD_Producto.Models;

namespace CRUD_Producto.Interfaces
{
    public interface IProductService
    {
        void AgregarProducto(Product producto);
        List<Product> ListarProductos();
        Product BuscarPorId(int id);
        bool EliminarProducto(int id);
    }
}
