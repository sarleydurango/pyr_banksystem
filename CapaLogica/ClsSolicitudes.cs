using System;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaLogica
{
    public class ClsSolicitudes
    {
        public DataTable dt_estado = new DataTable();
        public DataTable dt = new DataTable();
        public String estado;

        //////////////////////////////////**FUNCION CONSULTAR ESTADO DE SOLICITUD**///////////////////
        protected void Func_ConsultarEstado()
        {
            ClsConexion objconexion = new ClsConexion();
            SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarEstado", objconexion.connection);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            objconexion.connection.Open();
            da.Fill(dt_estado);
            objconexion.connection.Close();
        }
        //////////////////////////////////**SOLICITUDES / CANAL DE ATENCION **///////////////////
        protected void Func_ConsultarSolicitudes()
        {
            {
                try
                {
                    ClsConexion objconexion = new ClsConexion();
                    SqlDataAdapter da = new SqlDataAdapter("SP_ConsultarSolicitudes", objconexion.connection);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@estado", estado);
                    objconexion.connection.Open();
                    da.Fill(dt);
                    objconexion.connection.Close();
                }
                catch(Exception e)
                {
                    Console.WriteLine("{0} Exception caught.", e);
                }
            }
        }
        //////////////////////////////////**ESPACIO PARA FUNCIONES PUBLICAS**///////////////////
        public void Func_Estado()
        {
            Func_ConsultarEstado();
        }
        public void Func_ConsultarSolicitud()
        {
            Func_ConsultarSolicitudes();
        }


    }
}
