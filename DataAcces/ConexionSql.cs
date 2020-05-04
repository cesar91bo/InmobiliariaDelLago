using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class ConexionSql
    {
        private readonly string connectionString;
        public ConexionSql()
        {
            connectionString = "Server=.\\SQLEXPRESS;DataBase= SgPymeDelLago; Integrated Security=True";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        private SqlConnection Conexion = new SqlConnection("Server=.\\SQLEXPRESS;DataBase= SgPymeDelLago; Integrated Security=True");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}