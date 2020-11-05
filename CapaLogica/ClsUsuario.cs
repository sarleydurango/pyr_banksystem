using CapaDatos;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaLogica
{
    public class ClsUsuario
    {
        public DataTable dt_estado = new DataTable();
        public DataTable dt_sexo = new DataTable();
        public String id, contraseña, nombre, apellidos, correo, direccion, telefono, movil, sexo, estado, foto, rol, usuario;
        public int espacio, sw = 0;

        protected void Func_ConsultarEstado()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarEstadoCivil", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_estado);
            objconexion.connection.Close();
        }
        protected void Func_ConsultarSexo()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarSexo", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_sexo);
            objconexion.connection.Close();
        }
        protected void Func_BuscarUsuario()
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
                apellidos = Convert.ToString(Lectura[1]);
                sexo = Convert.ToString(Lectura[2]);
                direccion = Convert.ToString(Lectura[3]);
                correo = Convert.ToString(Lectura[4]);
                telefono = Convert.ToString(Lectura[5]);
                movil = Convert.ToString(Lectura[6]);
                estado = Convert.ToString(Lectura[7]);
                foto = Convert.ToString(Lectura[8]);
                usuario = Convert.ToString(Lectura[9]);
                sw = 1;
            }
            objconect.connection.Close();
        }
        protected void Func_GuardarUsuario()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_GuardarClientes", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            con.Parameters.AddWithValue("@nombres", nombre);
            con.Parameters.AddWithValue("@apellidos", apellidos);
            con.Parameters.AddWithValue("@sexo", sexo);
            con.Parameters.AddWithValue("@direccion", direccion);
            con.Parameters.AddWithValue("@correo", correo);
            con.Parameters.AddWithValue("@telefono", telefono);
            con.Parameters.AddWithValue("@movil", movil);
            con.Parameters.AddWithValue("@estado", estado);
            con.Parameters.AddWithValue("@usuario", usuario);
            con.Parameters.AddWithValue("@rol", rol);
            con.Parameters.AddWithValue("@foto", foto);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        protected void Func_ConsultarUsuario()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_BuscarCliente", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                nombre = Convert.ToString(Lectura[0]);
                apellidos = Convert.ToString(Lectura[1]);
                sexo = Convert.ToString(Lectura[5]);
                direccion = Convert.ToString(Lectura[3]);
                correo = Convert.ToString(Lectura[2]);
                telefono = Convert.ToString(Lectura[7]);
                movil = Convert.ToString(Lectura[6]);
                estado = Convert.ToString(Lectura[4]);
                foto = Convert.ToString(Lectura[8]);
                usuario = Convert.ToString(Lectura[9]);
                sw = 1;
            }
            objconect.connection.Close();
        }
        protected void Func_ConsultarRegistroUsuario()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_ConsultarUsuario", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@usuario", id);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                foto = Convert.ToString(Lectura[0]);
                sw = 1;
            }
        }
        protected void Func_ActualizarCliente()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_ActualizarClientes", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@id", id);
            con.Parameters.AddWithValue("@nombres", nombre);
            con.Parameters.AddWithValue("@apellidos", apellidos);
            con.Parameters.AddWithValue("@sexo", sexo);
            con.Parameters.AddWithValue("@direccion", direccion);
            con.Parameters.AddWithValue("@correo", correo);
            con.Parameters.AddWithValue("@telefono", telefono);
            con.Parameters.AddWithValue("@movil", movil);
            con.Parameters.AddWithValue("@estado", estado);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        //Funcion de ingreso al sistema: FrmLogin
        protected void Func_IngresoAlSistema()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con; SqlDataReader Lectura;
            con = new SqlCommand("SP_IngresoSistema", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@user", id);
            con.Parameters.AddWithValue("@contraseña", contraseña);
            objconect.connection.Open();
            Lectura = con.ExecuteReader();
            if (Lectura.Read() == true)
            {
                usuario = Convert.ToString(Lectura[0]);
                nombre = Convert.ToString(Lectura[1]);
                foto = Convert.ToString(Lectura[2]);
                contraseña = Convert.ToString(Lectura[3]);
                sw = 1;
            }
            objconect.connection.Close();
        }
        //======Aqui termina la funcion ingreso al sistema======//

        //Funciones de la FrmCambiar
        protected void Func_CambiarContraseña()
        {
            ClsConexion objconect = new ClsConexion();
            SqlCommand con = new SqlCommand("SP_CambiarContraseña", objconect.connection);
            con.CommandType = CommandType.StoredProcedure;
            con.Parameters.AddWithValue("@usuario", usuario);
            con.Parameters.AddWithValue("@contraseña", contraseña);
            objconect.connection.Open();
            con.ExecuteNonQuery();
            objconect.connection.Close();
        }
        //Aqui termina funcion de la FrmCambiar
        //========================================= Aqui llamo las funciones publicas de la clase ==========//
        public void Func_CambiarContra()
        { Func_CambiarContraseña(); }
        public void Func_Ingreso()
        { Func_IngresoAlSistema(); }
        public void Func_ConsultarUser()
        { Func_ConsultarRegistroUsuario();}
        public void Func_ActualizarUser()
        { Func_ActualizarCliente(); }
        public void Func_ConsultarClientes()
        { Func_BuscarUsuario(); }
        public void Func_GuardarUsuarios()
        { Func_GuardarUsuario(); }
        public void Func_ConsultarEstadoCivil()
        { Func_ConsultarEstado(); }
        public void FuncConsultarSexo()
        { Func_ConsultarSexo(); }

    }
}
