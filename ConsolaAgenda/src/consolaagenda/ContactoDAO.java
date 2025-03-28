/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */

package consolaagenda;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;
/**
 *
 * @author Roberto05Alv
 */
public class ContactoDAO {
    private final String url = "jdbc:sqlserver://DESKTOP-4EL52T1\\SQLEXPRESS;databaseName=AgendaDB;integratedSecurity=true;trustServerCertificate=true;";
    
    public void probarConexion() {
        try (Connection conn = DriverManager.getConnection(url)) {
            if (conn != null) {
                System.out.println("Conexión exitosa con autenticación de Windows.");
            }
        } catch (SQLException e) {
            System.out.println("Error de conexión:");
            e.printStackTrace();
        }
    }

    // Agregar nuevo contacto
    public void agregarContacto(Contacto c) {
        String sql = "INSERT INTO Contactos (Nombre, Telefono, Email) VALUES (?, ?, ?)";
        try (Connection conn = DriverManager.getConnection(url);
             PreparedStatement stmt = conn.prepareStatement(sql)) {

            stmt.setString(1, c.getNombre());
            stmt.setString(2, c.getTelefono());
            stmt.setString(3, c.getEmail());
            stmt.executeUpdate();
            System.out.println("✔ Contacto agregado.");
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }

    // Buscar por ID
    public Contacto buscarPorId(int id) {
        String sql = "SELECT * FROM Contactos WHERE Id = ?";
        try (Connection conn = DriverManager.getConnection(url);
             PreparedStatement stmt = conn.prepareStatement(sql)) {

            stmt.setInt(1, id);
            ResultSet rs = stmt.executeQuery();
            if (rs.next()) {
                Contacto c = new Contacto();
                c.setId(rs.getInt("Id"));
                c.setNombre(rs.getString("Nombre"));
                c.setTelefono(rs.getString("Telefono"));
                c.setEmail(rs.getString("Email"));
                return c;
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return null;
    }

    // Listar todos los contactos
    public List<Contacto> listarTodos() {
        List<Contacto> lista = new ArrayList<>();
        String sql = "SELECT * FROM Contactos";
        try (Connection conn = DriverManager.getConnection(url);
             Statement stmt = conn.createStatement();
             ResultSet rs = stmt.executeQuery(sql)) {

            while (rs.next()) {
                Contacto c = new Contacto();
                c.setId(rs.getInt("Id"));
                c.setNombre(rs.getString("Nombre"));
                c.setTelefono(rs.getString("Telefono"));
                c.setEmail(rs.getString("Email"));
                lista.add(c);
            }
        } catch (SQLException e) {
            e.printStackTrace();
        }
        return lista;
    }

    // Eliminar por ID
    public void eliminarPorId(int id) {
        String sql = "DELETE FROM Contactos WHERE Id = ?";
        try (Connection conn = DriverManager.getConnection(url);
             PreparedStatement stmt = conn.prepareStatement(sql)) {

            stmt.setInt(1, id);
            int filas = stmt.executeUpdate();
            if (filas > 0)
                System.out.println("Contacto eliminado.");
            else
                System.out.println("No se encontró un contacto con ese ID.");
        } catch (SQLException e) {
            e.printStackTrace();
        }
    }
    
}
