﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SFE.AccesoADatos
{
   public  class InicioDeSesion
    {
        private SFE_CostaRicaEntities db = new SFE_CostaRicaEntities();
        Usuarios usuario = new Usuarios();

        public Usuarios obtenerUsuario(String nombreUsuario, String cedula, String password) {
         
            
                Usuarios user = null;

                var lista = Listar();

                foreach (Usuarios usuario in lista)
                {
                    if (usuario.cedula.Equals(cedula))
                        user = usuario;
                }

                return user;
            
        }

        public List<Usuarios> Listar()
        {
          
                var lista = db.Usuarios.ToList();
                return lista;
            
        }
        public bool iniciarSesion(String username, String password,String cedula)
        {
            bool existe = false;
            
             var lista = Listar();
            if (existeUsuario( username, password,cedula)) {
                existe = true;
            }


                return existe;
            
        }

        public bool existeUsuario(String username, String Password,String cedula)
        {
            bool existe = false;
        
               Usuarios user = null;

                var lista = Listar();

                foreach (Usuarios users in lista)
                {
                if (users.nombreUsuario.Equals(username)||users.cedula.Equals(cedula) && (users.password.Equals(Password))) {

                    user = users;
                    existe = true;
                }
                     
                }

                return existe;
            
        }
    }
}
