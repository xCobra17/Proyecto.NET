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
    
    public partial class DETALLE_OFERTA
    {
        public decimal PROCESO_VENTA_ID_PROCESO { get; set; }
        public decimal OFERTA_VENTA_ID_OFERTA { get; set; }
    
        public virtual OFERTA_VENTA OFERTA_VENTA { get; set; }
    }
}
