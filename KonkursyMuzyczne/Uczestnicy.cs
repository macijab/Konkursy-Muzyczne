//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KonkursyMuzyczne
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uczestnicy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uczestnicy()
        {
            this.UczestnicyEdycji = new HashSet<UczestnicyEdycji>();
        }
    
        public int IDUczestnika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Narodowosc { get; set; }
        public System.DateTime DataUrodzenia { get; set; }
        public string Instrument { get; set; }
        public string Plec { get; set; }
        public byte[] Zdjecie { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UczestnicyEdycji> UczestnicyEdycji { get; set; }
    }
}
