//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CFPPE.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class archivospizarronma
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public archivospizarronma()
        {
            this.detallepizarron = new HashSet<detallepizarron>();
        }
    
        public int idAP { get; set; }
        public int idMaestro { get; set; }
        public string Titulo { get; set; }
        public System.DateTime FechaCracion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<detallepizarron> detallepizarron { get; set; }
        public virtual maestros maestros { get; set; }
    }
}