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
    public partial class PaginaPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        internal static int idUsuario;//Variable para almacenar el id del usuario que inicio sesion
        public PaginaPrincipal()
        {
            InitializeComponent();
        }
        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema Ferreteria - " + DateTime.Now.ToShortDateString();//Titulo de la ventana
            BlockSubMenu();//Bloquea los submenus
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
                    slblUsuario.Caption = "Usuario: " + usuario.nombre +" " +usuario.apellido;//Muestra el nombre del usuario en el status bar
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
            //Valida si hay una sesion iniciada
            if (idUsuario == 0)
            {   XtraMessageBox.Show("No hay una sesión iniciada", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pregunta si desea cerrar la sesion
            DialogResult result = MessageBox.Show("¿Desea cerrar la sesión?", "Sistema Ferreteria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            //Recorre la colleccion de formularios abiertos
            foreach (Form feach in this.MdiChildren) 
                feach.Close(); //Cierra el formulario abierto
            idUsuario = 0; //No hay usuario con sesion iniciada
            slblUsuario.Caption = "Usuario: ";//Limpia el nombre del usuario en el status bar
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
        private void btnVentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVentas frm = new frmVentas();
            frm.idUsuario = idUsuario;//Se envia el id del usuario que inicio sesion
            frm.MdiParent = this;
            frm.Show();
        }
    }
}