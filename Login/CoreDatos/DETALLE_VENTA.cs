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
    
    public partial class DETALLE_VENTA
    {
        public decimal COSTO_TRANSPORTE { get; set; }
        public decimal IMPTO_ADUANERO { get; set; }
        public decimal PAGO_SERVICIO { get; set; }
        public decimal COMISION_EMP { get; set; }
        public decimal VENTA_ID_PROCESO { get; set; }
        public decimal VENTA_ID_VENTA { get; set; }
    
        public virtual VENTA VENTA { get; set; }
    }
}
