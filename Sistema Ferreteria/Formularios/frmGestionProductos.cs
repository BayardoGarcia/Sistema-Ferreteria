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
using DevExpress.Xpo.DB.Exceptions;
using Microsoft.VisualBasic;

namespace Sistema_Ferreteria.Formularios
{
    public partial class frmGestionProductos : DevExpress.XtraEditors.XtraForm
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public int IdProveedor { get; set; }
        public bool Editar { get; set; }
        public frmGestionProductos()
        {
            InitializeComponent();
        }
        #region "Eventos de botones"
        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            frmProducto frm = new frmProducto();
            frm.IdProducto = -1;
            frm.Update = false;
            frm.ShowDialog();
            xpProductos.Reload();
        }
        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            Productos producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), IdProducto);
            if(producto == null) return;
            //Editar producto en formulario
            frmProducto frm = new frmProducto();
            frm.IdProducto = producto.idProducto;
            frm.Update = true;
            frm.ShowDialog();
            unitOfWork.Reload(producto);
            xpProductos.Reload();
            btnEditarProducto.Enabled = false;
            btnEliminarProducto.Enabled = false;
            btnModificarStock.Enabled = false;
        }
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            Productos producto = (Productos)gridViewProductos.GetFocusedRow();
            if(producto != null)
            {
                DialogResult result = XtraMessageBox.Show("¿Está seguro de eliminar el producto?", "Sistema Ferreteria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        producto.Delete();
                        unitOfWork.CommitChanges();
                        xpProductos.Reload();
                    }
                    catch(ConstraintViolationException)
                    {
                       XtraMessageBox.Show("No se puede eliminar el producto", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                xpProductos.Reload();
                btnEditarProducto.Enabled = false;
                btnEliminarProducto.Enabled = false;
                btnModificarStock.Enabled = false;
            }
        }
        private void btnModificarStock_Click(object sender, EventArgs e)
        {
            Productos producto = (Productos)unitOfWork.GetObjectByKey(typeof(Productos), IdProducto);
            int stock;
            //Modificar stock
            if (producto != null)
            {
                string input = Interaction.InputBox("Ingrese la cantidad de stock", "Sistema Ferreteria", producto.nombre);
                if (string.IsNullOrEmpty(input)) return;
                if (int.TryParse(input, out stock))
                {
                    if(stock < 0)
                    {
                        XtraMessageBox.Show("El stock no puede ser negativo", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    producto.cantidadStock = stock;
                    unitOfWork.CommitChanges();
                    xpProductos.Reload();
                }
                else
                {
                    XtraMessageBox.Show("Ingrese un valor numérico", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.PrintGridView("Listado de productos", DateTime.Today.ToShortTimeString(), gridViewProductos);
        }
        #endregion
        #region "Eventos del grid"
        private void gridViewProductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Productos productos = (Productos)gridViewProductos.GetFocusedRow();
            if (productos == null) return;
            IdProducto = productos.idProducto;
            //Habilitar botones
            btnEditarProducto.Enabled = true;
            btnEliminarProducto.Enabled = true;
            btnModificarStock.Enabled = true;
        }
        #endregion
    }
}