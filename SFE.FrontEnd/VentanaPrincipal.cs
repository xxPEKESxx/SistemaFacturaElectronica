using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace SFE.FrontEnd
{
    public partial class VentanaPrincipal : MetroFramework.Forms.MetroForm
    {
        public VentanaPrincipal(String nombreUsuario)
        {
            InitializeComponent();
            metroLabelInfoUsuario.Text = nombreUsuario;
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sFE_CostaRicaDataTablas.facturaElectronica' Puede moverla o quitarla según sea necesario.
            this.facturaElectronicaTableAdapter.Fill(this.sFE_CostaRicaDataTablas.facturaElectronica);
            // TODO: esta línea de código carga datos en la tabla 'sFE_CostaRicaDataTablas.ListaProductos' Puede moverla o quitarla según sea necesario.
            this.listaProductosTableAdapter.Fill(this.sFE_CostaRicaDataTablas.ListaProductos);
            // TODO: esta línea de código carga datos en la tabla 'sFE_CostaRicaDataTablas.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sFE_CostaRicaDataTablas.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'sFE_CostaRicaDataTablas.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.sFE_CostaRicaDataTablas.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'sFE_CostaRicaDataTablas.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.sFE_CostaRicaDataTablas.Usuarios);
        }

        private void tabSalir_Click(object sender, EventArgs e)
        {

            DialogResult dr= MetroFramework.MetroMessageBox.Show(this, "DESEA SALIR DEL SISTEMA??",
                "Salir del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr==DialogResult.Yes) {

                Application.Exit();
                
            }
        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void VentanaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroGridClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroGridUsuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
