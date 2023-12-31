//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PaGaApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Zlecenie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Zlecenie()
        {
            this.Uslugas = new HashSet<Usluga>();
        }
    
        public int IdZlecenia { get; set; }
        public int IdKlienta { get; set; }
        public int IdSamochodu { get; set; }
        public System.DateTime Data_Przyjecia { get; set; }
        public Nullable<System.DateTime> Data_Zamkniecia { get; set; }
        public Nullable<double> Koszt_Zlecenia { get; set; }
        public int IdPracownika { get; set; }
        public bool Czyzakończone { get; set; }
    
        public virtual Klient Klient { get; set; }
        public virtual Pracownik Pracownik { get; set; }
        public virtual Samochod Samochod { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usluga> Uslugas { get; set; }
    }
}
