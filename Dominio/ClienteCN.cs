using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using DataAcces;

namespace Dominio
{
	public class ClienteCN
	{
		private SgPymeDelLagoEntities dbContext = new SgPymeDelLagoEntities();
		public List<ClientesDto> ListarClientes()
        {
			try
			{
				using (SgPymeDelLagoEntities dbContext = new SgPymeDelLagoEntities())
				{
					var Consulta = (from c in dbContext.Clientes
									select new ClientesDto
									{
										NroCliente = c.NroCliente,
										ApellidoyNombre = c.ApellidoyNombre,
										Direccion = c.Direccion,
										Telefono = c.Telefono,
										NroDocumento = c.NroDocumento
									}).ToList();
					return Consulta;
				}
			}
			catch (Exception)
			{
				throw;
			}
        }

		public ClientesDto BuscarLocatarioPorID(int id)
		{
			var cliente  = from cli in ListarClientes()
						   where cli.NroCliente == id
										select cli;
			return cliente.SingleOrDefault();
		}
    }
}
