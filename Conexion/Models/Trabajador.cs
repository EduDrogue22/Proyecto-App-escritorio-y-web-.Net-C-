//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Conexion.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Trabajador
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trabajador()
        {
            this.Servicio = new HashSet<Servicio>();
        }
    
        public int ID_trabajador { get; set; }
        public string dni_trabajador { get; set; }
        public string primer_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string celular { get; set; }
        public string contacto_de_emergencia { get; set; }
        public bool disponible { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servicio> Servicio { get; set; }
    }
}