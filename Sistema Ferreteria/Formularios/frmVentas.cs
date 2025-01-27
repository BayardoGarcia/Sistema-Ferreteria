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


namespace Sistema_Ferreteria.Formularios
{
    public partial class frmVentas : DevExpress.XtraEditors.XtraForm
    {
        public int idProducto { get; set; }
        public int idUsuario { get; set; }
        private double Total { get; set; }
        public List<ProductosEnCarrito> carritoProductos;
        public frmVentas()
        {
            InitializeComponent();
            idUsuario = 1;  //Se asigna un valor por defecto al id del usuario
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            carritoProductos = new List<ProductosEnCarrito>();//Inicializamos la lista de productos
            Total = 0;//Inicializamos el monto total en 0
            LoadGridDetalleVenta();//Cargamos el grid de productos
        }
        private void LoadGridDetalleVenta()
        {
            gridDetalleVenta.DataSource = null;
            gridDetalleVenta.DataSource = carritoProductos;
            gridViewDetalleVenta.Columns[0].Visible = false;
            gridViewDetalleVenta.OptionsView.ColumnAutoWidth = true;
            gridViewDetalleVenta.BestFitColumns();
        }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Productos producto = (Productos)unitOfWork.GetObjectByKey<Productos>(idProducto);//Obtenemos el producto seleccionado
            if (producto == null)return;//Si no se selecciono ningun producto, salimos del metodo
            //Validamos si el producto ya fue agregado a la lista
            int cantidad;
            string input = Interaction.InputBox("Cantidad:", producto.nombre, "1");
            if (!int.TryParse(input, out cantidad))
            {
                if (cantidad <= 0)
                {
                    XtraMessageBox.Show("La cantidad debe ser mayor a 0", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cantidad > producto.cantidadStock)
                {
                    XtraMessageBox.Show("La cantidad supera el stock del producto", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //Si el producto ya fue agregado a la lista, actualizamos la cantidad
                ProductosEnCarrito productoEnCarrito = new ProductosEnCarrito();
                productoEnCarrito.idProducto = producto.idProducto;
                productoEnCarrito.Producto = producto.nombre;
                productoEnCarrito.Cantidad = cantidad;
                productoEnCarrito.Precio = producto.precioUnitario;
                carritoProductos.Add(productoEnCarrito);
                //Habilitamos los botones de facturar y limpiar
                if (carritoProductos.Count != 0)
                {
                    btnFacturar.Enabled = true;
                    btnLimpiarProducto.Enabled = true;
                }
                LoadGridDetalleVenta();
                Total = Total + productoEnCarrito.Subtotal;
                lblMonto.Text = "Total: " + Total.ToString();
            }
            else
            {
                XtraMessageBox.Show("La cantidad debe ser un número entero", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnAgregarProducto.Enabled = false; 
        }
        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            Limppiar();//Se llama al metodo limpiar
        }
        private void Limppiar()
        {
            carritoProductos.Clear();//Limpiamos la lista de productos
            Total = 0;//Reiniciamos el monto total
            LoadGridDetalleVenta();//Cargamos el grid de productos
            lblMonto.Text = "Total: " + Total.ToString();//Mostramos el monto total
            btnFacturar.Enabled = false;//Deshabilitamos el boton de facturar
            btnLimpiarProducto.Enabled = false;//Deshabilitamos el boton de limpiar
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            ProductosEnCarrito carrito = (ProductosEnCarrito)gridViewDetalleVenta.GetFocusedRow();//Obtenemos el producto seleccionado
            if (carrito != null)
            {
                carritoProductos.Remove(carrito);//Eliminamos el producto de la lista
                LoadGridDetalleVenta();//Cargamos el grid de productos
                Total = Total - carrito.Subtotal;//Restamos el subtotal del producto eliminado al monto total
                lblMonto.Text = "Total: " + Total.ToString();//Mostramos el monto total
                if (carritoProductos.Count == 0)
                {
                    btnFacturar.Enabled = false;//Deshabilitamos el boton de facturar
                    btnLimpiarProducto.Enabled = false;//Deshabilitamos el boton de limpiar
                }
            }
            if (carrito == null) return;//Si no se selecciono ningun producto, salimos del metodo
        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            frmFacturar frm = new frmFacturar();//Instanciamos el formulario de facturar
            frm.idUsuario = idUsuario;//Asignamos el id del usuario al formulario de facturar
            frm.Total = Total;//Asignamos el monto total al formulario de facturar
            foreach (ProductosEnCarrito item in carritoProductos)
                frm.carritoProductos.Add(item);//Agregamos los productos al formulario de facturar
            //Mostramos el formulario de facturar
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Limppiar();//Llamamos al metodo limpiar
                btnAgregarProducto.Enabled = false;
                btnFacturar.Enabled = false;
                btnLimpiarProducto.Enabled = false;
            }
            xpProductos.Reload();//Recargamos los productos
        }
        private void gridViewProducto_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Productos producto = (Productos)gridViewProducto.GetFocusedRow();//Obtenemos el producto seleccionado
            if (producto != null)
            {
                idProducto = producto.idProducto;//Asignamos el id del producto seleccionado
                btnAgregarProducto.Enabled = true;//Habilitamos el boton de agregar producto
            }
            if (producto == null) return;//Si no se selecciono ningun producto, salimos del metodo
        }   
    }
}