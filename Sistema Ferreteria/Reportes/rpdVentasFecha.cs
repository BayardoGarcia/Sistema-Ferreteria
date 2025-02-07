using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Sistema_Ferreteria.Reportes
{
    public partial class rpdVentasFecha : DevExpress.XtraReports.UI.XtraReport
    {
        public rpdVentasFecha()
        {
            InitializeComponent();
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }

    }
}
