using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Sistema_Ferreteria.Reportes
{
    public partial class rpdEntradaProductos : DevExpress.XtraReports.UI.XtraReport
    {
        public rpdEntradaProductos()
        {
            InitializeComponent();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }

    }
}
