﻿using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void UsuariostoolStripButton_Click(object sender, EventArgs e)
        {
            UsuariosForm userForm = new UsuariosForm();
            userForm.MdiParent = this;
            userForm.Show();


        }

        private void ProductostoolStripButton_Click(object sender, EventArgs e)
        {
            ProductosForm productosForm = new ProductosForm();
            productosForm.MdiParent = this;
            productosForm.Show();
        }

        private void NuevaFacturatoolStripButton_Click(object sender, EventArgs e)
        {
            FacturaForm facturaForm = new FacturaForm();
            facturaForm.MdiParent = this;
            facturaForm.Show();
        }

        private void ClientestoolStripButton_Click(object sender, EventArgs e)
        {
            ClientesForm clientesForm = new ClientesForm();
            clientesForm.MdiParent = this;
            clientesForm.Show();
        }
    }
}
