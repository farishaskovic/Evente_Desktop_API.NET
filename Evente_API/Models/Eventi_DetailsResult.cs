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
    
    public partial class Eventi_DetailsResult
    {
        public int EventId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public Nullable<int> MinimumGodine { get; set; }
        public string ObjekatOdrzavanja { get; set; }
        public string Grad { get; set; }
        public string Adresa { get; set; }
        public System.DateTime DatumOdrzavanja { get; set; }
        public bool Status { get; set; }
        public string Kategorija { get; set; }
        public byte[] Slika { get; set; }
    }
}
