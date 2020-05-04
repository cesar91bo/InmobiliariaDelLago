using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAcces;
using DataAcces;

namespace Dominio
{
    public class LocatarioCN
    {
        private Locatarios locatarios = new Locatarios();

        public DataTable MostrarLocatarios()
        {
            DataTable tabla = new DataTable();
            tabla = locatarios.Mostrar();
            return tabla;
        }
    }
}
