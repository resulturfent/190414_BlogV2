//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _190413_ProjeV1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Yorumlar
    {
        public int YorumlarID { get; set; }
        public Nullable<int> UyeID { get; set; }
        public Nullable<System.DateTime> YorumTarihi { get; set; }
        public Nullable<int> YorumBegenme { get; set; }
        public Nullable<int> YorumBegenmeme { get; set; }
        public Nullable<int> YorumUstID { get; set; }
        public string Baslik { get; set; }
        public string Yorumicerik { get; set; }
        public Nullable<int> MakaleID { get; set; }
    
        public virtual Makaleler Makaleler { get; set; }
        public virtual Uyeler Uyeler { get; set; }
    }
}
