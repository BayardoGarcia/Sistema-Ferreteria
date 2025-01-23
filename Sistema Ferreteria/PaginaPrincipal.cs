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
        internal static int idUsuario;
        public PaginaPrincipal()
        {
            InitializeComponent();
        }
        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema Ferreteria - " + DateTime.Now.ToShortDateString();
            BlockSubMenu();
            idUsuario = 0;
        }
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
                        ActivarPrivilegioAdmin();
                    else if (usuario.rol.idRol == 2)
                        ActivarPrivilegioGerencia();
                    else
                        ActivarPrivilegioVentas();
                }
            }
        }
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (idUsuario == 0)
            {   XtraMessageBox.Show("No hay una sesión iniciada", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("¿Desea cerrar la sesión?", "Sistema Ferreteria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            foreach (Form feach in this.MdiChildren) //Recorre la colleccion de formularios abiertos
                feach.Close(); //Cierra el formulario abierto

            idUsuario = 0; //No hay usuario con sesion iniciada
            slblUsuario.Caption = "Usuario: ";
            btnLogout.Enabled = false; //desactiva el boton para cerrar sesion
            btnLogin.Enabled = true; //activa el boton para iniciar sesion
            BlockSubMenu();
        }
        private void BlockSubMenu()
        {
            //Agregar bloqueos a los submenus
        }
        private void ActivarPrivilegioAdmin()
        {
            //Activar los submenus para el administrador
        }
        private void ActivarPrivilegioGerencia()
        {
            //Activar los submenus para la gerencia
        }
            private void ActivarPrivilegioVentas()
        {
            //Activar los submenus para ventas
        }   
    }
}