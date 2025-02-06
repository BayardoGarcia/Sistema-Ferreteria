namespace Sistema_Ferreteria.Formularios
{
    partial class frmGestionProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionProductos));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridProductos = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStripProductos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEditarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarStock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEliminarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidadStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmarca = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNuevoProducto = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportarExcel = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colidEntradaProductos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecioCompra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colimporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.contextMenuStripProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.gridProductos);
            this.layoutControl1.Controls.Add(this.btnNuevoProducto);
            this.layoutControl1.Controls.Add(this.btnExportarExcel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1259, 736);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(480, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(214, 24);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Gestión de Productos";
            // 
            // gridProductos
            // 
            this.gridProductos.ContextMenuStrip = this.contextMenuStripProductos;
            this.gridProductos.DataSource = this.xpProductos;
            this.gridProductos.Location = new System.Drawing.Point(12, 80);
            this.gridProductos.MainView = this.gridViewProductos;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(1235, 604);
            this.gridProductos.TabIndex = 2;
            this.gridProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            // 
            // contextMenuStripProductos
            // 
            this.contextMenuStripProductos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripProductos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditarProducto,
            this.btnEditarStock,
            this.toolStripSeparator1,
            this.btnEliminarProducto});
            this.contextMenuStripProductos.Name = "contextMenuStripProductos";
            this.contextMenuStripProductos.Size = new System.Drawing.Size(197, 82);
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(196, 24);
            this.btnEditarProducto.Text = "Editar Producto";
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnEditarStock
            // 
            this.btnEditarStock.Name = "btnEditarStock";
            this.btnEditarStock.Size = new System.Drawing.Size(196, 24);
            this.btnEditarStock.Text = "Editar Stock";
            this.btnEditarStock.Click += new System.EventHandler(this.btnEditarStock_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(196, 24);
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // xpProductos
            // 
            this.xpProductos.ObjectType = typeof(Sistema_Ferreteria.Database.Productos);
            this.xpProductos.Session = this.unitOfWork;
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre,
            this.gridColumn4,
            this.colprecioUnitario,
            this.colcantidadStock,
            this.gridColumn6,
            this.colmarca});
            this.gridViewProductos.GridControl = this.gridProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewProductos_RowClick);
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Producto";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 25;
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 94;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Categoria";
            this.gridColumn4.FieldName = "categoria!Key";
            this.gridColumn4.MinWidth = 25;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 94;
            // 
            // colprecioUnitario
            // 
            this.colprecioUnitario.Caption = "Precio Venta";
            this.colprecioUnitario.FieldName = "precioUnitario";
            this.colprecioUnitario.MinWidth = 25;
            this.colprecioUnitario.Name = "colprecioUnitario";
            this.colprecioUnitario.Visible = true;
            this.colprecioUnitario.VisibleIndex = 2;
            this.colprecioUnitario.Width = 94;
            // 
            // colcantidadStock
            // 
            this.colcantidadStock.Caption = "Stock";
            this.colcantidadStock.FieldName = "cantidadStock";
            this.colcantidadStock.MinWidth = 25;
            this.colcantidadStock.Name = "colcantidadStock";
            this.colcantidadStock.Visible = true;
            this.colcantidadStock.VisibleIndex = 3;
            this.colcantidadStock.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Proveedor";
            this.gridColumn6.FieldName = "proveedor.nombre";
            this.gridColumn6.MinWidth = 25;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 4;
            this.gridColumn6.Width = 94;
            // 
            // colmarca
            // 
            this.colmarca.Caption = "Marca";
            this.colmarca.FieldName = "marca";
            this.colmarca.MinWidth = 25;
            this.colmarca.Name = "colmarca";
            this.colmarca.Visible = true;
            this.colmarca.VisibleIndex = 5;
            this.colmarca.Width = 94;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProducto.ImageOptions.Image")));
            this.btnNuevoProducto.Location = new System.Drawing.Point(12, 40);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(188, 36);
            this.btnNuevoProducto.StyleController = this.layoutControl1;
            this.btnNuevoProducto.TabIndex = 0;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.ImageOptions.Image")));
            this.btnExportarExcel.Location = new System.Drawing.Point(1024, 688);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(223, 36);
            this.btnExportarExcel.StyleController = this.layoutControl1;
            this.btnExportarExcel.TabIndex = 3;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.emptySpaceItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1259, 736);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnNuevoProducto;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(192, 40);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnExportarExcel;
            this.layoutControlItem3.Location = new System.Drawing.Point(1012, 676);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(227, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 676);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(1012, 40);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridProductos;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1239, 608);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(468, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(218, 28);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(468, 28);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(686, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(553, 28);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(192, 28);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1047, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colidEntradaProductos
            // 
            this.colidEntradaProductos.FieldName = "idEntradaProductos";
            this.colidEntradaProductos.MinWidth = 25;
            this.colidEntradaProductos.Name = "colidEntradaProductos";
            this.colidEntradaProductos.Visible = true;
            this.colidEntradaProductos.VisibleIndex = 0;
            this.colidEntradaProductos.Width = 94;
            // 
            // colfecha
            // 
            this.colfecha.FieldName = "fecha";
            this.colfecha.MinWidth = 25;
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            this.colfecha.Width = 94;
            // 
            // colcantidad
            // 
            this.colcantidad.FieldName = "cantidad";
            this.colcantidad.MinWidth = 25;
            this.colcantidad.Name = "colcantidad";
            this.colcantidad.Visible = true;
            this.colcantidad.VisibleIndex = 2;
            this.colcantidad.Width = 94;
            // 
            // colprecioCompra
            // 
            this.colprecioCompra.FieldName = "precioCompra";
            this.colprecioCompra.MinWidth = 25;
            this.colprecioCompra.Name = "colprecioCompra";
            this.colprecioCompra.Visible = true;
            this.colprecioCompra.VisibleIndex = 3;
            this.colprecioCompra.Width = 94;
            // 
            // colimporte
            // 
            this.colimporte.FieldName = "importe";
            this.colimporte.MinWidth = 25;
            this.colimporte.Name = "colimporte";
            this.colimporte.Visible = true;
            this.colimporte.VisibleIndex = 4;
            this.colimporte.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "producto!";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            this.gridColumn1.Width = 94;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "producto!Key";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            this.gridColumn2.Width = 94;
            // 
            // frmGestionProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 736);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmGestionProductos";
            this.Text = "Gestiónn de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.contextMenuStripProductos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnNuevoProducto;
        private DevExpress.XtraEditors.SimpleButton btnExportarExcel;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.Xpo.UnitOfWork unitOfWork;
        private DevExpress.Xpo.XPCollection xpProductos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProductos;
        private System.Windows.Forms.ToolStripMenuItem btnEditarProducto;
        private System.Windows.Forms.ToolStripMenuItem btnEditarStock;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarProducto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private DevExpress.XtraGrid.Columns.GridColumn colidEntradaProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colprecioCompra;
        private DevExpress.XtraGrid.Columns.GridColumn colimporte;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.GridControl gridProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colprecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidadStock;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn colmarca;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}