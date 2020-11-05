using System;
using System.Windows.Forms;
using CapaLogica;
using System.Drawing;

namespace PyrBanco
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        protected void Func_ConsultarUser()
        {
            ClsUsuario ObjUsuario = new ClsUsuario();
            ObjUsuario.id = TxtUsuario.Text;
            ObjUsuario.Func_ConsultarUser();
            if ((ObjUsuario.sw == 1) && (ObjUsuario.foto != ""))
            { PtbUser.Image = Image.FromFile(ObjUsuario.foto); }
            else
            { PtbUser.Image = null; }
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            Func_ConsultarUser();
        }
        protected void Func_Ingreso()
        {
            ClsUsuario ObjSesion = new ClsUsuario();
            ObjSesion.id = TxtUsuario.Text;
            ObjSesion.contraseña = TxtContraseña.Text;
            ObjSesion.Func_Ingreso();
            if (ObjSesion.sw == 1)
            {
                FrmInterfazPrincipal ObjInterfaz = new FrmInterfazPrincipal();
                ObjInterfaz.PtbUsuario.Image = Image.FromFile(ObjSesion.foto);
                ObjInterfaz.LblNombres.Text = ObjSesion.nombre;
                ObjInterfaz.LblUsuario.Text = ObjSesion.usuario;
                ObjInterfaz.LblContraseña.Text = ObjSesion.contraseña;
                ObjInterfaz.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Información de ingreso no valida, consultar con el Administrador", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                Func_Ingreso();
            }
        }
    }
}
