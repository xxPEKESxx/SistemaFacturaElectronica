//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFE.FrontEnd
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListaProductos
    {
        public int idListaProductos { get; set; }
        public int numeroConsecutivoDeFactura { get; set; }
        public string codigo { get; set; }
        public string tipoCodigo { get; set; }
        public string descrpcionCorta { get; set; }
        public string descripcionLarga { get; set; }
        public string unidad { get; set; }
        public double costoCompra { get; set; }
        public double precioVenta { get; set; }
        public int agregarImpuesto { get; set; }
        public int idFacturaElectronica { get; set; }
    
        public virtual facturaElectronica facturaElectronica { get; set; }
    }
}
