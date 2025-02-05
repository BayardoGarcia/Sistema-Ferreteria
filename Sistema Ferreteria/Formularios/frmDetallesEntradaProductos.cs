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
using DevExpress.Xpo;
using Sistema_Ferreteria.Database;

namespace Sistema_Ferreteria.Formularios
{
    public partial class frmDetallesEntradaProductos : DevExpress.XtraEditors.XtraForm
    {
        public int IdProducto { get; set; }
        public frmDetallesEntradaProductos()
        {
            InitializeComponent();
            IdProducto = -1;
        }
        #region "Eventos Botones"
        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExcelExport grid = new ExcelExport();
            grid.PrintGridView("Entrada de Productos", DateTime.Today.ToShortDateString(),gridViewEntradaProductos);
        }
        private void btnNuevaEntrada_Click(object sender, EventArgs e)
        {
            frmEntradaProducto frm = new frmEntradaProducto();
            frm.IdProducto = IdProducto;
            frm.ShowDialog();
            xpEntradaProductos.Reload();
        }
        #endregion
        #region "Eventos Formulario"
        private void gridViewEntradaProductos_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            EntradaProductos entrada = (EntradaProductos)gridViewEntradaProductos.GetFocusedRow();
            if(entrada == null) return;
            IdProducto = entrada.producto.idProducto;
        }
        #endregion
    }
}