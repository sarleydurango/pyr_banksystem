using CapaLogica;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PyrBanco
{
    public partial class FrmTransaccion : Form
    {
        public FrmTransaccion()
        {
            InitializeComponent();
            Func_ConsultarTipoTransaccion();
        }
        protected void Func_ConsultarTipoTransaccion()
        {
            ClsTransacciones ObjEstadoC = new ClsTransacciones();
            ObjEstadoC.app = 1;
            ObjEstadoC.FuncConsultarTransaccion();
            CbxTransaccion.DataSource = ObjEstadoC.tipo;
            CbxTransaccion.ValueMember = "PKid";
            CbxTransaccion.DisplayMember = "Descripcion";
        }

        protected void Func_BuscarPropietario()
        {

            ClsTransacciones ObjBuscar = new ClsTransacciones();
            ObjBuscar.cuenta = TxtCuenta.Text;
            ObjBuscar.Func_BuscarCuenta();
            if (ObjBuscar.sw == 1)
            {
                TxtPropietario.Text = ObjBuscar.propietario;
                TxtCuenta.Enabled = false;
                TxtValor.Focus();

            }
            else
            {
                MessageBox.Show("No se encontro registro de la cuenta " + TxtCuenta.Text + "\nPosiblemente su cuenta no existe o se encuentra Inactiva\nConsulte con su Asesor", "Validación de información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtCuenta.Focus();
                
            }
        }

        private void TxtCuenta_KeyUp(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Func_BuscarPropietario();
                }
            }
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void PtbReturn_Click(object sender, EventArgs e)
        {
            FrmInterfazPrincipal objregresar = new FrmInterfazPrincipal();
            objregresar.Show();
            Hide();
        }
        protected void Func_Transacciones()
        {
            ClsTransacciones ObjTransacciones = new ClsTransacciones();
            ObjTransacciones.clase = Convert.ToInt32(CbxTransaccion.SelectedValue);
            ObjTransacciones.valor = TxtValor.Text;
            ObjTransacciones.cuenta = TxtCuenta.Text;
            ObjTransacciones.CuentaDestino = "N/A";
            ObjTransacciones.Func_ConsultarTransaccion();
            MessageBox.Show("La transaccion fue realizada con exito");
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Func_Transacciones();
        }
        protected void Func_CancelarOperacion()
        {
            TxtPropietario.Clear();
            TxtCuenta.Clear();
            Func_ConsultarTipoTransaccion();
            TxtValor.Clear();
            TxtCuenta.Focus();
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Func_CancelarOperacion();
        }

        private void BtnNueva_T_Click(object sender, EventArgs e)
        {
            Func_CancelarOperacion();
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            Func_Transacciones();
        }
    }
}

