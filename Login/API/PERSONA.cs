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
    
    public partial class PERSONA
    {
        public PERSONA()
        {
            this.CONTRATO = new HashSet<CONTRATO>();
            this.OFERTA_PROCESO_VENTA = new HashSet<OFERTA_PROCESO_VENTA>();
            this.OFERTA_SUSBASTA = new HashSet<OFERTA_SUSBASTA>();
        }
    
        public decimal RUT { get; set; }
        public string RUT_DV { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string EMAIL { get; set; }
        public decimal PERFIL_ID { get; set; }
    
        public virtual ICollection<CONTRATO> CONTRATO { get; set; }
        public virtual LOGIN LOGIN { get; set; }
        public virtual ICollection<OFERTA_PROCESO_VENTA> OFERTA_PROCESO_VENTA { get; set; }
        public virtual ICollection<OFERTA_SUSBASTA> OFERTA_SUSBASTA { get; set; }
        public virtual PERFIL PERFIL { get; set; }
    }
}