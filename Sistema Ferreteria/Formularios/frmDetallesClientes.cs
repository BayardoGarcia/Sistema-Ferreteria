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

namespace Sistema_Ferreteria.Formularios
{
    public partial class frmDetallesClientes : DevExpress.XtraEditors.XtraForm
    {
        public frmDetallesClientes()
        {
            InitializeComponent();
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            ExcelExport excelExport = new ExcelExport();
            excelExport.PrintGridView("Listado de Clientes", DateTime.Today.ToShortDateString(), gridViewClientes);
        }
    }
}