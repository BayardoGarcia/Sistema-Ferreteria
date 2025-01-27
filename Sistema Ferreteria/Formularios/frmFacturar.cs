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
    public partial class frmFacturar : DevExpress.XtraEditors.XtraForm
    {
        public int idUsuario { get; set; }
        private int idCliente { get; set; }
        public double Total { get; set; }
        public List<ProductosEnCarrito> carritoProductos { get; set; }
        public frmFacturar()
        {
            InitializeComponent();
        }
    }
}