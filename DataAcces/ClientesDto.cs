using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcces
{
    public class ClientesDto
    {

        public int NroCliente { get; set; }
        public string TipoDocumento { get; set; }
        public Nullable<int> NroDocumento { get; set; }
        public string ApellidoyNombre { get; set; }
        public string Direccion { get; set; }
        public short CodigoPostal { get; set; }
        public byte SubCodigoPostal { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public short IdRegimenImpositivo { get; set; }
        public string Telefono { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Cuit0 { get; set; }
        public string Cuit1 { get; set; }
        public string Cuit2 { get; set; }
        public string UsrBaja { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
        public Nullable<System.DateTime> FechaAcceso { get; set; }
        public string UsrAcceso { get; set; }
        public Nullable<byte> IdObservación { get; set; }
        public string MensajeCuenta { get; set; }
        public Nullable<decimal> SaldoExcedido { get; set; }
        public string CuentaCerrada { get; set; }
        public string Comentario { get; set; }

    }
}
