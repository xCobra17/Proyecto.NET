//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDeDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class CALIDAD_FRUTA
    {
        public CALIDAD_FRUTA()
        {
            this.OFERTA_PROCESO_VENTA = new HashSet<OFERTA_PROCESO_VENTA>();
        }
    
        public string CALIDAD { get; set; }
    
        public virtual ICollection<OFERTA_PROCESO_VENTA> OFERTA_PROCESO_VENTA { get; set; }
    }
}
