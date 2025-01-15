using DevExpress.Xpo;
using DevExpress.XtraEditors;
using Sistema_Ferreteria.Database;
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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        UnitOfWork unit = null;
        XPCollection xpusuario = null;

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                XtraMessageBox.Show("Debe ingresar un usuario y contraseña", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                XtraMessageBox.Show("Debe ingresar un usuario", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                XtraMessageBox.Show("Debe ingresar una contraseña", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            string usuario = txtUsuario.Text.Trim();
            string password = Encrypt.GetMD5String(txtPassword.Text.Trim());

            unit = new UnitOfWork();
            xpusuario = new XPCollection(unit, typeof(Usuarios));
            //Criterios de busqueda
            string criterio = "[usuario]='" + usuario + "' and [password]='" + password + "'"; 
            xpusuario.CriteriaString = criterio;

            if (xpusuario.Count == 0)
            { //Si no  hay resultados
                XtraMessageBox.Show("Error... Credenciales no validas");
                return;
            }
            else
            { //Encuentra al usuario y obtiene su id
                Usuarios user = (Usuarios)xpusuario[0];
                PaginaPrincipal.idUsuario = user.idUsuario;
                this.DialogResult = DialogResult.OK;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}