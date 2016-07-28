//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityProyecto
{
    using System;
    using System.Collections.Generic;
    
    public partial class AsientosDeItinerarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AsientosDeItinerarios()
        {
            this.Maletas = new HashSet<Maletas>();
        }
    
        public long IDAsientoDeItinerario { get; set; }
        public short Numero { get; set; }
        public string TipoDeAsiento { get; set; }
        public decimal Precio { get; set; }
        public string Fila { get; set; }
        public short MaximodeMaletasGratis { get; set; }
        public long IDOrdenDeCompra { get; set; }
        public long IDItinerario { get; set; }
        public long IDPasajero { get; set; }
    
        public virtual Itinerarios Itinerarios { get; set; }
        public virtual OrdenesDeCompras OrdenesDeCompras { get; set; }
        public virtual Pasajeros Pasajeros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maletas> Maletas { get; set; }
    }
}
