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
    
    public partial class UczestnicyEdycji
    {
        public int IDEdycjiKonkursu { get; set; }
        public int IDUczestnika { get; set; }
        public Nullable<int> EtapUczestnika { get; set; }
        public string ZajeteMiejsce { get; set; }
        public string Nagroda { get; set; }
    
        public virtual EdycjeKonkursu EdycjeKonkursu { get; set; }
        public virtual Uczestnicy Uczestnicy { get; set; }
    }
}
