using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Ferreteria.Database;
using Microsoft.VisualBasic;

namespace Sistema_Ferreteria.Formularios
{
    public partial class frmVentas1 : DevExpress.XtraEditors.XtraForm
    {
        public int IdProducto { get; set; }
        public int IdUsuario { get; set; }
        public double Total { get; set; }
        public List<ProductosEnCarrito> listaProductos;
        public frmVentas1()
        {
            InitializeComponent();
            IdUsuario = 1;
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            Total = 0;
            listaProductos = new List<ProductosEnCarrito>();
            CargarProductos();
        }
        #region "Metodos Simples"
        private void CargarProductos()
        {
           gridVenta.DataSource = null;
           gridVenta.DataSource = listaProductos;
           gridViewVenta.Columns[0].Visible = false;
           gridViewVenta.OptionsView.ColumnAutoWidth = true;
           gridViewVenta.BestFitColumns();
        }
        private void Limpiar()
        {
            lblTotal.Text = "Total: "+ (Total = 0).ToString();
            listaProductos.Clear();
            CargarProductos();
        }
        #endregion
        #region "Eventos de botones"
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Productos productos = (Productos)unitOfWork.GetObjectByKey<Productos>(IdProducto);
            if(productos == null) return;
            int cantidad;
            string input = Interaction.InputBox("Ingrese la cantidad de productos: ", productos.nombre, "1");
            if (int.TryParse(input, out cantidad))
            {
                if (cantidad <= 0)
                {
                    XtraMessageBox.Show("La cantidad debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cantidad > productos.cantidadStock)
                {
                    XtraMessageBox.Show("No hay suficiente stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ProductosEnCarrito carrito = new ProductosEnCarrito();
                carrito.IDProducto = productos.idProducto;
                carrito.Nombre = productos.nombre;
                carrito.Cantidad = cantidad;
                carrito.Precio = productos.precioUnitario;
                listaProductos.Add(carrito);
                //Activamos los botones
                if(listaProductos.Count != 0)
                {
                    btnLimpiar.Enabled = true;
                    btnFacturar.Enabled = true; 
                }
                CargarProductos();  
                Total = Total + carrito.Subtotal;
                lblTotal.Text = "Total: "+Total.ToString();
            } 
            else
            {
                XtraMessageBox.Show("La cantidad debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnAgregarProducto.Enabled = false;
        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmFacturar1 frm = new frmFacturar1();
            frm.IdUsuario = IdUsuario;
            frm.Total = Total;
            foreach (ProductosEnCarrito item in listaProductos)
                frm.listaProductos.Add(item);
            if(frm.ShowDialog() == DialogResult.OK)
            {
                Limpiar();
                btnFacturar.Enabled = false;
                btnAgregarProducto.Enabled = false;
                btnLimpiar.Enabled=false;
            }
            xpProductos.Reload();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        #endregion
        #region "Eventos de Grid"
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            ProductosEnCarrito productosEnCarrito = (ProductosEnCarrito)gridViewVenta.GetFocusedRow();
            if(productosEnCarrito != null)
            {
                listaProductos.Remove(productosEnCarrito);
                Total = Total - productosEnCarrito.Subtotal;
                lblTotal.Text = "Total: "+Total.ToString();
                CargarProductos();
                if(listaProductos.Count == 0)
                {
                    btnLimpiar.Enabled = false;
                    btnFacturar.Enabled = false;
                }
            }
        }
        private void gridViewProductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Productos productos = (Productos)gridViewProductos.GetFocusedRow();
            if(productos == null)return;
            IdProducto = productos.idProducto;
            btnAgregarProducto.Enabled = true;
        }
        #endregion
    }
}