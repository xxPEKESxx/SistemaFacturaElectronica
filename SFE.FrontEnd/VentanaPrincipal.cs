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
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sFE_CostaRicaDataSet1.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.sFE_CostaRicaDataSet1.Inventario);
            // TODO: esta línea de código carga datos en la tabla 'sFE_CostaRicaDataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.sFE_CostaRicaDataSet.Clientes);

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
    }
}
