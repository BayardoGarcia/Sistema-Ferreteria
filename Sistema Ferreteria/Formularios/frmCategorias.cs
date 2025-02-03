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
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        public bool Editar { get; set; }
        public string IdCategoria { get; set; }
        public frmCategorias()
        {
            InitializeComponent();
        }
    }
}