using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using ClienteApp.Models;
using System.Data;
namespace ClienteApp.Controllers
{
    public class ClienteController
    {
        private readonly string connectionString = "Server=DESKTOP-4EL52T1\\SQLEXPRESS;Database=ClienteDB;Trusted_Connection=True;";

        public void AgregarCliente(Cliente cliente)
        {
            using SqlConnection conn = new(connectionString);
            conn.Open();
            string query = "INSERT INTO Clientes (Nombre, Correo, FechaRegistro) VALUES (@Nombre, @Correo, @Fecha) ";
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
            cmd.Parameters.AddWithValue("@Fecha", cliente.FechaRegistro);
            cmd.ExecuteNonQuery();
        }

        public List<Cliente> ListarClientes()
        {
            List<Cliente> lista = new();
            using SqlConnection conn = new(connectionString);
            conn.Open();
            string query = "SELECT * FROM Clientes";

            using SqlCommand cmd = new(query, conn);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Cliente
                {
                    Id = (int)reader["Id"],
                    Nombre = reader["Nombre"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    FechaRegistro = (DateTime)reader["FechaRegistro"]
                });
            }
            return lista;
        }

        public List<Cliente> BuscarPorNombre(string nombre)
        {
            List<Cliente> lista = new();
            using SqlConnection conn = new(connectionString);
            conn.Open();
            string query = "SELECT * FROM Clientes WHERE Nombre LIKE @Nombre";
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@Nombre", $"%{nombre}%");
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Cliente
                {
                    Id = (int)reader["Id"],
                    Nombre = reader["Nombre"].ToString(),
                    Correo = reader["Correo"].ToString(),
                    FechaRegistro = (DateTime)reader["FechaRegistro"]
                });
            }
            return lista;
        }
    }
}
