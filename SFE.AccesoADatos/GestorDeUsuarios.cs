using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SFE.AccesoADatos
{
    public class GestorDeUsuarios
    {
        SFE_CostaRicaEntities conexion = new SFE_CostaRicaEntities();
        Usuarios usuario = new Usuarios();

        
        
        public void ingresarUsuario(Usuarios usuario) {}
        public void eliminaUsuario(String cedula) { }
        public void filtrarUsuario(String cedula) { }
        public void mostrarUsuarios() {}
        
    }
}
