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
    
    public partial class PresupuestosDetalles
    {
        public long IdPresupuestoDetalle { get; set; }
        public int IdPresupuesto { get; set; }
        public Nullable<long> IdArticulo { get; set; }
        public decimal Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public Nullable<System.DateTime> FechaAcceso { get; set; }
        public string UsrAcceso { get; set; }
        public string Articulo { get; set; }
        public string UMedida { get; set; }
        public Nullable<decimal> IVAArt { get; set; }
    
        public virtual Articulos Articulos { get; set; }
        public virtual Presupuestos Presupuestos { get; set; }
    }
}
