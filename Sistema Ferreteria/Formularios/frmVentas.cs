using DevExpress.XtraEditors;
using DevExpress.Xpo;
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
using Sistema_Ferreteria.Funciones;


namespace Sistema_Ferreteria.Formularios
{
    public partial class frmVentas : DevExpress.XtraEditors.XtraForm
    {
        public int IdProducto { get; set; }
        public int IdUsuario { get; set; }
        public double Total { get; set; }
        public List<ListaProducto> listaProductos;
        public frmVentas()
        {
            InitializeComponent();
            IdProducto = -1;
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            Total = 0;
            listaProductos = new List<ListaProducto>();
            LoadGridDetalleVenta();
        }
        #region "Metodos"
        private void LoadGridDetalleVenta()
        {
            gridDetalleVenta.DataSource = null;
            gridDetalleVenta.DataSource = listaProductos;
            gridViewDetalleVenta.Columns[0].Visible = false;
            gridViewDetalleVenta.OptionsView.ColumnAutoWidth = true;
            gridViewDetalleVenta.BestFitColumns();
        }
        private void Limpiar()
        {
            lblMonto.Text = "Total: " + (Total = 0).ToString();
            listaProductos.Clear();
            LoadGridDetalleVenta();
        }
        private void gridViewProducto_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Productos producto = (Productos)gridViewProducto.GetFocusedRow();
            if (producto == null) return;
            IdProducto = producto.idProducto;
            btnAgregarProducto.Enabled = true;
            gridViewProducto.UpdateCurrentRow();
        }
        #endregion
        #region "Eventos de botones"
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Productos productos = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), IdProducto);
            if (productos == null) return;
            int cantidad;
            string input = Interaction.InputBox("Ingrese la cantidad de productos", productos.nombre , "1");
            if (int.TryParse(input, out cantidad))
            {
                if (cantidad <= 0)
                {
                    XtraMessageBox.Show("La cantidad debe ser mayor a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cantidad > productos.cantidadStock)
                {
                    XtraMessageBox.Show("No hay suficiente cantidad de productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ListaProducto listaProducto = new ListaProducto();
                listaProducto.ProductoId = productos.idProducto;
                listaProducto.Producto = productos.nombre;
                listaProducto.Cantidad = cantidad;
                listaProducto.Precio = productos.precioUnitario;
                listaProductos.Add(listaProducto);
                if (listaProductos.Count != 0)
                {
                    btnFacturar.Enabled = true;
                    btnLimpiarProducto.Enabled = true;
                }
                LoadGridDetalleVenta();
                Total = Total + listaProducto.Importe;
                lblMonto.Text = "Total: " + Total.ToString();
                this.xpProductos.Reload();
            }
            else
            {
                XtraMessageBox.Show("El valor no es valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnAgregarProducto.Enabled = false;
            xpProductos.Reload();
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            ListaProducto listaP = (ListaProducto)gridViewDetalleVenta.GetFocusedRow();
            if (listaP != null)
            {
                listaProductos.Remove(listaP);
                LoadGridDetalleVenta();
                Total = Total - listaP.Importe;
                lblMonto.Text = "Total: " + Total.ToString();
                if (listaProductos.Count == 0)
                {
                    btnFacturar.Enabled = false;
                    btnLimpiarProducto.Enabled = false;
                }
            }
        }
        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmFacturar frm = new frmFacturar();
            frm.IdUsuario = IdUsuario;
            frm.Total = Total;
            foreach(ListaProducto p in listaProductos)
                frm.listaProductos.Add(p);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Limpiar();
                btnFacturar.Enabled = false;
                btnLimpiarProducto.Enabled = false;
                btnAgregarProducto.Enabled = false;
            }
            this.xpProductos.Reload();
            gridProducto.RefreshDataSource();
            gridViewProducto.RefreshData();
            gridProducto.Update();
        }
        #endregion
    }
}