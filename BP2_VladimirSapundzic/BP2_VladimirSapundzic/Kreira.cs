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
    
    public partial class Kreira
    {
        public int Id { get; set; }
        public int AdministratorIdKor { get; set; }
    
        public virtual Administrator Administrator { get; set; }
        public virtual Administrator KreiranAdministrator { get; set; }
    }
}