using DevExpress.Xpo;
using DevExpress.XtraEditors;
using Sistema_Ferreteria.Database;
using Sistema_Ferreteria.Formularios;
using Sistema_Ferreteria.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistema_Ferreteria
{
    public partial class PaginaPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        internal static int IdUsuario;//Variable para almacenar el id del usuario que inicio sesion
        public PaginaPrincipal()
        {
            InitializeComponent();
        }
        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Sistema Ferreteria - " + DateTime.Now.ToShortDateString();//Titulo de la ventana
            BlockRibPage();//Bloquea los submenus
            IdUsuario = 0;
        }
        #region "Metodos de Inicio de Sesion y Cierre de Sesion"
        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin frm = new frmLogin();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (IdUsuario != 0)
                {
                    Usuarios usuario = (Usuarios)unitOfWork.GetObjectByKey<Usuarios>(IdUsuario);
                    Roles roles = (Roles)unitOfWork.GetObjectByKey<Roles>(usuario.rol.idRol);
                    slblUsuario.Caption = "Usuario: " + usuario.nombre + " " + usuario.apellido + " - " + roles.rol;
                    btnLogout.Enabled = true; //Activa el boton para cerrar sesion
                    btnLogin.Enabled = false; //Desactiva el boton para iniciar sesion
                    if (usuario.rol.idRol == 1)
                        UsuarioAdministrador();
                    else if (usuario.rol.idRol == 2)
                        UsuarioGerencia();
                    else if (usuario.rol.idRol == 3)
                        UsuarioConsultor();
                    else
                        UsuarioVendedor();
                }
            }
        }
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Valida si hay una sesion iniciada
            if (IdUsuario == 0)
            {
                XtraMessageBox.Show("No hay una sesión iniciada", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //Pregunta si desea cerrar la sesion
            DialogResult result = MessageBox.Show("¿Desea cerrar la sesión?", "Sistema Ferreteria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            //Recorre la colleccion de formularios abiertos
            foreach (Form feach in this.MdiChildren)
                feach.Close(); //Cierra el formulario abierto
            IdUsuario = 0; //No hay usuario con sesion iniciada
            slblUsuario.Caption = "Usuario: ";//Limpia el nombre del usuario en el status bar
            btnLogout.Enabled = false; //desactiva el boton para cerrar sesion
            btnLogin.Enabled = true; //activa el boton para iniciar sesion
            BlockRibPage();
        }
        #endregion
        #region "Metodos de validacion de permisos"
        private void BlockRibPage()
        {
            ribPagVenta.Visible = false;
            ribPagReportes.Visible = false;
            ribPageSistema.Visible = false;
        }
        private void UsuarioAdministrador()
        {
            ribPageSistema.Visible = true;
            ribPagReportes.Visible = true;
            ribPagVenta.Visible = true;
            ribProductos.Visible = true;
        }
        private void UsuarioGerencia()
        {
            ribPagVenta.Visible = true;
            ribPagReportes.Visible = true;
            ribProductos.Visible = true;
        }
        private void UsuarioConsultor()
        {
            ribPagReportes.Visible = true;
        }
        private void UsuarioVendedor()
        {
            ribPagVenta.Visible = true;
            ribProductos.Visible = false;
        }
        #endregion
        #region "Metodos de gestion de base de datos"
        private void Backup(string route)
        {
            string constring = @"server=localhost; user id=root; password=root; database=ferreteria_db";
            string file = route;
            using (MySqlConnection cons = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = cons;
                        cons.Open();
                        mb.ExportToFile(file);
                        cons.Close();
                    }
                }
            }
        }
        private void Restore(string route)
        {
            string constring = @"server=localhost; user id=root; password=root; database=ferreteria_db";
            string file = route;
            using (MySqlConnection cons = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = cons;
                        cons.Open();
                        mb.ImportFromFile(file);
                        cons.Close();
                    }
                }
            }
        }
        #endregion
        #region "Metodos de los botones del menu Principal"
        private void btnVentas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmVentas frm = new frmVentas();
            frm.IdUsuario = IdUsuario;//Se envia el id del usuario que inicio sesion
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnClientes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnGestionProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGestionProductos frm = new frmGestionProductos();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnEntradasProductos_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDetallesEntradaProductos frm = new frmDetallesEntradaProductos();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnCategorias_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmCategorias frm = new frmCategorias();
            frm.MdiParent = this;   
            frm.Show();
        }
        private void btnProveedores_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.MdiParent = this;
            frm.Show();
        }
        #endregion
        #region "Metodos de los botones del menu de reportes"
        private void btnVentasFecha_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpvVentasFecha rpv = new rpvVentasFecha();
            rpv.MdiParent = this;
            rpv.Show();
        }
        private void btnVentasProducto_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpvVentasProducto rpv = new rpvVentasProducto();
            rpv.MdiParent = this;
            rpv.Show();
        }
        private void btnVentasCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpvVentasClientes rpv = new rpvVentasClientes();
            rpv.MdiParent = this;
            rpv.Show();
        }
        private void btnVentasEmpleado_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpvVentasEmpleado rpv = new rpvVentasEmpleado();
            rpv.MdiParent = this;
            rpv.Show();
        }
        private void btnVentasDetalles_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpvDetallesVenta rpv = new rpvDetallesVenta();
            rpv.MdiParent = this;
            rpv.Show();
        }
        private void btnVentasDetalleCliente_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpvDetallesVentasCliente rpv = new rpvDetallesVentasCliente();
            rpv.MdiParent = this;
            rpv.Show();
        }
        private void btnInventario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpvInventario rpv = new rpvInventario();
            rpv.MdiParent = this;
            rpv.Show();
        }
        private void btnProductosCero_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpvProductosCero rpv = new rpvProductosCero();  
            rpv.MdiParent = this;
            rpv.Show();
        }
        private void btnProductosIngreso_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            rpvEntradasProductos rpv = new rpvEntradasProductos();
            rpv.MdiParent = this;
            rpv.Show();
        }
        #endregion
        #region "Metodos de los botones del menu de sistema"
        private void btnUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmUsuario frm = new frmUsuario();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnVisorUsuarios_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmDetallesUsuarios frm = new frmDetallesUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }
        private void btnRespaldar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Respaldo de Base de Datos - ferreteria_db";
            save.Filter = "SQL File|*.sql";
            save.FileName = "Respaldo_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm-ss") + ".sql";
            if (save.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            Backup(save.FileName);
            XtraMessageBox.Show("Respaldo de la base de datos realizado con exito", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnRestaurar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Title = "Restaurar Base de Datos - ferreteria_db";
            open.Filter = "SQL File|*.sql";
            if (open.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            Restore(open.FileName);
            XtraMessageBox.Show("Restauracion de la base de datos realizada con exito", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}