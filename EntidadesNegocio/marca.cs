//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntidadesNegocio
{
    using System;
    using System.Collections.Generic;
    
    public partial class marca
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public marca()
        {
            this.arma = new HashSet<arma>();
            this.armaExplosiva = new HashSet<armaExplosiva>();
            this.vehiculo = new HashSet<vehiculo>();
        }
    
        public long id_marca { get; set; }
        public string nombre { get; set; }
        public Nullable<long> idClasificacion_Fk { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arma> arma { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<armaExplosiva> armaExplosiva { get; set; }
        public virtual clasificacion clasificacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<vehiculo> vehiculo { get; set; }
    }
}
