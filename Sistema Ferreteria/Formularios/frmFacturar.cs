using DevExpress.XtraEditors;
using Sistema_Ferreteria.Database;
using Sistema_Ferreteria.Funciones;
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
        public int IdUsuario { get; set; }
        private int IdCliente { get; set; }
        public double Total { get; set; }
        public List<ListaProducto> listaProductos { get; set; }
        public frmFacturar()
        {
            InitializeComponent();
            listaProductos = new List<ListaProducto>();
        }
        private void frmFacturar_Load(object sender, EventArgs e)
        {
            IdCliente = -1;
            cboCliente.SelectedIndex = IdCliente;
            lblTotal.Text = "Monto Total: "+Total.ToString();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IdCliente = (int)cboCliente.SelectedValue;
            if (IdCliente == -1)
            {
                XtraMessageBox.Show("Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Ventas nuevaVenta = new Ventas(unitOfWork);
            nuevaVenta.total = Total;
            nuevaVenta.fecha = dtpFecha.Value;
            Clientes cliente = (Clientes)unitOfWork.GetObjectByKey(typeof(Clientes), IdCliente);
            nuevaVenta.cliente = cliente;
            Usuarios usuario = (Usuarios)unitOfWork.GetObjectByKey(typeof(Usuarios), IdUsuario);
            nuevaVenta.usuario = usuario;
            //Produtos del carrito al detalle de la venta
            foreach (ListaProducto producto in listaProductos)
            {
                DetallesVenta detalleVenta = new DetallesVenta(unitOfWork);
                detalleVenta.producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), producto.ProductoId);
                detalleVenta.venta = nuevaVenta;
                detalleVenta.cantidad = producto.Cantidad;
                detalleVenta.precio = producto.Precio;
                detalleVenta.subtotal = producto.Importe;
                nuevaVenta.DetallesVentas.Add(detalleVenta);
            }
            nuevaVenta.Save();
            unitOfWork.CommitChanges();
            ActualizarStock();
            XtraMessageBox.Show("Venta realizada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ActualizarStock()
        {
            foreach (ListaProducto p in listaProductos)
            {
                Productos producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), p.ProductoId);//Probar
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
            IdCliente = (int)cboCliente.SelectedValue;
        }
    }
}