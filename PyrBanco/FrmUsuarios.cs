using CapaLogica;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PyrBanco
{
    public partial class FrmUsuarios : Form
    {
        String folder = Path.Combine(Application.StartupPath, "img");
        OpenFileDialog file = new OpenFileDialog();
        public String Filename;
        public String ruta_default;
        public String espacio;
        public FrmUsuarios()
        {
            InitializeComponent();
            Func_ConsultarEstadoC();
            Func_ConsultarSexo();

        }

        protected void Func_GuardarFoto()
        {
            Filename = Path.Combine(folder, TxtIdentificacion.Text + ".png");
            PtbFoto.Image.Save(Filename);
        }
        protected void Func_LimpiarControles()
        {
            TxtIdentificacion.Clear();
            TxtNombres.Clear();
            TxtApellidos.Clear();
            CbxSexo.SelectedIndex = 0;
            CbxEstado.SelectedIndex = 0;
            TxtDireccion.Clear();
            TxtCorreo.Clear();
            TxtTelefono.Clear();
            TxtUsuario.Clear();
            TxtMovil.Clear();
            LblUser.Text = "";
            ruta_default = Filename = Path.Combine(folder, "default.png");
            PtbFoto.Image = Image.FromFile(ruta_default);
            TxtIdentificacion.Focus();
        }

        protected void Func_ConsultarEstadoC()
        {
            ClsUsuario ObjEstadoC = new ClsUsuario();
            ObjEstadoC.Func_ConsultarEstadoCivil();
            CbxEstado.DataSource = ObjEstadoC.dt_estado;
            CbxEstado.ValueMember = "PKId";
            CbxEstado.DisplayMember = "Descripcion";
        }
        protected void Func_ConsultarSexo()
        {
            ClsUsuario ObjSexo = new ClsUsuario();
            ObjSexo.FuncConsultarSexo();
            CbxSexo.DataSource = ObjSexo.dt_sexo;
            CbxSexo.ValueMember = "PKId";
            CbxSexo.DisplayMember = "Descripcion";
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Func_LimpiarControles();
        }

        private void PtbFoto_Click(object sender, EventArgs e)
        {
            file.Filter = "Archivo JPG|*.jpg";
            if (file.ShowDialog() == DialogResult.OK)
            {
                PtbFoto.Image = Image.FromFile(file.FileName);
            }
        }
        protected void Func_Espacio()
        {
            TxtUsuario.Text = TxtIdentificacion.Text + "." + TxtNombres.Text.Replace(' ', '_');
        }

        protected void Func_GuardarUsuario()
        {
            if (((((TxtNombres.Text == "") || (TxtApellidos.Text == "") || (TxtCorreo.Text == "") || (TxtDireccion.Text == "") || (TxtMovil.Text == "")))))
            {
                MessageBox.Show("Debe diligenciar toda la informacion", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtIdentificacion.Focus();
            }
            else
            {
                ClsUsuario ObjUsuario = new ClsUsuario();
                ObjUsuario.id = TxtIdentificacion.Text;
                ObjUsuario.nombre = TxtNombres.Text;
                ObjUsuario.apellidos = TxtApellidos.Text;
                ObjUsuario.sexo = Convert.ToString(CbxSexo.SelectedValue);
                ObjUsuario.estado = Convert.ToString(CbxEstado.SelectedValue);
                ObjUsuario.direccion = TxtDireccion.Text;
                ObjUsuario.correo = TxtCorreo.Text;
                ObjUsuario.telefono = TxtTelefono.Text;
                ObjUsuario.movil = TxtMovil.Text;
                ObjUsuario.rol = LblRol.Text;
                Func_GuardarFoto();
                ObjUsuario.foto = Filename;
                Func_Espacio();
                ObjUsuario.usuario = TxtUsuario.Text;
                ObjUsuario.Func_GuardarUsuarios();
                Func_LimpiarControles();
                MessageBox.Show("El usuario " + TxtNombres.Text + " ha sido creado exitosamente", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void Func_ActualizarUsuario()
        {
            if (((((TxtNombres.Text == "") || (TxtApellidos.Text == "") || (TxtCorreo.Text == "") || (TxtDireccion.Text == "") || (TxtMovil.Text == "")))))
            {
                MessageBox.Show("Debe diligenciar toda la informacion", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtIdentificacion.Focus();
            }
            else
            {
                ClsUsuario ObjActualizarUsuario = new ClsUsuario();
                ObjActualizarUsuario.id = TxtIdentificacion.Text;
                ObjActualizarUsuario.nombre = TxtNombres.Text;
                ObjActualizarUsuario.apellidos = TxtApellidos.Text;
                ObjActualizarUsuario.sexo = Convert.ToString(CbxSexo.SelectedValue);
                ObjActualizarUsuario.estado = Convert.ToString(CbxEstado.SelectedValue);
                ObjActualizarUsuario.direccion = TxtDireccion.Text;
                ObjActualizarUsuario.correo = TxtCorreo.Text;
                ObjActualizarUsuario.telefono = TxtTelefono.Text;
                ObjActualizarUsuario.movil = TxtMovil.Text;
                ObjActualizarUsuario.rol = LblRol.Text;
                ObjActualizarUsuario.Func_ActualizarUser();
                MessageBox.Show("El usuario " + TxtNombres.Text + " ha sido actualizado exitosamente", "Validacion de informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        protected void Func_BuscarUsuario()
        {
            ClsUsuario ObjUsuario = new ClsUsuario();
            ObjUsuario.id = TxtIdentificacion.Text;
            ObjUsuario.Func_ConsultarClientes();
            if (ObjUsuario.sw == 1)
            {
                TxtNombres.Text = ObjUsuario.nombre;
                TxtApellidos.Text = ObjUsuario.apellidos;
                CbxSexo.SelectedValue = Convert.ToInt32(ObjUsuario.sexo);
                CbxEstado.SelectedValue =Convert.ToInt32(ObjUsuario.estado);
                TxtDireccion.Text = ObjUsuario.direccion;
                TxtCorreo.Text = ObjUsuario.correo;
                TxtTelefono.Text = ObjUsuario.telefono;
                TxtMovil.Text = ObjUsuario.movil;
                LblUser.Text = ObjUsuario.usuario;
                TxtUsuario.Text = ObjUsuario.usuario;
                string foto;
                foto = ObjUsuario.foto;
                PtbFoto.Image = Image.FromFile(foto);

            }
            else
            {
                MessageBox.Show("La persona no se encuentra registrada");
            }
        }
        private void TxtIdentificacion_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Func_BuscarUsuario();
            }
        }

        protected void Func_ValidarUsuario()
        {
            ClsUsuario ObjValidar = new ClsUsuario();
            ObjValidar.id = TxtIdentificacion.Text;
            ObjValidar.Func_ConsultarClientes();
            if (ObjValidar.sw == 0)
            {
               // Func_GuardarUsuario();
                MessageBox.Show("La persona ha sido registrada exitosamente");
            }
            else
            {
                MessageBox.Show("La persona ya esta registrada");
            }

        }

        private void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Func_GuardarUsuario();
        }

        private void Btn_Actualizar_Click(object sender, EventArgs e)
        {
            Func_ActualizarUsuario();
        }

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtMovil_KeyPress(object sender, KeyPressEventArgs e)
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

        private void FrmUsuarios_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            { Func_LimpiarControles(); }
        }
    }
}
