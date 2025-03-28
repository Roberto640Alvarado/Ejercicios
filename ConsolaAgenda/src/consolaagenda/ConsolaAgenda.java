/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package consolaagenda;

import java.util.Scanner;

/**
 *
 * @author Roberto05Alv
 */
public class ConsolaAgenda {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        ContactoDAO dao = new ContactoDAO();
        Scanner sc = new Scanner(System.in);
        int opcion;
        
        do {
            System.out.println("\n=== AGENDA DE CONTACTOS ===");
            System.out.println("1. Agregar contacto");
            System.out.println("2. Buscar por ID");
            System.out.println("3. Listar todos");
            System.out.println("4. Eliminar por ID");
            System.out.println("5. Salir");
            System.out.print("Opción: ");
            opcion = sc.nextInt();
            sc.nextLine(); // limpiar buffer

            switch (opcion) {
                case 1 -> {
                    Contacto c = new Contacto();
                    System.out.print("Nombre: ");
                    c.setNombre(sc.nextLine());
                    System.out.print("Teléfono: ");
                    c.setTelefono(sc.nextLine());
                    System.out.print("Email: ");
                    c.setEmail(sc.nextLine());
                    dao.agregarContacto(c);
                }
                case 2 -> {
                    System.out.print("ID: ");
                    int id = sc.nextInt();
                    Contacto c = dao.buscarPorId(id);
                    if (c != null)
                        System.out.println(c.getId() + " | " + c.getNombre() + " | " + c.getTelefono() + " | " + c.getEmail());
                    else
                        System.out.println("No se encontró el contacto.");
                }
                case 3 -> {
                    for (Contacto c : dao.listarTodos()) {
                        System.out.println(c.getId() + " | " + c.getNombre() + " | " + c.getTelefono() + " | " + c.getEmail());
                    }
                }
                case 4 -> {
                    System.out.print("ID a eliminar: ");
                    int id = sc.nextInt();
                    dao.eliminarPorId(id);
                }
                case 5 -> System.out.println("Adiós");
                default -> System.out.println("Opción inválida.");
            }

        } while (opcion != 5);

        sc.close();
        
        
    }
    
}
