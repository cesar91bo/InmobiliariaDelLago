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
    
    public partial class FormasPago
    {
        public FormasPago()
        {
            this.FacturasCompra = new HashSet<FacturasCompra>();
            this.FacturasVenta = new HashSet<FacturasVenta>();
        }
    
        public short IdFormaPago { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<FacturasCompra> FacturasCompra { get; set; }
        public virtual ICollection<FacturasVenta> FacturasVenta { get; set; }
    }
}