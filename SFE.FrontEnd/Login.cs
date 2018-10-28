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
using SFE.LogicaDeNegocio;
using SFE.AccesoADatos;


namespace SFE.FrontEnd
{
   
    public partial class Login : MetroFramework.Forms.MetroForm
    {
       string username = " ";
      
        VentanaPrincipal entraSistema;
        SFE_CostaRicaEntities db;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {



        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonInicioSesion_Click(object sender, EventArgs e)
        {




            
            String cedula = " ", password = " ";
            ControladorGeneral controlgeneral = new ControladorGeneral();
            cedula = LogincampoTextoUser.Text;
            username = LogincampoTextoUser.Text;
            password = LogincampoTextoPassword.Text;
            entraSistema = new VentanaPrincipal(username);
            if (!((LogincampoTextoUser.Text.Equals("")) || (LogincampoTextoUser.Text.Equals(null))))
            {

                if (!((LogincampoTextoPassword.Text.Equals("")) || (LogincampoTextoPassword.Text.Equals(null))))
                {

                    if (controlgeneral.iniciarSesion(username,password)) {
                        entraSistema.Visible = true;
                       
                        Visible = false;
                    } else {

                        DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Problemas en la convinacion de credenciales, la contraseña o el nombre de usario no coinciden, " +
                            "intente llenar los campos con datos ya registrados en el sistema. ",
             "ERROR EN AUTENTIFICACION ", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }



                }
                else
                {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this,  "Asegurese de que el campo de contraseña no este en blanco",
               "Los campos no deben estar en blanco  ", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }
            else
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this,  "Asegurese de llenar el campo de nombre de usuario, ya sea con la cedula o el nombre de usuario",
           "Los campos no deben estar en blanco??", MessageBoxButtons.OK, MessageBoxIcon.Error);









            }
        }
    }
}
