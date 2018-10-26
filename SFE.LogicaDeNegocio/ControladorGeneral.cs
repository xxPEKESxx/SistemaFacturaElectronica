using System;
using FacturaElectronicaCR_CS.ClasesDatos;

using SFE.AccesoADatos;

namespace SFE.LogicaDeNegocio
{
    public class ControladorGeneral
    {

        public bool iniciarSesion(String username,String password) {
         

            InicioDeSesion iniciarSesion = new InicioDeSesion();

           
            return iniciarSesion.iniciarSesion(username, password); ;
        }


    }
}
