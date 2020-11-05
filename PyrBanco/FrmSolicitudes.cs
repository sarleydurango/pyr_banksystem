using CapaLogica;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PyrBanco
{
    public partial class FrmSolicitudes : Form
    {
        public FrmSolicitudes()
        {
            InitializeComponent();
            Func_ConsultarEstado();
            Func_ConsultarSolicitudes();
        }
        protected void Func_ConsultarEstado()
        {
            ClsSolicitudes ObjEstado = new ClsSolicitudes();
            ObjEstado.Func_Estado();
            CbxEstado.DataSource = ObjEstado.dt_estado;
            CbxEstado.ValueMember = "PKId";
            CbxEstado.DisplayMember = "Descripcion";
        }
        protected void Func_ConsultarSolicitudes()
        {
            ClsSolicitudes ObjSolicitud = new ClsSolicitudes();
            ObjSolicitud.estado = Convert.ToString(CbxEstado.SelectedValue);
            ObjSolicitud.Func_ConsultarSolicitud();
            Dtg_Solicitud.DataSource = ObjSolicitud.dt;
        }

        private void Dtg_Solicitud_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                int fila = Dtg_Solicitud.CurrentRow.Index;
                FrmObservacion ObjObservacion = new FrmObservacion();
                if (Convert.ToString(Dtg_Solicitud.Rows[fila].Cells[6].Value) == "Activo")
                {
                    ObjObservacion.TxtObservasiones.Enabled = false;
                    ObjObservacion.BtnUsuarios.Enabled = false;
                }
                else
                {
                    ObjObservacion.TxtObservasiones.Enabled = true;
                    ObjObservacion.BtnUsuarios.Enabled = true;
                }
                ObjObservacion.LblUsuario.Text = LblUsuario.Text;
                ObjObservacion.LblSolicitudes.Text = Convert.ToString(Dtg_Solicitud.Rows[fila].Cells[0].Value);
                ObjObservacion.ShowDialog();
            }
            catch(Exception)
            { }
        }

        private void CbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Func_ConsultarSolicitudes();
        }
    }

}
