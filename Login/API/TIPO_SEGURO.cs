//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API
{
    using System;
    using System.Collections.Generic;
    
    public partial class TIPO_SEGURO
    {
        public TIPO_SEGURO()
        {
            this.SEGURO_VENTA = new HashSet<SEGURO_VENTA>();
        }
    
        public decimal ID { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<SEGURO_VENTA> SEGURO_VENTA { get; set; }
    }
}