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
    
    public partial class RemitosDetalleCompra
    {
        public long IdRemitoDetalleCompra { get; set; }
        public int IdRemitoCompra { get; set; }
        public long IdArticulo { get; set; }
        public decimal Cantidad { get; set; }
        public System.DateTime FechaLinea { get; set; }
        public System.DateTime FechaAcceso { get; set; }
        public string UsrAcceso { get; set; }
        public Nullable<bool> MueveStock { get; set; }
    
        public virtual Articulos Articulos { get; set; }
        public virtual RemitosCompra RemitosCompra { get; set; }
    }
}
