using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using CapaLogica;

namespace PyrBanco
{
    public partial class FrmCuentas : Form
    {
        public FrmCuentas()
        {
            InitializeComponent();
            Func_ConsultarTipoCuenta();
            Func_ConsultarEstado();
            TxtIdentificacion.Focus();
        }
        

        protected void Func_ConsultarTipoCuenta()
        {
            ClsModuloEscritorio ObjTCuenta = new ClsModuloEscritorio();
            ObjTCuenta.Func_ConsultarCuenta();
            CbxTCuenta.DataSource = ObjTCuenta.dt_cuenta;
            CbxTCuenta.ValueMember = "PKId";
            CbxTCuenta.DisplayMember = "Descripcion";
        }
        protected void Func_ConsultarEstado()
        {
            ClsModuloEscritorio ObjEstado = new ClsModuloEscritorio();
            ObjEstado.Func_ConsultarEstadoC();
            CbxEstado.DataSource = ObjEstado.dt_estado;
            CbxEstado.ValueMember = "PKId";
            CbxEstado.DisplayMember = "Descripcion";
        }
        protected void Func_Buscar_Cuenta()
        {
            ClsModuloEscritorio objcuenta = new ClsModuloEscritorio();
            objcuenta.id = TxtIdentificacion.Text;
            objcuenta.Func_Consultar_Cuenta_Cliente();
            DtgCuentas.DataSource = objcuenta.dt;
        }
        protected void Func_BuscarCliente()
        {
            ClsModuloEscritorio ObjCliente = new ClsModuloEscritorio();
            ObjCliente.id = TxtIdentificacion.Text;
            ObjCliente.Func_Consultar();
            if (ObjCliente.sw == 1)
            {
                TxtNombres.Text = ObjCliente.nombre;
                TxtCelular.Text = ObjCliente.movil;
                TxtCorreo.Text = ObjCliente.correo;
            }
            else
            {
                MessageBox.Show("La persona con identificacion " + TxtIdentificacion.Text + " no se encuentra en la Base de Datos");
            }
        }
        private void TxtIdentificacion_KeyUp(object sender, KeyEventArgs e)
        {
          if(e.KeyCode == Keys.Enter)
            {
                Func_BuscarCliente();
                Func_Buscar_Cuenta();
            }
        }
        protected void Func_GuardarCuenta()
        {
            ClsModuloEscritorio ObjCuenta = new ClsModuloEscritorio();
            ObjCuenta.cuenta = TxtNCuenta.Text;
            ObjCuenta.cliente = TxtIdentificacion.Text;
            ObjCuenta.saldo = TxtSaldo.Text;
            ObjCuenta.tipo = Convert.ToString(CbxTCuenta.SelectedValue);
            ObjCuenta.estado = Convert.ToString(CbxEstado.SelectedValue);
            ObjCuenta.Func_GuardarCuentaUsuario();
        }
        protected void Func_ValidacionCuenta()
        {
            ClsModuloEscritorio ObjValidar = new ClsModuloEscritorio();
            ObjValidar.ncuenta = TxtNCuenta.Text;
            ObjValidar.Func_ValidarCuentas();
            if (ObjValidar.swc == 1)
            {
                MessageBox.Show("La Cuenta " + TxtNCuenta.Text + " ya se encuentra asociada " + " al Cliente " + TxtNombres.Text, "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Func_GuardarCuenta();
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Func_ValidacionCuenta();
            MessageBox.Show("La cuenta ha sido guardada");
        }
        protected void Func_LimpiarControles()
        {
            TxtIdentificacion.Clear();
            TxtNombres.Clear();
            TxtCelular.Clear();
            TxtCorreo.Clear();
            TxtNCuenta.Clear();
            TxtSaldo.Clear();
            CbxTCuenta.SelectedIndex = 0;
            CbxEstado.SelectedIndex = 0;
            DtgCuentas.DataSource = null;

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Func_LimpiarControles();
            TxtIdentificacion.Focus();
        }
        protected void Func_ActualizarCuenta()
        {
            ClsModuloEscritorio ObjCuenta = new ClsModuloEscritorio();
            ObjCuenta.ncuenta = TxtNCuenta.Text;
            ObjCuenta.estado = Convert.ToString(CbxEstado.SelectedValue);
            ObjCuenta.Func_ActualizarCuentas();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Func_ActualizarCuenta();
            MessageBox.Show("Estado de cuenta actualizado");
        }
        //Data

        private void DtgCuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = DtgCuentas.CurrentRow.Index;
            TxtNCuenta.Text = Convert.ToString(DtgCuentas.Rows[fila].Cells[0].Value);
            CbxEstado.Text = Convert.ToString(DtgCuentas.Rows[fila].Cells[1].Value);
            CbxTCuenta.Text = Convert.ToString(DtgCuentas.Rows[fila].Cells[2].Value);
            TxtSaldo.Text = Convert.ToString(DtgCuentas.Rows[fila].Cells[3].Value);
        }

        private void FrmCuentas_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Func_LimpiarControles();
            }
        }

        private void FrmCuentas_Load(object sender, EventArgs e)
        {
            TxtIdentificacion.Focus();
        }
    }
}
