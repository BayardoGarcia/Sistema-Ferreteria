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

namespace Sistema_Ferreteria.Formularios
{
    public partial class frmProducto : DevExpress.XtraEditors.XtraForm
    {
        public int IdProducto { get; set; }
        private int IdCategoria { get; set; }
        private int IdProveedor { get; set; }
        public bool Update { get; set; }
        public frmProducto()
        {
            InitializeComponent();
            IdCategoria = -1;
            IdProveedor = -1;
        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            if (Update == true)
            {
                CargarDatosProducto();
            }
        }
        #region "Metodos de validacion"
        private void nudStock_Validating(object sender, CancelEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            int stock;
            try
            {
                stock = int.Parse(txt.Text);
            }
            catch (Exception)
            {
                txt.SelectAll();
                XtraMessageBox.Show("El campo stock debe ser un valor numerico", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        private void txtPrecio_Validating(object sender, CancelEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            double precio;
            try
            {
                precio = double.Parse(txt.Text);
            }
            catch (Exception)
            {
                txt.SelectAll();
                XtraMessageBox.Show("El campo precio debe ser un valor numerico", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
        }
        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            if (comboBox.SelectedIndex == -1)
            {
                return;
            }
            IdCategoria = Convert.ToInt32(comboBox.SelectedValue);
        }
        private void cboProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            if (comboBox.SelectedIndex == -1)
            {
                return;
            }
            IdProveedor = Convert.ToInt32(comboBox.SelectedValue);
        }
        #endregion
        #region "Metodos de gestion de datos"
        private void CargarDatosProducto()
        {
            Productos producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), IdProducto);
            txtNombreProducto.Text = producto.nombre;
            txtDescripcionProducto.Text = producto.descripcion;
            txtMarca.Text = producto.marca;
            nudStock.Value = producto.cantidadStock;
            txtPrecio.Text = producto.precioUnitario.ToString();
            IdCategoria = producto.categoria.idCategoria;
            IdProveedor = producto.proveedor.idProveedor;
            cboCategoria.Text = producto.categoria.nombre;
            cboProveedor.Text = producto.proveedor.nombre;
        }
        private void ActualizarDatosProducto()
        {
            Productos producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), IdProducto);
            producto.nombre = txtNombreProducto.Text;
            producto.descripcion = txtDescripcionProducto.Text;
            producto.marca = txtMarca.Text;
            producto.cantidadStock = Convert.ToInt32(nudStock.Value);
            producto.precioUnitario = double.Parse(txtPrecio.Text.ToString());
            Proveedores proveedor = (Proveedores)unitOfWork.GetObjectByKey(typeof(Proveedores), IdProveedor);
            producto.proveedor = proveedor;
            Categorias categoria = (Categorias)unitOfWork.GetObjectByKey(typeof(Categorias), IdCategoria);
            producto.categoria = categoria;
            producto.Save();
            unitOfWork.CommitChanges();
        }
        private void GuardarDatosProducto()
        {
            Productos producto = new Productos(unitOfWork);
            producto.nombre = txtNombreProducto.Text;
            producto.descripcion = txtDescripcionProducto.Text;
            producto.marca = txtMarca.Text;
            producto.cantidadStock = Convert.ToInt32(nudStock.Value);
            producto.precioUnitario = double.Parse(txtPrecio.Text.ToString());
            Proveedores proveedor = (Proveedores)unitOfWork.GetObjectByKey(typeof(Proveedores), IdProveedor);
            producto.proveedor = proveedor;
            Categorias categoria = (Categorias)unitOfWork.GetObjectByKey(typeof(Categorias), IdCategoria);
            producto.categoria = categoria;
            producto.Save();
            unitOfWork.CommitChanges();
        }
        #endregion
        #region "Eventos de botones"
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreProducto.Text))
            {
                XtraMessageBox.Show("El campo nombre no puede estar vacio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionProducto.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtDescripcionProducto.Text))
            {
                XtraMessageBox.Show("El campo descripcion no puede estar vacio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionProducto.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                XtraMessageBox.Show("El campo marca no puede estar vacio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMarca.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPrecio.Text))
            {
                XtraMessageBox.Show("El campo precio no puede estar vacio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }
            if (IdCategoria == -1)
            {
                XtraMessageBox.Show("Debe seleccionar una categoria", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCategoria.Focus();
                return;
            }
            if (IdProveedor == -1)
            {
                XtraMessageBox.Show("Debe seleccionar un proveedor", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProveedor.Focus();
                return;
            }
            if (Update == true)
            {
                ActualizarDatosProducto();
            }
            else
            {
                GuardarDatosProducto();
            }
            xpProductos.Reload();
            this.DialogResult = DialogResult.OK;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion
    }
}