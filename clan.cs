//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GYM
{
    using System;
    using System.Collections.Generic;
    
    public partial class clan
    {
        public string IDClana { get; set; }
        public string datumRodj { get; set; }
        public string datumUpisa { get; set; }
    
        public virtual osoba osoba { get; set; }
        public virtual rezultati rezultati { get; set; }
    }
}
