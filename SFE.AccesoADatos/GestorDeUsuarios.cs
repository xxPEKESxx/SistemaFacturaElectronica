using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;




namespace SFE.AccesoADatos
{
    public class GestorDeUsuarios
    {
        SFE_CostaRicaEntities conexion = new SFE_CostaRicaEntities();
        Usuarios usuario = new Usuarios();

        String mensaje = "";
      


       


        public String ingresarUsuario(Usuarios usuario) {
       
            String mensaje = "";

            try {
                    conexion.Usuarios.Add(usuario);
                conexion.SaveChanges();
                
                mensaje = "Usuario Agregado con exito!!";
            } catch (Exception excepcion) {

                mensaje = "Problema con la conecion a la base de datos: "+excepcion.ToString();
            }


                return mensaje;

        }
        public void eliminaUsuario(String cedula) { }
        public void filtrarUsuario(String cedula) { }


        public List<Usuarios> mostrarUsuarios()

        {
            try {

                using (SFE_CostaRicaEntities conexionBaseDatos = new SFE_CostaRicaEntities())
                {

                    var listar = (from n in conexionBaseDatos.Usuarios
                                  select n).ToList();

                    return listar;
                }
            } catch (Exception) {

                throw;
                    }
        
             

         
            
        }
        
    }
}
