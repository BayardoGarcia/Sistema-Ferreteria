namespace Sistema_Ferreteria
{
    partial class PaginaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaginaPrincipal));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.slblUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.btnVentas = new DevExpress.XtraBars.BarButtonItem();
            this.ribPageUsuario = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPagVenta = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnGestionProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnEntradasProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnProveedores = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnVentasFecha = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasDetalles = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasDetalleCliente = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnInventario = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductosCero = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductosIngreso = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionBarItemLinks.Add(this.skinDropDownButtonItem1);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinDropDownButtonItem1,
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnLogin,
            this.btnLogout,
            this.slblUsuario,
            this.btnVentas,
            this.btnClientes,
            this.btnGestionProductos,
            this.btnEntradasProductos,
            this.btnProveedores,
            this.btnCategorias,
            this.btnVentasFecha,
            this.btnVentasProducto,
            this.btnVentasCliente,
            this.btnVentasDetalles,
            this.btnVentasDetalleCliente,
            this.btnInventario,
            this.btnProductosCero,
            this.btnProductosIngreso});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 20;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribPageUsuario,
            this.ribPagVenta,
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1137, 209);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 5;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Iniciar Sesión";
            this.btnLogin.Id = 2;
            this.btnLogin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.Image")));
            this.btnLogin.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.ImageOptions.LargeImage")));
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogin_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Cerrar Sesión";
            this.btnLogout.Id = 3;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // slblUsuario
            // 
            this.slblUsuario.Caption = "Usuario:";
            this.slblUsuario.Id = 4;
            this.slblUsuario.Name = "slblUsuario";
            // 
            // btnVentas
            // 
            this.btnVentas.Caption = "Realizar Venta";
            this.btnVentas.Id = 6;
            this.btnVentas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.ImageOptions.Image")));
            this.btnVentas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.ImageOptions.LargeImage")));
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVentas_ItemClick);
            // 
            // ribPageUsuario
            // 
            this.ribPageUsuario.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribPageUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribPageUsuario.ImageOptions.Image")));
            this.ribPageUsuario.Name = "ribPageUsuario";
            this.ribPageUsuario.Text = "Sesion";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Sesion Usuario";
            // 
            // ribPagVenta
            // 
            this.ribPagVenta.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribPagVenta.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribPagVenta.ImageOptions.Image")));
            this.ribPagVenta.Name = "ribPagVenta";
            this.ribPagVenta.Text = "Principal";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnVentas);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Ventas";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.slblUsuario);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 698);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1137, 30);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // documentManager
            // 
            this.documentManager.MdiParent = this;
            this.documentManager.MenuManager = this.ribbonControl1;
            this.documentManager.View = this.tabbedView1;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnClientes);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Clientes";
            // 
            // btnClientes
            // 
            this.btnClientes.Caption = "Clientes";
            this.btnClientes.Id = 7;
            this.btnClientes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnClientes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnClientes.Name = "btnClientes";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnGestionProductos);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnEntradasProductos);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCategorias);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProveedores);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Productos";
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.Caption = "Gestion de Productos";
            this.btnGestionProductos.Id = 8;
            this.btnGestionProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image1")));
            this.btnGestionProductos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage1")));
            this.btnGestionProductos.Name = "btnGestionProductos";
            // 
            // btnEntradasProductos
            // 
            this.btnEntradasProductos.Caption = "Entrada de Productos";
            this.btnEntradasProductos.Id = 9;
            this.btnEntradasProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image2")));
            this.btnEntradasProductos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage2")));
            this.btnEntradasProductos.Name = "btnEntradasProductos";
            // 
            // btnProveedores
            // 
            this.btnProveedores.Caption = "Proveedores";
            this.btnProveedores.Id = 10;
            this.btnProveedores.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.ImageOptions.Image")));
            this.btnProveedores.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.ImageOptions.LargeImage")));
            this.btnProveedores.Name = "btnProveedores";
            // 
            // btnCategorias
            // 
            this.btnCategorias.Caption = "Categorias de Productos";
            this.btnCategorias.Id = 11;
            this.btnCategorias.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image3")));
            this.btnCategorias.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage3")));
            this.btnCategorias.Name = "btnCategorias";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Reportes";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasFecha);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasProducto);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasCliente);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasDetalles);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasDetalleCliente);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Ventas";
            // 
            // btnVentasFecha
            // 
            this.btnVentasFecha.Caption = "Ventas por Fecha";
            this.btnVentasFecha.Id = 12;
            this.btnVentasFecha.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.btnVentasFecha.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.btnVentasFecha.Name = "btnVentasFecha";
            // 
            // btnVentasProducto
            // 
            this.btnVentasProducto.Caption = "Ventas por Producto";
            this.btnVentasProducto.Id = 13;
            this.btnVentasProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image4")));
            this.btnVentasProducto.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage4")));
            this.btnVentasProducto.Name = "btnVentasProducto";
            // 
            // btnVentasCliente
            // 
            this.btnVentasCliente.Caption = "Ventas por Empleado";
            this.btnVentasCliente.Id = 14;
            this.btnVentasCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image5")));
            this.btnVentasCliente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage5")));
            this.btnVentasCliente.Name = "btnVentasCliente";
            // 
            // btnVentasDetalles
            // 
            this.btnVentasDetalles.Caption = "Detalles de Venta";
            this.btnVentasDetalles.Id = 15;
            this.btnVentasDetalles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image6")));
            this.btnVentasDetalles.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage6")));
            this.btnVentasDetalles.Name = "btnVentasDetalles";
            // 
            // btnVentasDetalleCliente
            // 
            this.btnVentasDetalleCliente.Caption = "Detalles de Venta por Cliente";
            this.btnVentasDetalleCliente.Id = 16;
            this.btnVentasDetalleCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image1")));
            this.btnVentasDetalleCliente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage1")));
            this.btnVentasDetalleCliente.Name = "btnVentasDetalleCliente";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnInventario);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnProductosCero);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnProductosIngreso);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Productos";
            // 
            // btnInventario
            // 
            this.btnInventario.Caption = "Inventario";
            this.btnInventario.Id = 17;
            this.btnInventario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image7")));
            this.btnInventario.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage7")));
            this.btnInventario.Name = "btnInventario";
            // 
            // btnProductosCero
            // 
            this.btnProductosCero.Caption = "Productos en Cero";
            this.btnProductosCero.Id = 18;
            this.btnProductosCero.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image2")));
            this.btnProductosCero.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage2")));
            this.btnProductosCero.Name = "btnProductosCero";
            // 
            // btnProductosIngreso
            // 
            this.btnProductosIngreso.Caption = "Entrada de Productos";
            this.btnProductosIngreso.Id = 19;
            this.btnProductosIngreso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image8")));
            this.btnProductosIngreso.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage8")));
            this.btnProductosIngreso.Name = "btnProductosIngreso";
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 728);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "PaginaPrincipal";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "MainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPageUsuario;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.Xpo.UnitOfWork unitOfWork;
        private DevExpress.XtraBars.BarStaticItem slblUsuario;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPagVenta;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnVentas;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnGestionProductos;
        private DevExpress.XtraBars.BarButtonItem btnEntradasProductos;
        private DevExpress.XtraBars.BarButtonItem btnProveedores;
        private DevExpress.XtraBars.BarButtonItem btnCategorias;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnVentasFecha;
        private DevExpress.XtraBars.BarButtonItem btnVentasProducto;
        private DevExpress.XtraBars.BarButtonItem btnVentasCliente;
        private DevExpress.XtraBars.BarButtonItem btnVentasDetalles;
        private DevExpress.XtraBars.BarButtonItem btnVentasDetalleCliente;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnInventario;
        private DevExpress.XtraBars.BarButtonItem btnProductosCero;
        private DevExpress.XtraBars.BarButtonItem btnProductosIngreso;
    }
}