//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Evente_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KorisniciUloge
    {
        public int KorisnikUlogaId { get; set; }
        public int KorisnikId { get; set; }
        public int UlogaId { get; set; }
        public System.DateTime DatumIzmjene { get; set; }
    
        public virtual Korisnici Korisnici { get; set; }
        public virtual Uloge Uloge { get; set; }
    }
}
