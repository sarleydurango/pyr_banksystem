using System;
using System.Drawing;
using System.Windows.Forms;

namespace PyrBanco
{
    public partial class FrmInterfazPrincipal : Form
    {
        public FrmInterfazPrincipal()
        {
            InitializeComponent();
            Func_Boton1();
        }
        protected void Func_Boton1()
        {
            opcion.Location = new Point(12, 308);
        }
        protected void Func_Boton2()
        {
            opcion.Location = new Point(12, 356);
        }
        protected void Func_Boton3()
        {
            opcion.Location = new Point(12, 404);
        }
        protected void Func_Boton4()
        {
            opcion.Location = new Point(12, 450);
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios ObjCuentas = new FrmUsuarios();
            ObjCuentas.ShowDialog();
        }

        private void Btn_cuentas_Click(object sender, EventArgs e)
        {
            FrmCuentas ObjCuentas = new FrmCuentas();
            ObjCuentas.ShowDialog();
        }

        private void BtnUsuarios_MouseHover(object sender, EventArgs e)
        {
            Func_Boton1();
        }

        private void Btn_cuentas_MouseHover(object sender, EventArgs e)
        {
            Func_Boton2();
        }

        private void FrmInterfazPrincipal_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            if (e.KeyCode == Keys.F3)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            Hide();
            FrmLogin ObjLogin = new FrmLogin();
            ObjLogin.Show();
        }
        private void Btn_Transacciones_MouseHover(object sender, EventArgs e)
        {
            Func_Boton3();
        }

        private void Btn_Transacciones_Click(object sender, EventArgs e)
        {
            FrmTransaccion ObjTransaccion = new FrmTransaccion();
            ObjTransaccion.ShowDialog();
        }

        private void BtnCambiar_Click(object sender, EventArgs e)
        {
            FrmCambiar ObjCambiar = new FrmCambiar();
            ObjCambiar.ShowDialog();
        }

        private void Btn_Solicitudes_Click(object sender, EventArgs e)
        {
            FrmSolicitudes ObjSolicitudes = new FrmSolicitudes();
            ObjSolicitudes.ShowDialog();
        }

        private void Btn_Solicitudes_MouseHover(object sender, EventArgs e)
        {
            Func_Boton4();
        }
    }
}
