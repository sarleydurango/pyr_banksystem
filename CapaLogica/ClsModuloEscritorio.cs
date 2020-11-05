using System;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaLogica
{
    public class ClsModuloEscritorio
    { 
        public DataTable dt_estado = new DataTable();
        public DataTable dt_cuenta = new DataTable();
        public DataTable dt = new DataTable();
        public String id, nombre, apellido,correo, movil,ncuenta, n_cuenta, usuario;
        public String cuenta, cliente, estado, tipo, saldo;
        public int sw = 0;
        public int swc = 0;

        protected void Func_FuncConsultarCuentaGrla()
        {
            {
                ClsConexion objconect = new ClsConexion();
                SqlCommand con; SqlDataReader Lectura;
                con = new SqlCommand("SP_BuscarCuenta_Gra1", objconect.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@cuenta", n_cuenta);
                objconect.connection.Open();
                Lectura = con.ExecuteReader();
                if (Lectura.Read() == true)
                {
                    nombre = Convert.ToString(Lectura[1]);
                    movil = Convert.ToString(Lectura[2]);
                    correo = Convert.ToString(Lectura[3]);
                    sw = 1;
                }
                objconect.connection.Close();
            }
        }
        protected void Func_GuardarCuenta()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_GuardarCuenta", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@N_cuenta", cuenta);
            con.Parameters.AddWithValue("@cliente", cliente);
            con.Parameters.AddWithValue("@saldo", saldo);
            con.Parameters.AddWithValue("@tipo", tipo);
            con.Parameters.AddWithValue("@estado", estado);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }

        protected void Func_ConsultarCuentaCliente()
        {
            try
            {
                ClsConexion objconexion = new ClsConexion();
                SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarCuentasCliente", objconexion.connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@cliente", id);
                da.Fill(dt);
                objconexion.connection.Open();
                objconexion.connection.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
        protected void Func_ActualizarCuenta()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_ActualizarEstadoCuenta", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@ncuenta", ncuenta);
            con.Parameters.AddWithValue("@estado", estado);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        protected void Func_BuscarClientes()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_BuscarClientes", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                nombre = Convert.ToString(Lectura[0]);
                movil = Convert.ToString(Lectura[6]);
                correo = Convert.ToString(Lectura[4]);
                sw = 1;
            }
            objconect.connection.Close();
        }
        protected void Func_ConsultarTCuenta()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarTipoCuenta", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_cuenta);
            objconexion.connection.Close();
        }
        protected void Func_ConsultarEstado()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarEstado", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_estado);
            objconexion.connection.Close();
        }
        protected void Func_ValidarCuenta()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_ValidacionCuenta", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@ncuenta", ncuenta);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                swc = 1;
            }
            objconect.connection.Close();
        }
        public void Func_Consultar_Cuenta_Cliente()
        {
            Func_ConsultarCuentaCliente();
        }
        public void Func_ActualizarCuentas()
        { Func_ActualizarCuenta(); }
        public void Func_ValidarCuentas()
        { Func_ValidarCuenta(); }
        public void Func_GuardarCuentaUsuario()
        { Func_GuardarCuenta(); }
        public void Func_ConsultarEstadoC()
        { Func_ConsultarEstado(); }
        public void Func_ConsultarCuenta()
        { Func_ConsultarTCuenta(); }
        public void Func_Consultar()
        { Func_BuscarClientes(); }
    }
}
