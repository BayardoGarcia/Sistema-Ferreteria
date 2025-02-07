using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace Sistema_Ferreteria.Reportes
{
    public partial class rpdDetallesVentas : DevExpress.XtraReports.UI.XtraReport
    {
        public rpdDetallesVentas()
        {
            InitializeComponent(); 
            lblFecha.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }

    }
}
