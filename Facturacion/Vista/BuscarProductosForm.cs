using Datos;
using Entidades;
using System;
using System.Windows.Forms;

namespace Vista
{
    public partial class BuscarProductosForm : Form
    {
        public BuscarProductosForm()
        {
            InitializeComponent();
        }
        ProductoDB productoDB = new ProductoDB();
        public Producto producto = new Producto();
        private void BuscarProductosForm_Load(object sender, EventArgs e)
        {
            ProductosdataGridView.DataSource = productoDB.DevolverProductos();
        }

        private void DescripciontextBox_KeyUp(object sender, KeyEventArgs e)
        {
            ProductosdataGridView.DataSource = productoDB.DevolverProductosPorDescripcion(DescripciontextBox.Text);
        }

        private void Aceptarbutton_Click(object sender, EventArgs e)
        {
            if (ProductosdataGridView.RowCount > 0)
            {
                if (ProductosdataGridView.SelectedRows.Count > 0)
                {
                    producto.Codigo = ProductosdataGridView.CurrentRow.Cells["Codigo"].Value.ToString();
                    producto.Descripcion = ProductosdataGridView.CurrentRow.Cells["Descripcion"].Value.ToString();
                    producto.Existencia = Convert.ToInt32(ProductosdataGridView.CurrentRow.Cells["Existencia"].Value);
                    producto.Precio = Convert.ToDecimal(ProductosdataGridView.CurrentRow.Cells["Precio"].Value);
                    producto.EstaActivo = Convert.ToBoolean(ProductosdataGridView.CurrentRow.Cells["EstaActivo"].Value);
                    Close();
                }
            }
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
