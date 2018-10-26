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
            
            

         
                VentanaPrincipal entraSistema = new VentanaPrincipal();
                String username = " ", cedula=" ",password=" ";
                ControladorGeneral controlgeneral = new ControladorGeneral();
               cedula = LogincampoTextoUser.Text;
                username = LogincampoTextoUser.Text;
                password = LogincampoTextoPassword.Text;

                if (controlgeneral.iniciarSesion(username,cedula,password))
                {
                    entraSistema.Visible = true;
                    Login login = new Login();
                    Visible = false;
                    
                }
                else {
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Error en las credenciales de inicio de sesion??",
               "Verifique que la contraseña o el nombre de usuario esten bien escritos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    
                }

           
            
        }
    }
}
