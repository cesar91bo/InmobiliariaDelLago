//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class TiposPagos
    {
        public TiposPagos()
        {
            this.CajasMovimientosDetalle = new HashSet<CajasMovimientosDetalle>();
            this.PagosDetalle = new HashSet<PagosDetalle>();
            this.RecibosDetalle = new HashSet<RecibosDetalle>();
        }
    
        public short IdTipoPago { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<CajasMovimientosDetalle> CajasMovimientosDetalle { get; set; }
        public virtual ICollection<PagosDetalle> PagosDetalle { get; set; }
        public virtual ICollection<RecibosDetalle> RecibosDetalle { get; set; }
    }
}
