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
    
    public partial class CajasAperturas
    {
        public CajasAperturas()
        {
            this.CajasMovimientos = new HashSet<CajasMovimientos>();
        }
    
        public int IdAperturaCaja { get; set; }
        public System.DateTime FechaApertura { get; set; }
        public string UsrApertura { get; set; }
        public short IdCaja { get; set; }
        public decimal SaldoInicial { get; set; }
        public Nullable<decimal> SaldoFinal { get; set; }
        public Nullable<System.DateTime> FechaCierre { get; set; }
        public System.DateTime FechaAcceso { get; set; }
    
        public virtual Cajas Cajas { get; set; }
        public virtual ICollection<CajasMovimientos> CajasMovimientos { get; set; }
    }
}
