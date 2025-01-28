using DevExpress.XtraEditors;
using Sistema_Ferreteria.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ferreteria.Formularios
{
    public partial class frmFacturar : DevExpress.XtraEditors.XtraForm
    {
        public int idUsuario { get; set; }
        private int idCliente { get; set; }
        public double Total { get; set; }
        public List<ProductosEnCarrito> carritoProductos { get; set; }
        public frmFacturar()
        {
            InitializeComponent();
            carritoProductos = new List<ProductosEnCarrito>();
        }
        private void frmFacturar_Load(object sender, EventArgs e)
        {
            idCliente = -1;
            cboCliente.SelectedIndex = idCliente;
            lblMontoTotal.Text = "Monto Total: "+Total.ToString();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (idCliente == -1)
            {
                XtraMessageBox.Show("Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Ventas nuevaVenta = new Ventas(unitOfWork);
            nuevaVenta.total = Total;
            nuevaVenta.fecha = dtpFecha.Value;
            Clientes cliente = (Clientes)unitOfWork.GetObjectByKey(typeof(Clientes), idCliente);//Probar
            nuevaVenta.cliente = cliente;
            Usuarios usuario = (Usuarios)unitOfWork.GetObjectByKey(typeof(Usuarios), idUsuario);//Probar
            nuevaVenta.usuario = usuario;
            //Produtos del carrito al detalle de la venta
            foreach (ProductosEnCarrito producto in carritoProductos)
            {
                DetallesVenta detalleVenta = new DetallesVenta(unitOfWork);
                detalleVenta.producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), producto.IdProducto);//Probar
                detalleVenta.venta = nuevaVenta;
                detalleVenta.cantidad = producto.Cantidad;
                detalleVenta.precio = producto.Precio;
                detalleVenta.subtotal = producto.Subtotal;
                nuevaVenta.DetallesVentas.Add(detalleVenta);//Probar
            }
            nuevaVenta.Save();
            unitOfWork.CommitChanges();
            ActualizarStock();
            XtraMessageBox.Show("Venta realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ActualizarStock()
        {
            foreach (ProductosEnCarrito p in carritoProductos)
            {
                Productos producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), p.IdProducto);//Probar
                producto.cantidadStock -= p.Cantidad; //Actualizar stock
                producto.Save();
                unitOfWork.CommitChanges();
            }
            xpProductos.Reload();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        private void cboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCliente.SelectedIndex != -1)return;
            idCliente = (int)cboCliente.SelectedValue;
        }
    }
}