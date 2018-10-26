using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SFE.AccesoADatos
{
   public  class InicioDeSesion
    {
       
        Usuarios usuario = new Usuarios();

        public Usuarios obtenerUsuario(String nombreUsuario, String cedula, String password) {
            using (SFE_CostaRicaEntities context = new SFE_CostaRicaEntities())
            {
                Usuarios user = null;

                var lista = Listar();

                foreach (Usuarios usuario in lista)
                {
                    if (usuario.cedula.Equals(cedula))
                        user = usuario;
                }

                return user;
            }
        }

        public List<Usuarios> Listar()
        {
            using (SFE_CostaRicaEntities dbcontext = new SFE_CostaRicaEntities())
            {
                var lista = dbcontext.Usuarios.ToList();
                return lista;
            }
        }
        public bool iniciarSesion(String username, String cedula, String password)
        {
            bool existe = false;
            using (SFE_CostaRicaEntities context = new SFE_CostaRicaEntities())
            {
                Usuarios user = null;

                var lista = Listar();

                foreach (Usuarios usuario in lista)
                {
                    if ((usuario.cedula.Equals(cedula)&&usuario.password.Equals(password))|| 
                        (usuario.nombreUsuario.Equals(username) && usuario.password.Equals(password)))
                        user = usuario;
                    existe = true;
                }

                return existe;
            }
        }

        public bool existeUsuario(String cedula)
        {
            bool existe = false;
            using (SFE_CostaRicaEntities context = new SFE_CostaRicaEntities())
            {
                Usuarios user = null;

                var lista = Listar();

                foreach (Usuarios cl in lista)
                {
                    if (cl.cedula.Equals(cedula))
                        user = cl;
                    existe = true;
                }

                return existe;
            }
        }
    }
}
