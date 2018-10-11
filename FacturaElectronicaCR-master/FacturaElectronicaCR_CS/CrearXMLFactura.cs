using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FacturaElectronicaCR_CS
{
    public partial class CrearXMLFactura : Form
    {
        List<ClasesDatos.DetallesFactura> detallesFactura = new List<ClasesDatos.DetallesFactura>();
        public CrearXMLFactura()
        {
            InitializeComponent();
        }

        private void agregarDetalle_Click(object sender, EventArgs e)
        {
            ClasesDatos.DetallesFactura nuevoDetalle = new ClasesDatos.DetallesFactura();
            nuevoDetalle.articuloCodigo =txtCodigoArticulo.Text;
            nuevoDetalle.articuloTipo ="";
            nuevoDetalle.cantidad =txtCantidadKg.Text;
            nuevoDetalle.codigoImpuesto ="";
            nuevoDetalle.detalle =txtDetalleFactura.Text;
            nuevoDetalle.impuestoMonto ="";
            nuevoDetalle.impuestoTarifa ="";
            nuevoDetalle.montoDescuento = "0.00000";
            nuevoDetalle.montoTotal ="";
            nuevoDetalle.montoTotalLinea =txtTotalLinea.Text;
            nuevoDetalle.natualezaDescuento = "Descuento al cliente";
            nuevoDetalle.numeroLinea ="";
            nuevoDetalle.precioUnitario ="";
            nuevoDetalle.subtotal ="";
            nuevoDetalle.unidadDeMedida ="";

            detallesFactura.Add(nuevoDetalle);

            MessageBox.Show("Agregado correctamente");

        }

        private void finalizarFactura_Click(object sender, EventArgs e)

        {

            FacturaElectronicaCR_CS.ClasesDatos.Emisor nuevoEmisor = new ClasesDatos.Emisor("nombre","tipo de id","numero id","Guancaste","Liberia","Liberia","Capulin","100 metros sur","506",61894100,"ejemplo@gmail.com");
            FacturaElectronicaCR_CS.ClasesDatos.Receptor nuevoReceptor = new ClasesDatos.Receptor("nombre","tipo identificacion","numero id","Guancaste","liberia","liberia","la victoria","100 norte","506",1234,"otroejemplo@gmail.com");


     FacturaElectronicaCR_CS.ClasesDatos.FacturaElectronicaCR nuevaFactura = new ClasesDatos.FacturaElectronicaCR("numero consecutivo","numero clave",nuevoEmisor,nuevoReceptor,"condicion venta","plazo credito","medioPago",detallesFactura,"CRC",1);


   

            boxTexto.Text = GetXMLAsString(nuevaFactura.CreaXMLFacturaElectronica());

        }
        public string GetXMLAsString(XmlDocument myxml)
        {
            return myxml.OuterXml;
        }

    }
}
