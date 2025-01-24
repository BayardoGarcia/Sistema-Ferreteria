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
    public partial class frmVentas : DevExpress.XtraEditors.XtraForm
    {
        public int idProducto { get; set; }
        public int idUsuario { get; set; }
        private double MontoTotal { get; set; }
        public frmVentas()
        {
            InitializeComponent();
        }
    }
}