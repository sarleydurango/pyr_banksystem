using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaLogica
{
    public class ClsTransacciones
    {
        public DataTable tipo = new DataTable();
        public String cuenta, propietario, valor, CuentaOrigen, CuentaDestino;
        public int sw = 0, clase, app;

        //Funciones
        protected void Func_ConsultarTipoTransaccion()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarTransacciones", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@app", app);
            objconexion.connection.Open();
            da.Fill(tipo);
            objconexion.connection.Close();
        }
        protected void Func_BuscarClientes()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_ConsultarPropietario", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", cuenta);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                propietario = Convert.ToString(Lectura[0]);
                sw = 1;
            }
            objconect.connection.Close();
        }
        protected void Func_Transacciones()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_Transacciones", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@tipo", clase);
            con.Parameters.AddWithValue("@valor", valor);
            con.Parameters.AddWithValue("@n_cuenta_OR", cuenta);
            con.Parameters.AddWithValue("@n_cuenta_DEST", CuentaDestino);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
        }
        //==================== Aqui llamo las funciones publicas =======================//
        public void Func_ConsultarTransaccion()
        { Func_Transacciones(); }
        public void FuncConsultarTransaccion()
        { Func_ConsultarTipoTransaccion(); }
        public void Func_BuscarCuenta()
        { Func_BuscarClientes(); }
    }
}
