using DevExpress.Xpo;
using DevExpress.XtraEditors;
using Sistema_Ferreteria.Database;
using Sistema_Ferreteria.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ferreteria
{
    public partial class PaginaPrincipal : DevExpress.XtraEditors.XtraForm
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        internal static int idUsuario;

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin(); //Se crea una instancia del formulario de login
            DialogResult result = frm.ShowDialog(); //Se muestra el formulario de login

            if (result == DialogResult.OK) //Si el resultado del formulario de login es OK
            {
                if (idUsuario != 0)
                {
                    Usuarios usuario = (Usuarios)unitOfWork.GetObjectByKey<Usuarios>(idUsuario);
                    slblUsuario.Caption = "Usuario: " + usuario.nombre;
                    btnLogout.Enabled = true; //Activa el boton para cerrar sesion
                    btnLogin.Enabled = false; //Desactiva el boton para iniciar sesion

                    if (usuario.rol.idRol == 1)
                        ActivarUsuarioAdmin();
                    else if (usuario.rol.idRol == 2)
                        ActivarUsuarioGerencia();
                    else
                        ActivarUsuarioVentas();
                }
            }
        }
    }
}