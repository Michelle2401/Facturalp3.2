using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Vista
{
    public partial class FacturaForm : Form
    {
        public FacturaForm()
        {
            InitializeComponent();
        }
        Cliente miCliente = null;
        ClienteDB clienteDB = new ClienteDB();
        Producto miProducto = null;
        ProductoDB productoDB = new ProductoDB();
        List<DetalleFactura> listaDetalles = new List<DetalleFactura>();
        FacturaDB facturaDB = new FacturaDB();
        decimal subTotal = 0;
        decimal isv = 0;
        decimal totalAPagar = 0;
        decimal descuento = 0;

        private void IdentidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(IdentidadtextBox.Text))
            {
                miCliente = new Cliente();
                miCliente = clienteDB.DevolverClientePorIdentidad(IdentidadtextBox.Text);
                NombreClientetextBox.Text = miCliente.Nombre;
            }
            else
            {
                miCliente = null;
                NombreClientetextBox.Clear();
            }

        }

        private void BuscarClientebutton_Click(object sender, EventArgs e)
        {
            BuscarClienteForm form = new BuscarClienteForm();
            form.ShowDialog();
            miCliente = new Cliente();
            miCliente = form.cliente;
            IdentidadtextBox.Text = miCliente.Identidad;
            NombreClientetextBox.Text = miCliente.Nombre;
        }

        private void FacturaForm_Load(object sender, EventArgs e)
        {
            UsuariotextBox.Text = System.Threading.Thread.CurrentPrincipal.Identity.Name;
        }

        private void CodigotextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CodigoProductotextBox.Text))
            {
                miProducto = new Producto();
                miProducto = productoDB.DevolverProductoPorCodigo(CodigoProductotextBox.Text);
                DescripcionProductotextBox.Text = miProducto.Descripcion;
                ExistenciatextBox.Text = miProducto.Existencia.ToString();
            }
            else
            {
                miProducto = null;
                DescripcionProductotextBox.Clear();
                ExistenciatextBox.Clear();
            }
        }

        private void BuscarProductobutton_Click(object sender, EventArgs e)
        {
            BuscarProductosForm form = new BuscarProductosForm();
            form.ShowDialog();
            miProducto = new Producto();
            miProducto = form.producto;
            CodigoProductotextBox.Text = miProducto.Codigo;
            DescripcionProductotextBox.Text = miProducto.Descripcion;
            ExistenciatextBox.Text = miProducto.Existencia.ToString();
        }

        private void CantidadtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !string.IsNullOrEmpty(CantidadtextBox.Text))
            {
                DetalleFactura detalle = new DetalleFactura();
                detalle.CodigoProducto = miProducto.Codigo;
                detalle.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
                detalle.Precio = Convert.ToDecimal(miProducto.Precio);
                detalle.Total = Convert.ToInt32(CantidadtextBox.Text) * miProducto.Precio;
                detalle.Descripcion = miProducto.Descripcion;

                subTotal += detalle.Total;
                isv = subTotal * 0.15M;
                totalAPagar = subTotal + isv - descuento;

                listaDetalles.Add(detalle);
                DetalledataGridView.DataSource = null;
                DetalledataGridView.DataSource = listaDetalles;

                SubTotaltextBox.Text = subTotal.ToString();
                ISVtextBox.Text = isv.ToString();
                TotaltextBox.Text = totalAPagar.ToString();

                miProducto = null;
                CodigoProductotextBox.Clear();
                DescripcionProductotextBox.Clear();
                ExistenciatextBox.Clear();
                CantidadtextBox.Clear();
                CodigoProductotextBox.Focus();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Factura miFactura = new Factura();
            miFactura.Fecha = FechadateTimePicker.Value;
            miFactura.CodigoUsuario = System.Threading.Thread.CurrentPrincipal.Identity.Name;
            miFactura.IdentidadCliente = miCliente.Identidad;
            miFactura.SubTotal = subTotal;
            miFactura.ISV = isv;
            miFactura.Descuento = descuento;
            miFactura.Total = totalAPagar;

            bool inserto = facturaDB.Guardar(miFactura, listaDetalles);
            if (inserto)
            {
                LimpiarControles();
                IdentidadtextBox.Focus();
                MessageBox.Show("Factura registrada exitosamente");
            }
            else
                MessageBox.Show("No se pudo registrar la factura");

        }
        private void LimpiarControles()
        {
            miCliente = null;
            miProducto = null;
            listaDetalles = null;
            FechadateTimePicker.Value = DateTime.Now;
            IdentidadtextBox.Clear();
            NombreClientetextBox.Clear();
            CodigoProductotextBox.Clear();
            DescripcionProductotextBox.Clear();
            ExistenciatextBox.Clear();
            CantidadtextBox.Clear();
            DetalledataGridView.DataSource = null;
            subTotal = 0;
            SubTotaltextBox.Clear();
            isv = 0;
            ISVtextBox.Clear();
            descuento = 0;
            DescuentotextBox.Clear();
            totalAPagar = 0;
            TotaltextBox.Clear();
        }

        
    }
}
