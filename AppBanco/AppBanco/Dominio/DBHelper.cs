using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace AppBanco.Dominio
{
    internal class DBHelper
    {
        private SqlConnection connection;

        public DBHelper()
        {
            //connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=AppBanco;");
            connection = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=AppBanco;Integrated Security=True");

        }

        public int proximoCBU() {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_PROXIMO_CBU";

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@proximo_cbu";
            param.SqlDbType = SqlDbType.Int;
            param.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(param);
            cmd.ExecuteNonQuery();
            connection.Close();
            try { return (int)param.Value; }
            catch { return 00001; }

        }

        public DataTable consultar(string nombreSP)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            connection.Close();
            return dataTable;

        }

  

        public Cliente clienteExiste(int dniCliente) {
            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CLIENTE_CON_DNI";
            cmd.Parameters.AddWithValue("@dni", dniCliente);

            DataTable dataTable = new DataTable();
            dataTable.Load(cmd.ExecuteReader());
            connection.Close();
            if (dataTable.Rows.Count > 0)
            {

                foreach (DataRow row in dataTable.Rows)
                {
                    string nombre = row["nombre"].ToString();
                    string apellido = row["apellido"].ToString();
                    int dni = Convert.ToInt32(row["dni"]);

                    Cliente cliente = new Cliente("nombre", "apellido", dni);
                    return cliente;
                }


            }
            return null;
          
            

        }

        public bool cargarSinCliente(int dni, Cuenta cuenta) 
        {
            bool success = false;
            
                connection.Open();
                //transaction = connection.BeginTransaction();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERTAR_SIN_CLIENTE";
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@cbu", cuenta.Cbu);
                cmd.Parameters.AddWithValue("@saldo", cuenta.Saldo);
                cmd.Parameters.AddWithValue("@tipoCuenta", cuenta.TipoCuenta);
                cmd.Parameters.AddWithValue("@ultimoMovimiento", cuenta.UltimoMovimiento.ToShortDateString());

                cmd.ExecuteNonQuery();
                //transaction.Commit();
                success = true;

            
            
            connection.Close();
            return success;


        }
        public bool cargarConClienteNuevo(Cliente cliente, Cuenta cuenta)
        {
            bool success = false;

            //SqlTransaction transaction = null;
            try
            {
                connection.Open();
                //transaction = connection.BeginTransaction();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = connection;
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERTAR_CON_CLIENTE";
                cmd.Parameters.AddWithValue("@nombreCliente", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellidoCliente", cliente.Apellido);
                cmd.Parameters.AddWithValue("@dniCliente", cliente.Dni);
                cmd.Parameters.AddWithValue("@cbu", cuenta.Cbu);
                cmd.Parameters.AddWithValue("@saldo", cuenta.Saldo);
                cmd.Parameters.AddWithValue("@tipoCuenta", cuenta.TipoCuenta);
                cmd.Parameters.AddWithValue("@ultimoMovimiento", cuenta.UltimoMovimiento);

                cmd.ExecuteNonQuery();
                //transaction.Commit();
                success = true;

            }
            catch {
                //transaction.Rollback();
            }
            connection.Close();


            return success;
        }

        public void borrarCuenta(int cbu) {

            connection.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_BORRAR_CUENTA_CON_CBU";
            cmd.Parameters.AddWithValue("@cbu", cbu);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
