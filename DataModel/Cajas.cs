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
    
    public partial class Cajas
    {
        public Cajas()
        {
            this.CajasAperturas = new HashSet<CajasAperturas>();
        }
    
        public short IdCaja { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public short IdEstadoCaja { get; set; }
    
        public virtual ICollection<CajasAperturas> CajasAperturas { get; set; }
    }
}
