//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class OFERTA_SUBASTA
    {
        public decimal ID_OFERTA { get; set; }
        public decimal PRECIO { get; set; }
        public decimal PERSONA_RUT { get; set; }
        public decimal SUBASTA_TRANSPORTE_ID_SUBASTA { get; set; }
    
        public virtual PERSONA PERSONA { get; set; }
        public virtual SUBASTA_TRANSPORTE SUBASTA_TRANSPORTE { get; set; }
    }
}
