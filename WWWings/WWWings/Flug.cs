//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WWWings
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flug
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Flug()
        {
            this.Passagier = new HashSet<Passagier>();
        }
    
        public int Id { get; set; }
        public string Abflugort { get; set; }
        public string Zielort { get; set; }
        public System.DateTime Datum { get; set; }
        public short Plaetze { get; set; }
        public short FreiePlaetze { get; set; }
        public int PilotId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Passagier> Passagier { get; set; }
        public virtual Pilot Pilot { get; set; }
    }
}