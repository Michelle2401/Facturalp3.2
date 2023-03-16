using Datos;
using Entidades;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vista
{
    public partial class UsuariosForm : Syncfusion.Windows.Forms.Office2010Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
        }
        string tipoOperacion;
        DataTable dt = new DataTable();
        UsuarioDB UsuarioDB = new UsuarioDB();
        Usuario user = new Usuario();

        private void HabilitarControles()
        {
            CodigotextBox.Enabled = true;
            NombretextBox.Enabled = true;
            ContraseñatextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            RolcomboBox.Enabled = true;
            EstaActivocheckBox.Enabled = true;
            Adjuntarbutton.Enabled = true;
            Guardarbutton.Enabled = true;
            Cancelarbutton.Enabled = true;
            Modificarbutton.Enabled = false;
        }
        private void DeshabilitarControles()
        {
            CodigotextBox.Enabled = false;
            NombretextBox.Enabled = false;
            ContraseñatextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            RolcomboBox.Enabled = false;
            EstaActivocheckBox.Enabled = false;
            Adjuntarbutton.Enabled = false;
            Guardarbutton.Enabled = false;
            Cancelarbutton.Enabled = false;
            Modificarbutton.Enabled = true;
        }
        private void LimpiarControles()
        {
            CodigotextBox.Clear();
            NombretextBox.Clear();
            ContraseñatextBox.Clear();
            CorreotextBox.Clear();
            RolcomboBox.Text = "";
            EstaActivocheckBox.Checked = false;
            FotopictureBox.Image = null;
        }

        private void Nuevobutton_Click(object sender, System.EventArgs e)
        {
            CodigotextBox.Focus();
            HabilitarControles();
            tipoOperacion = "Nuevo";
        }

        private void Cancelarbutton_Click(object sender, System.EventArgs e)
        {
            DeshabilitarControles();
            LimpiarControles();
        }

        private void Guardarbutton_Click(object sender, System.EventArgs e)
        {
            if (tipoOperacion == "Nuevo")
            {
                if (string.IsNullOrEmpty(CodigotextBox.Text))
                {
                    errorProvider1.SetError(CodigotextBox, "Ingrese un código");
                    CodigotextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(NombretextBox.Text))
                {
                    errorProvider1.SetError(NombretextBox, "Ingrese un nombre");
                    NombretextBox.Focus();
                    return;
                }
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(ContraseñatextBox.Text))
                {
                    errorProvider1.SetError(ContraseñatextBox, "Ingrese una contraseña");
                    ContraseñatextBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                if (string.IsNullOrEmpty(RolcomboBox.Text))
                {
                    errorProvider1.SetError(RolcomboBox, "Seleccione un rol");
                    RolcomboBox.Focus();
                    return;
                }
                errorProvider1.Clear();

                Usuario user = new Usuario();
                user.CodigoUsuario = CodigotextBox.Text;
                user.Nombre = NombretextBox.Text;
                user.Contraseña = ContraseñatextBox.Text;
                user.Rol = RolcomboBox.Text;
                user.Correo = CorreotextBox.Text;
                user.EstaActivo = EstaActivocheckBox.Checked;

                if (FotopictureBox.Image != null)
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    FotopictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    user.Foto = ms.GetBuffer();
                }

            }
        }

        private void Modificarbutton_Click(object sender, System.EventArgs e)
        {
            tipoOperacion = "Modificar";

            //if (UsuariosdataGridView.SelectedRows.Count > 0)
            // {
            //CodigotextBox.Text = UsuariosdataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString();
            // NombretextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Nombre"].Value.ToString();
            // ContraseñatextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Contrasena"].Value.ToString();
            //CorreotextBox.Text = UsuariosdataGridView.CurrentRow.Cells["Correo"].Value.ToString();
            //RolcomboBox.Text = UsuariosdataGridView.CurrentRow.Cells["Rol"].Value.ToString();
            //EstaActivocheckBox.Checked = Convert.ToBoolean(UsuariosdataGridView.CurrentRow.Cells["EstaActivo"].Value);

            //byte[] miFoto = UsuarioDB.DevolverFoto(UsuariosDataGridView.CurrentRow.Cells["CodigoUsuario"].Value.ToString());
            // }
        }

        private void Adjuntarbutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult resultado = dialog.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                FotopictureBox.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void UsuariosForm_Load(object sender, EventArgs e)
        {
            TraerUsuarios();
        }

        private void TraerUsuarios()
        {
            dt = UsuarioDB.DevolverUsuarios();
            UsuariosdataGridView.DataSource = dt;
        }

    }
}
