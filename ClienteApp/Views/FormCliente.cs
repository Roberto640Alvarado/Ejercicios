using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteApp.Controllers;
using ClienteApp.Models;

namespace ClienteApp.Views
{
    public partial class FormCliente : Form
    {
        private readonly ClienteController controller = new();
        public FormCliente()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtNombre.Clear();
            txtCorreo.Clear();
            txtNombre.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text;
            dgvClientes.DataSource = controller.BuscarPorNombre(nombre);
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvClientes.DataSource = controller.ListarClientes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new()
            {
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text,
                FechaRegistro = DateTime.Now
            };

            controller.AgregarCliente(cliente);
            MessageBox.Show("Cliente agregado.");
            Limpiar();
        }
    }
}
