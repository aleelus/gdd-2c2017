using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;


namespace PagoAgilFrba.BaseDeDatos.ConexionDB
{
    static class ConexionDB
    {
        public static SqlConnection ConectarDB(string connectionString)
        {
            SqlConnection conexionDB = new SqlConnection(connectionString);
            if (conexionDB.State != System.Data.ConnectionState.Open)
            {
                conexionDB.Open();
            }
            return conexionDB;
        }

        public static void DesconectarDB(SqlConnection conexionDB)
        {
            if (conexionDB.State != System.Data.ConnectionState.Closed)
            {
                conexionDB.Close();
            }
        }

        public static bool Procedure(string nombreProcedure, List<SqlParameter> parametros, out DataTable tabla)
        {
            return Procedure(nombreProcedure, parametros, out tabla, true);
        }

        public static bool Procedure(string nombreProcedure, List<SqlParameter> parametros, out DataTable tabla, bool mensajes)
        {
            try
            {
                SqlCommand comandoSQL = new SqlCommand("[GRUPO48]." + nombreProcedure, Sesion.conexion);
                comandoSQL.CommandType = CommandType.StoredProcedure;

                if (parametros != null && parametros.Exists(x => x != null))
                {
                    foreach (SqlParameter parametro in parametros)
                    {
                        comandoSQL.Parameters.Add(parametro);
                    }
                }

                tabla = llenarDataTable(comandoSQL);

                return true;
            }
            catch (SqlException ex)
            {
                if (mensajes)
                {
                    MessageBox.Show(ex.Message);
                }

                tabla = new DataTable();
                return false;
            }
        }
        private static DataTable llenarDataTable(SqlCommand comandoSQL)
        {
            SqlDataReader dr = comandoSQL.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            return dt;
        }


        public static bool Procedure(string nombreProcedure, List<SqlParameter> parametros)
        {
            try
            {
                SqlCommand comandoSQL = new SqlCommand("[GRUPO48]." + nombreProcedure, Sesion.conexion);
                comandoSQL.CommandType = CommandType.StoredProcedure;

                if (parametros != null && parametros.Exists(x => x != null))
                {
                    foreach (SqlParameter parametro in parametros)
                    {
                        comandoSQL.Parameters.Add(parametro);
                    }
                }

                SqlDataReader dr = comandoSQL.ExecuteReader();
                dr.Close();

                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }  

    }

    public class SQLParametros
    {
        List<SqlParameter> listaDeParametros;

        public SQLParametros()
        {
            listaDeParametros = new List<SqlParameter>();
        }

        public void add(string nombreParametro, object valor)
        {
            listaDeParametros.Add(new SqlParameter(nombreParametro, valor));
        }

        public List<SqlParameter> get()
        {
            return listaDeParametros;
        }
        public void Clear()
        {
            listaDeParametros.Clear();
        }
    }
}
