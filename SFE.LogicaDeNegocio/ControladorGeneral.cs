using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SFE.AccesoADatos;

namespace SFE.LogicaDeNegocio
{
    public class ControladorGeneral
    {
        GestorDeUsuarios usuarios = new GestorDeUsuarios();
        public bool iniciarSesion(String username, String password, String cedula)
        {


            InicioDeSesion iniciarSesion = new InicioDeSesion();


            return iniciarSesion.iniciarSesion(username, password, cedula);
        }

        public String IngresarUsuario(Usuarios usuario)
        {
            return usuarios.ingresarUsuario(usuario);
        }

        public List<Usuarios> mostrartablaUsuarios() {

            return usuarios.mostrarUsuarios();
        }
    }
}
