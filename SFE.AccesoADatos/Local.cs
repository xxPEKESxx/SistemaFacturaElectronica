//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SFE.AccesoADatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Local
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Local()
        {
            this.facturaElectronica = new HashSet<facturaElectronica>();
        }
    
        public int idLocal { get; set; }
        public int tipoIdentificacion { get; set; }
        public string nombre { get; set; }
        public string area { get; set; }
        public string faxTelefono { get; set; }
        public string web { get; set; }
        public string provincia { get; set; }
        public string email { get; set; }
        public int IdUser { get; set; }
        public string claveCritografica { get; set; }
        public string passwordHacienda { get; set; }
        public byte[] numeroIdentificacion { get; set; }
        public string canton { get; set; }
        public string distrito { get; set; }
        public string barrio { get; set; }
        public string ubicacionOtrasSenas { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<facturaElectronica> facturaElectronica { get; set; }
        public virtual Usuarios Usuarios { get; set; }
    }
}