//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BP2_VladimirSapundzic
{
    using System;
    using System.Collections.Generic;
    
    public partial class Izdavac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Izdavac()
        {
            this.Knjiga = new HashSet<Knjiga>();
        }
    
        public int IdIzd { get; set; }
        public string NazivIzdavaca { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Knjiga> Knjiga { get; set; }
    }
}