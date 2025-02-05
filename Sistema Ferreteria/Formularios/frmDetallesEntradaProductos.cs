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
    public partial class frmDetallesEntradaProductos : DevExpress.XtraEditors.XtraForm
    {
        public int IdUsuario { get; set; }
        public frmDetallesEntradaProductos()
        {
            InitializeComponent();
            IdUsuario = -1;
        }

    }
}