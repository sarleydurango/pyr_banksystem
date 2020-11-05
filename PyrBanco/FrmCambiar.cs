using CapaLogica;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PyrBanco
{
    public partial class FrmCambiar : Form
    {
        public FrmCambiar()
        {
            InitializeComponent();
        }
        protected void Func_CambiarContraseña()
        {
            ClsUsuario ObjCambiar = new ClsUsuario();
            ObjCambiar.usuario = LblUsuario.Text;
            ObjCambiar.contraseña = TxtCorfimar_Contra.Text;
            if ((TxtContra_Nueva.Text == TxtCorfimar_Contra.Text) && (TxtContraeñaAnterior.Text == LblContraseña.Text))
            {
                ObjCambiar.Func_CambiarContra();
                MessageBox.Show("Contraseña actualizada con éxito", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            Func_CambiarContraseña();
        }
    }
}
