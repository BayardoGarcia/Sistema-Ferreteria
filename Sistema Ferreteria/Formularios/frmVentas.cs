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
        public List<DetallesVenta> listProductos;
        public frmVentas()
        {
            InitializeComponent();
            idUsuario = 1;  //Se asigna un valor por defecto al id del usuario
        }
        private void frmVentas_Load(object sender, EventArgs e)
        {
            listProductos = new List<DetallesVenta>();//Inicializamos la lista de productos
            Total = 0;//Inicializamos el monto total en 0
            LoadGridDetalleVenta();//Cargamos el grid de productos
        }
        private void LoadGridDetalleVenta()
        {
            gridDetalleVenta.DataSource = null;
            gridDetalleVenta.DataSource = listProductos;
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
                //Agregamos el producto a la lista
                UnitOfWork unit = new UnitOfWork();
                DetallesVenta detalle = new DetallesVenta(unit);
                detalle.producto = (int)producto.idProducto;
                detalle.nombreProducto = producto.nombre;
                detalle.cantidad = cantidad;
                detalle.precioUnitario = producto.precioVenta;
                listProductos.Add(detalle);
            }

        }
    }
}