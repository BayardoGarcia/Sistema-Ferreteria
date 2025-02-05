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
    public partial class frmEntradaProducto : DevExpress.XtraEditors.XtraForm
    {
        public int IdUsuario { get; set; }
        public int IdProducto { get; set; }
        public bool IsNuevo { get; set; }
        public double PrecioCompra { get; set; }
        public double Importe { get; set; }
        public frmEntradaProducto()
        {
            InitializeComponent();
            IdProducto = -1;
        }
        private void frmEntradaProducto_Load(object sender, EventArgs e)
        {
            if (IdProducto != -1)
            {
                Productos producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), IdProducto);
                txtProducto.Text = producto.nombre;
                txtProducto.Properties.ReadOnly = true;
                lciProducto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                lciSeleccionProducto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            }
            else
            {
                lciProducto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                lciSeleccionProducto.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            }
        }
        #region "Metodos simples"
        private void slueProducto_EditValueChanged(object sender, EventArgs e)
        {
            Productos producto = (Productos)slueViewProductos.GetFocusedRow();
            if(producto == null)
            {
                return;
            }
            IdProducto = producto.idProducto;
            nudCantidad.Enabled = true;
            txtPrecioCompra.Enabled = true;
        }
        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(nudCantidad.Value);
            Importe = cantidad * PrecioCompra;
            lblImporte.Text = "Importe: " + Importe;
        }
        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextEdit).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        #endregion
        #region "Metodos de guardado"
        private void Guardar()
        {
            EntradaProductos entrada = new EntradaProductos(unitOfWork);
            entrada.fecha = dtpFechaEntrada.Value;
            entrada.producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), IdProducto);
            entrada.cantidad = Convert.ToInt32(nudCantidad.Value);
            entrada.precioCompra = Convert.ToDouble(txtPrecioCompra.Text);
            entrada.importe = Convert.ToDouble(txtImporte.Text);
            entrada.Save();
            unitOfWork.CommitChanges();
            ModificarExistencia();
        }
        private void ModificarExistencia()
        {
            Productos producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), IdProducto);
            int cantidad = Convert.ToInt32(nudCantidad.Value);
            producto.cantidadStock += cantidad;
            producto.Save();
            unitOfWork.CommitChanges();
        }
        #endregion
        #region "Eventos de botones"
        private void btnGuardarEntrada_Click(object sender, EventArgs e)
        {
            if (nudCantidad.Value == 0)
            {
                XtraMessageBox.Show("La cantidad no puede ser 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioCompra.Focus();
                return;
            }
            if (txtPrecioCompra.Text == string.Empty)
            {
                XtraMessageBox.Show("El precio de compra no puede estar vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioCompra.Focus();
                return;
            }
            Guardar();
            this.DialogResult = DialogResult.OK;
        }
        #endregion
    }
}