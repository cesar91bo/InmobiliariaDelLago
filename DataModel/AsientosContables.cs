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
    
    public partial class AsientosContables
    {
        public long IdAsientoContable { get; set; }
        public int IdCuentaContable { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public int Periodo { get; set; }
        public short IdEmpresa { get; set; }
        public System.DateTime Fecha { get; set; }
        public string UsrAcceso { get; set; }
        public System.DateTime FechaAcceso { get; set; }
    
        public virtual CuentasContables CuentasContables { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual PeriodosContables PeriodosContables { get; set; }
    }
}
