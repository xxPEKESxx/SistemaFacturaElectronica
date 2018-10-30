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
using SFE.AccesoADatos;
using SFE.LogicaDeNegocio;

namespace SFE.FrontEnd
{
    public partial class VentanaPrincipal : MetroFramework.Forms.MetroForm
    {
        ControladorGeneral controlGeneral = new ControladorGeneral();
        public VentanaPrincipal(String nombreUsuario)
        {
            InitializeComponent();
            metroLabelInfoUsuario.Text = nombreUsuario;
           
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            

          
            metroGridUsuarios.DataSource = controlGeneral.mostrartablaUsuarios();


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

        private void metroTileUsuarioNew_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            ControladorGeneral controlGeneral = new ControladorGeneral();
   
            String confirmaPassword= "";
            
            try {

                usuarios.nombre = metroTextBoxUsuarioNombre.Text;
                usuarios.Apellido = metroTextBoxUsuarioApellidos.Text;
                usuarios.cedula = metroTextBoxUsuarioCedula.Text;
                usuarios.telefono = metroTextBoxUsuariotelefono.Text;
                usuarios.nombreUsuario = metroTextBoxUsuarioNombreUsuario.Text;
                usuarios.password = metroTextBoxUsuarioPassword.Text;
                confirmaPassword = metroTextBoxUsuarioPasswordConfirm.Text;


                if (controlGeneral.IngresarUsuario(usuarios).Equals("Usuario Agregado con exito!!")) {
                    metroGridUsuarios.DataSource = controlGeneral.mostrartablaUsuarios();

                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Usuario agregado con exito!!",
               "Excelente", MessageBoxButtons.OK, MessageBoxIcon.Information);

                } else {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Error inesperado en el ingreso del usuario, Error: " ,
                   "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } catch (Exception excepcion) {

                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Error inesperado en el ingreso del usuario, Error: "+excepcion.ToString(),
               "Error fatal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            

        }

        private void metroTextBoxUsuarioNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void metroTextBoxUsuarioCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else {

                e.Handled = true;
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "En este espacio solo debe de conteber numeros, las letras seran rechazadas " ,
               "Campo especifico para numeros", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroTextBoxUsuarioNombre_Validated(object sender, EventArgs e)
        {
            if (metroTextBoxUsuarioNombre.Text.Trim() == "")
            {

                errorProviderVP.SetError(metroTextBoxUsuarioNombre, "El campo nombre no debe de estar en blanco....");

            }
            else if (metroTextBoxUsuarioApellidos.Text.Trim() == "")
            {

                errorProviderVP.SetError(metroTextBoxUsuarioApellidos, "El campo apellido no debe de estar en blanco....");


            }
            else if (metroTextBoxUsuarioCedula.Text.Trim() == "")
            {

                errorProviderVP.SetError(metroTextBoxUsuarioCedula, "El campo cedula no debe de estar en blanco....");


            }
            else if (metroTextBoxUsuarioNombreUsuario.Text.Trim() == "")
            {

                errorProviderVP.SetError(metroTextBoxUsuarioNombreUsuario, "El campo contraseña no debe de estar en blanco....");


            }
            else if (metroTextBoxUsuariotelefono.Text.Trim() == "")
            {

                errorProviderVP.SetError(metroTextBoxUsuariotelefono, "El campo telefono no debe de estar en blanco....");


            }
            else if (metroTextBoxUsuarioPassword.Text.Trim() == "")
            {

                errorProviderVP.SetError(metroTextBoxUsuarioPassword, "El campo contraseña no debe de estar en blanco....");


            }
            else if (metroTextBoxUsuarioPasswordConfirm.Text.Trim() == "")
            {

                errorProviderVP.SetError(metroTextBoxUsuarioPasswordConfirm, "El campo confirmacion de contraseña no debe de estar en blanco....");


            } else if (!(metroTextBoxUsuarioPasswordConfirm.Text.Equals(metroTextBoxUsuarioPassword.Text))) {


                errorProviderVP.SetError(metroTextBoxUsuarioPassword, "LAS CONTRASEÑAS NO COINCIDEN");
                errorProviderVP.SetError(metroTextBoxUsuarioPasswordConfirm, "la confirmacion de contraseña y la contraseña deben de ser exactamente iguales");





            }
            else {

                errorProviderVP.Clear();
            }
        }
    }
}
