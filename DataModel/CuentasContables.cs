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
    
    public partial class CuentasContables
    {
        public CuentasContables()
        {
            this.AsientosContables = new HashSet<AsientosContables>();
        }
    
        public int IdCuentaContable { get; set; }
        public byte Nivel1 { get; set; }
        public byte Nivel2 { get; set; }
        public short Nivel3 { get; set; }
        public short Nivel4 { get; set; }
        public string Descripcion { get; set; }
        public bool ImputaValor { get; set; }
        public System.DateTime FechaAcceso { get; set; }
        public string UsrAcceso { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<int> IdCuentaSuperior { get; set; }
    
        public virtual ICollection<AsientosContables> AsientosContables { get; set; }
    }
}
