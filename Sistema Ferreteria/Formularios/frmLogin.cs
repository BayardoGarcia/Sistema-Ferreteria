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
            string criterio = "[usuario]='" + usuario + "' and [password]='" + password + "'"; //criterio de busqueda
            xpusuario.CriteriaString = criterio;

            if (xpusuario.Count == 0)
            { //Si no  hay resultados
                XtraMessageBox.Show("Error... Credenciales no validas");
                return;
            }
            else
            { //Se encontro al usuario

                Usuarios user = (Usuarios)xpusuario[0];//obtiene los datos del usuario
                MainMenu.idUsuario = user.idUsuario;
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
                //this.DialogResult = DialogResult.OK; //Devuelve OK al formulario principal
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}