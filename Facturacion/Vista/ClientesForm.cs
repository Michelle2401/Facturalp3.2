using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }
        ClientesForm usercliente = new ClientesForm();
        Cliente cliente;
        string Operacion;

        private void HabilitarControles()
        {
            IdentidadtextBox.Enabled = true;
            NombretextBox.Enabled = true;
            TelefonotextBox.Enabled = true;
            CorreotextBox.Enabled = true;
            DirecciontextBox.Enabled = true;
            FechaNacimientodateTimePicker.Enabled = true;
            EstaActivocheckBox.Enabled = true;

        }
        private void DesabilitarControles()
        {
            IdentidadtextBox.Enabled = false;
            NombretextBox.Enabled = false;
            TelefonotextBox.Enabled = false;
            CorreotextBox.Enabled = false;
            DirecciontextBox.Enabled = false;
            FechaNacimientodateTimePicker.Enabled = false;
            EstaActivocheckBox.Enabled = false;
        }

        private void LimpiarControles()
        {
            IdentidadtextBox.Clear();
            NombretextBox.Clear();
            TelefonotextBox.Clear();
            CorreotextBox.Clear();
            DirecciontextBox.Clear();
            EstaActivocheckBox.Checked = false;


        }

        private void Nuevobutton_Click(object sender, System.EventArgs e)
        {
            Operacion = "nuevo";
            HabilitarControles();
        }
        async void CargarClientes()
        {
            ClientesdataGridView.DataSource = await cliente.DevolverClientesAsync();
        }

        private void ClientesForm_Load(object sender, System.EventArgs e)
        {
            CargarClientes();
        }

        private void Cancelarbutton_Click(object sender, System.EventArgs e)
        {
            DesabilitarControles();
            LimpiarControles();
        }

        private void Guardarbutton_Click(object sender, System.EventArgs e)
        {
            if (IdentidadtextBox.Text == "")
            {
                errorProvider1.SetError(IdentidadtextBox, "Ingrese una identidad");
                IdentidadtextBox.Focus();
                return;
            }
            if (NombretextBox.Text == String.Empty)
            {
                errorProvider1.SetError(NombretextBox, "Ingrese un nombre");
                NombretextBox.Focus();
                return;
            }
            cliente = new Cliente();
            cliente.Identidad = IdentidadtextBox.Text;
            cliente.Nombre = NombretextBox.Text;
            cliente.Correo = CorreotextBox.Text;
            cliente.Direccion = DirecciontextBox.Text;

        }

        private async void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (ClientesdataGridView.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea eliminar el cliente?", "Atención", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    bool elimino = await cliente.EliminarClienteAsync(ClientesdataGridView.CurrentRow.Cells["Identidad"].Value.ToString());

                    if (elimino)
                    {
                        MessageBox.Show("Cliente eliminado");
                        CargarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el cliente");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un cliente");
            }
        }
    }
}
