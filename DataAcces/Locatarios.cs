using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAcces;
namespace DataAcces
{
    public class Locatarios
    {
        //Instanciamos la conexion de manera privada para encapsular la variabl
        private ConexionSql conexion = new ConexionSql();

        //Para leer filas de la tabla
        SqlDataReader leer;

        //Para almacenar las consultas del SqlDataReader
        DataTable tabla = new DataTable();

        //Para ejecutar instrucciones o procedeminetos almacenados de SQL
        SqlCommand comando = new SqlCommand();

        //Para mostrar los registros de la tabla 
        public DataTable Mostrar()
        {
            // A traves de transact sql
            // Abrimos la conexion sql a través del objeto command
            comando.Connection = conexion.AbrirConexion();
            // Establecemos el CommandText para ejecutar la instruccion transact sql
            comando.CommandText = "select * from Clientes";
            //Almacenamos las filas
            leer = comando.ExecuteReader();
            // La tabla será rellanado con los resultados de sql datareader
            tabla.Load(leer);
            // Es recomendable cerrar la conexion despues de ejecutar una instruccion
            conexion.CerrarConexion();
            return tabla;
        }

    }
}
