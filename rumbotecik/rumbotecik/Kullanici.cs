//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rumbotecik
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            this.Blogs = new HashSet<Blog>();
        }
    
        public byte KullaniciID { get; set; }
        public string KullaniciAdSoyad { get; set; }
        public System.DateTime KullaniciDogumTarihi { get; set; }
        public string KullaniciEposta { get; set; }
        public string KullaniciParola { get; set; }
        public string KullaniciFotoUrl { get; set; }
        public Nullable<System.DateTime> KullaniciKayitTarih { get; set; }
        public Nullable<System.DateTime> KullaniciKayitSilmeTarih { get; set; }
        public bool KullaniciAktif { get; set; }
        public byte KullaniciYetki { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blog> Blogs { get; set; }
    }
}
