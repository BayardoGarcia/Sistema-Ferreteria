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
            this.btnClientes = new DevExpress.XtraBars.BarButtonItem();
            this.btnGestionProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnEntradasProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnProveedores = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasFecha = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasProducto = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasDetalles = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasDetalleCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnInventario = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductosCero = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductosIngreso = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.btnVisorUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.btnRespaldar = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestaurar = new DevExpress.XtraBars.BarButtonItem();
            this.btnVentasEmpleado = new DevExpress.XtraBars.BarButtonItem();
            this.ribPagUsuario = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPagVenta = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribClientes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribProductos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPagReportes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribPageSistema = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
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
            this.btnProductosIngreso,
            this.btnUsuarios,
            this.btnVisorUsuarios,
            this.btnRespaldar,
            this.btnRestaurar,
            this.btnVentasEmpleado});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 25;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribPagUsuario,
            this.ribPagVenta,
            this.ribPagReportes,
            this.ribPageSistema});
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
            // btnClientes
            // 
            this.btnClientes.Caption = "Clientes";
            this.btnClientes.Id = 7;
            this.btnClientes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.ImageOptions.Image")));
            this.btnClientes.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.ImageOptions.LargeImage")));
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClientes_ItemClick);
            // 
            // btnGestionProductos
            // 
            this.btnGestionProductos.Caption = "Gestion de Productos";
            this.btnGestionProductos.Id = 8;
            this.btnGestionProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGestionProductos.ImageOptions.Image")));
            this.btnGestionProductos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGestionProductos.ImageOptions.LargeImage")));
            this.btnGestionProductos.Name = "btnGestionProductos";
            this.btnGestionProductos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGestionProductos_ItemClick);
            // 
            // btnEntradasProductos
            // 
            this.btnEntradasProductos.Caption = "Entrada de Productos";
            this.btnEntradasProductos.Id = 9;
            this.btnEntradasProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEntradasProductos.ImageOptions.Image")));
            this.btnEntradasProductos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEntradasProductos.ImageOptions.LargeImage")));
            this.btnEntradasProductos.Name = "btnEntradasProductos";
            this.btnEntradasProductos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEntradasProductos_ItemClick);
            // 
            // btnProveedores
            // 
            this.btnProveedores.Caption = "Proveedores";
            this.btnProveedores.Id = 10;
            this.btnProveedores.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.ImageOptions.Image")));
            this.btnProveedores.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.ImageOptions.LargeImage")));
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProveedores_ItemClick);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Caption = "Categorias de Productos";
            this.btnCategorias.Id = 11;
            this.btnCategorias.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.ImageOptions.Image")));
            this.btnCategorias.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCategorias.ImageOptions.LargeImage")));
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategorias_ItemClick);
            // 
            // btnVentasFecha
            // 
            this.btnVentasFecha.Caption = "Ventas por Fecha";
            this.btnVentasFecha.Id = 12;
            this.btnVentasFecha.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVentasFecha.ImageOptions.Image")));
            this.btnVentasFecha.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVentasFecha.ImageOptions.LargeImage")));
            this.btnVentasFecha.Name = "btnVentasFecha";
            this.btnVentasFecha.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVentasFecha_ItemClick);
            // 
            // btnVentasProducto
            // 
            this.btnVentasProducto.Caption = "Ventas por Producto";
            this.btnVentasProducto.Id = 13;
            this.btnVentasProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVentasProducto.ImageOptions.Image")));
            this.btnVentasProducto.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVentasProducto.ImageOptions.LargeImage")));
            this.btnVentasProducto.Name = "btnVentasProducto";
            this.btnVentasProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVentasProducto_ItemClick);
            // 
            // btnVentasCliente
            // 
            this.btnVentasCliente.Caption = "Ventas por Cliente";
            this.btnVentasCliente.Id = 14;
            this.btnVentasCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVentasCliente.ImageOptions.Image")));
            this.btnVentasCliente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVentasCliente.ImageOptions.LargeImage")));
            this.btnVentasCliente.Name = "btnVentasCliente";
            this.btnVentasCliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVentasCliente_ItemClick);
            // 
            // btnVentasDetalles
            // 
            this.btnVentasDetalles.Caption = "Detalles de Venta";
            this.btnVentasDetalles.Id = 15;
            this.btnVentasDetalles.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVentasDetalles.ImageOptions.Image")));
            this.btnVentasDetalles.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVentasDetalles.ImageOptions.LargeImage")));
            this.btnVentasDetalles.Name = "btnVentasDetalles";
            this.btnVentasDetalles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVentasDetalles_ItemClick);
            // 
            // btnVentasDetalleCliente
            // 
            this.btnVentasDetalleCliente.Caption = "Detalles de Venta por Cliente";
            this.btnVentasDetalleCliente.Id = 16;
            this.btnVentasDetalleCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVentasDetalleCliente.ImageOptions.Image")));
            this.btnVentasDetalleCliente.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVentasDetalleCliente.ImageOptions.LargeImage")));
            this.btnVentasDetalleCliente.Name = "btnVentasDetalleCliente";
            this.btnVentasDetalleCliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVentasDetalleCliente_ItemClick);
            // 
            // btnInventario
            // 
            this.btnInventario.Caption = "Inventario";
            this.btnInventario.Id = 17;
            this.btnInventario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.ImageOptions.Image")));
            this.btnInventario.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnInventario.ImageOptions.LargeImage")));
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInventario_ItemClick);
            // 
            // btnProductosCero
            // 
            this.btnProductosCero.Caption = "Productos en Cero";
            this.btnProductosCero.Id = 18;
            this.btnProductosCero.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductosCero.ImageOptions.Image")));
            this.btnProductosCero.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProductosCero.ImageOptions.LargeImage")));
            this.btnProductosCero.Name = "btnProductosCero";
            this.btnProductosCero.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductosCero_ItemClick);
            // 
            // btnProductosIngreso
            // 
            this.btnProductosIngreso.Caption = "Entrada de Productos";
            this.btnProductosIngreso.Id = 19;
            this.btnProductosIngreso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProductosIngreso.ImageOptions.Image")));
            this.btnProductosIngreso.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnProductosIngreso.ImageOptions.LargeImage")));
            this.btnProductosIngreso.Name = "btnProductosIngreso";
            this.btnProductosIngreso.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductosIngreso_ItemClick);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Caption = "Usuarios";
            this.btnUsuarios.Id = 20;
            this.btnUsuarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.ImageOptions.Image")));
            this.btnUsuarios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.ImageOptions.LargeImage")));
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUsuarios_ItemClick);
            // 
            // btnVisorUsuarios
            // 
            this.btnVisorUsuarios.Caption = "Visor de Usuarios";
            this.btnVisorUsuarios.Id = 21;
            this.btnVisorUsuarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVisorUsuarios.ImageOptions.Image")));
            this.btnVisorUsuarios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVisorUsuarios.ImageOptions.LargeImage")));
            this.btnVisorUsuarios.Name = "btnVisorUsuarios";
            this.btnVisorUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVisorUsuarios_ItemClick);
            // 
            // btnRespaldar
            // 
            this.btnRespaldar.Caption = "Respaldar Base de Datos";
            this.btnRespaldar.Id = 22;
            this.btnRespaldar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRespaldar.ImageOptions.Image")));
            this.btnRespaldar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRespaldar.ImageOptions.LargeImage")));
            this.btnRespaldar.Name = "btnRespaldar";
            this.btnRespaldar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRespaldar_ItemClick);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Caption = "Restaurar Base de Datos";
            this.btnRestaurar.Id = 23;
            this.btnRestaurar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.ImageOptions.Image")));
            this.btnRestaurar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.ImageOptions.LargeImage")));
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestaurar_ItemClick);
            // 
            // btnVentasEmpleado
            // 
            this.btnVentasEmpleado.Caption = "Ventas por Empleado";
            this.btnVentasEmpleado.Id = 24;
            this.btnVentasEmpleado.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVentasEmpleado.ImageOptions.Image")));
            this.btnVentasEmpleado.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVentasEmpleado.ImageOptions.LargeImage")));
            this.btnVentasEmpleado.Name = "btnVentasEmpleado";
            this.btnVentasEmpleado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVentasEmpleado_ItemClick);
            // 
            // ribPagUsuario
            // 
            this.ribPagUsuario.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribPagUsuario.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribPagUsuario.ImageOptions.Image")));
            this.ribPagUsuario.Name = "ribPagUsuario";
            this.ribPagUsuario.Text = "Sesion";
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
            this.ribClientes,
            this.ribProductos});
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
            // ribClientes
            // 
            this.ribClientes.ItemLinks.Add(this.btnClientes);
            this.ribClientes.Name = "ribClientes";
            this.ribClientes.Text = "Clientes";
            // 
            // ribProductos
            // 
            this.ribProductos.ItemLinks.Add(this.btnGestionProductos);
            this.ribProductos.ItemLinks.Add(this.btnEntradasProductos);
            this.ribProductos.ItemLinks.Add(this.btnCategorias);
            this.ribProductos.ItemLinks.Add(this.btnProveedores);
            this.ribProductos.Name = "ribProductos";
            this.ribProductos.Text = "Productos";
            // 
            // ribPagReportes
            // 
            this.ribPagReportes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribPagReportes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribPagReportes.ImageOptions.Image")));
            this.ribPagReportes.Name = "ribPagReportes";
            this.ribPagReportes.Text = "Reportes";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasFecha);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasProducto);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasCliente);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasEmpleado);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasDetalles);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnVentasDetalleCliente);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Ventas";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnInventario);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnProductosCero);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnProductosIngreso);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Productos";
            // 
            // ribPageSistema
            // 
            this.ribPageSistema.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup8});
            this.ribPageSistema.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribPageSistema.ImageOptions.Image")));
            this.ribPageSistema.Name = "ribPageSistema";
            this.ribPageSistema.Text = "Sistema";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.btnUsuarios);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnVisorUsuarios);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Usuarios";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnRespaldar);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnRestaurar);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Base de Datos";
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
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPagUsuario;
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribClientes;
        private DevExpress.XtraBars.BarButtonItem btnClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribProductos;
        private DevExpress.XtraBars.BarButtonItem btnGestionProductos;
        private DevExpress.XtraBars.BarButtonItem btnEntradasProductos;
        private DevExpress.XtraBars.BarButtonItem btnProveedores;
        private DevExpress.XtraBars.BarButtonItem btnCategorias;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPagReportes;
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
        private DevExpress.XtraBars.BarButtonItem btnUsuarios;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribPageSistema;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnVisorUsuarios;
        private DevExpress.XtraBars.BarButtonItem btnRespaldar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem btnRestaurar;
        private DevExpress.XtraBars.BarButtonItem btnVentasEmpleado;
    }
}