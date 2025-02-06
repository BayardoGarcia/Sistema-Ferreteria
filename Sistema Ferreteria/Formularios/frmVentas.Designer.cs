namespace Sistema_Ferreteria.Formularios
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lblMonto = new DevExpress.XtraEditors.LabelControl();
            this.gridDetalleVenta = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalleVenta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.contextMenuStripDetalleVenta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEliminarProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.gridProducto = new DevExpress.XtraGrid.GridControl();
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.gridViewProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colprecioUnitario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcantidadStock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAgregarProducto = new DevExpress.XtraEditors.SimpleButton();
            this.btnLimpiarProducto = new DevExpress.XtraEditors.SimpleButton();
            this.btnFacturar = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleVenta)).BeginInit();
            this.contextMenuStripDetalleVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblMonto);
            this.layoutControl1.Controls.Add(this.gridDetalleVenta);
            this.layoutControl1.Controls.Add(this.gridProducto);
            this.layoutControl1.Controls.Add(this.btnAgregarProducto);
            this.layoutControl1.Controls.Add(this.btnLimpiarProducto);
            this.layoutControl1.Controls.Add(this.btnFacturar);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1019, 258, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(958, 652);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblMonto
            // 
            this.lblMonto.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Appearance.Options.UseFont = true;
            this.lblMonto.Location = new System.Drawing.Point(12, 566);
            this.lblMonto.Margin = new System.Windows.Forms.Padding(2);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(53, 24);
            this.lblMonto.StyleController = this.layoutControl1;
            this.lblMonto.TabIndex = 7;
            this.lblMonto.Text = "Total:";
            // 
            // gridDetalleVenta
            // 
            this.gridDetalleVenta.ContextMenuStrip = this.contextMenuStripDetalleVenta;
            this.gridDetalleVenta.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridDetalleVenta.Location = new System.Drawing.Point(12, 347);
            this.gridDetalleVenta.MainView = this.gridViewDetalleVenta;
            this.gridDetalleVenta.Margin = new System.Windows.Forms.Padding(2);
            this.gridDetalleVenta.Name = "gridDetalleVenta";
            this.gridDetalleVenta.Size = new System.Drawing.Size(934, 215);
            this.gridDetalleVenta.TabIndex = 6;
            this.gridDetalleVenta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleVenta});
            // 
            // gridViewDetalleVenta
            // 
            this.gridViewDetalleVenta.DetailHeight = 233;
            this.gridViewDetalleVenta.GridControl = this.gridDetalleVenta;
            this.gridViewDetalleVenta.Name = "gridViewDetalleVenta";
            // 
            // contextMenuStripDetalleVenta
            // 
            this.contextMenuStripDetalleVenta.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDetalleVenta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEliminarProducto});
            this.contextMenuStripDetalleVenta.Name = "contextMenuStripDetalleVenta";
            this.contextMenuStripDetalleVenta.Size = new System.Drawing.Size(197, 28);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(196, 24);
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // gridProducto
            // 
            this.gridProducto.DataSource = this.xpProductos;
            this.gridProducto.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridProducto.Location = new System.Drawing.Point(12, 12);
            this.gridProducto.MainView = this.gridViewProducto;
            this.gridProducto.Margin = new System.Windows.Forms.Padding(2);
            this.gridProducto.Name = "gridProducto";
            this.gridProducto.Size = new System.Drawing.Size(934, 291);
            this.gridProducto.TabIndex = 4;
            this.gridProducto.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducto});
            // 
            // xpProductos
            // 
            this.xpProductos.ObjectType = typeof(Sistema_Ferreteria.Database.Productos);
            this.xpProductos.Session = this.unitOfWork;
            // 
            // gridViewProducto
            // 
            this.gridViewProducto.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre,
            this.gridColumn2,
            this.colprecioUnitario,
            this.colcantidadStock,
            this.gridColumn4});
            this.gridViewProducto.DetailHeight = 233;
            this.gridViewProducto.GridControl = this.gridProducto;
            this.gridViewProducto.Name = "gridViewProducto";
            this.gridViewProducto.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewProducto_RowClick);
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 16;
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 60;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Categoria";
            this.gridColumn2.FieldName = "categoria.nombre";
            this.gridColumn2.MinWidth = 16;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 60;
            // 
            // colprecioUnitario
            // 
            this.colprecioUnitario.Caption = "Precio";
            this.colprecioUnitario.FieldName = "precioUnitario";
            this.colprecioUnitario.MinWidth = 16;
            this.colprecioUnitario.Name = "colprecioUnitario";
            this.colprecioUnitario.Visible = true;
            this.colprecioUnitario.VisibleIndex = 2;
            this.colprecioUnitario.Width = 60;
            // 
            // colcantidadStock
            // 
            this.colcantidadStock.Caption = "Stock";
            this.colcantidadStock.FieldName = "cantidadStock";
            this.colcantidadStock.MinWidth = 16;
            this.colcantidadStock.Name = "colcantidadStock";
            this.colcantidadStock.Visible = true;
            this.colcantidadStock.VisibleIndex = 3;
            this.colcantidadStock.Width = 60;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Proveedor";
            this.gridColumn4.FieldName = "proveedor.nombre";
            this.gridColumn4.MinWidth = 16;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 60;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Appearance.Options.UseFont = true;
            this.btnAgregarProducto.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnAgregarProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarProducto.ImageOptions.Image")));
            this.btnAgregarProducto.Location = new System.Drawing.Point(12, 307);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(172, 36);
            this.btnAgregarProducto.StyleController = this.layoutControl1;
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnLimpiarProducto
            // 
            this.btnLimpiarProducto.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarProducto.Appearance.Options.UseFont = true;
            this.btnLimpiarProducto.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnLimpiarProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarProducto.ImageOptions.Image")));
            this.btnLimpiarProducto.Location = new System.Drawing.Point(188, 307);
            this.btnLimpiarProducto.Name = "btnLimpiarProducto";
            this.btnLimpiarProducto.Size = new System.Drawing.Size(139, 36);
            this.btnLimpiarProducto.StyleController = this.layoutControl1;
            this.btnLimpiarProducto.TabIndex = 5;
            this.btnLimpiarProducto.Text = "Limpiar";
            this.btnLimpiarProducto.Click += new System.EventHandler(this.btnLimpiarProducto_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Appearance.Options.UseFont = true;
            this.btnFacturar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturar.ImageOptions.Image")));
            this.btnFacturar.Location = new System.Drawing.Point(12, 604);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(158, 36);
            this.btnFacturar.StyleController = this.layoutControl1;
            this.btnFacturar.TabIndex = 8;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(958, 652);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridProducto;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(938, 295);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.btnAgregarProducto;
            this.layoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 295);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(176, 40);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(176, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(176, 40);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem1";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.btnLimpiarProducto;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem4.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem4.Location = new System.Drawing.Point(176, 295);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(143, 40);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(143, 40);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(762, 40);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.Text = "layoutControlItem2";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridDetalleVenta;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 335);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(938, 219);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lblMonto;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 554);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(938, 28);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnFacturar;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 592);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(162, 40);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(162, 40);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(938, 40);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 582);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(938, 10);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 652);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmVentas";
            this.Text = "Realizar Venta";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleVenta)).EndInit();
            this.contextMenuStripDetalleVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.UnitOfWork unitOfWork;
        private DevExpress.Xpo.XPCollection xpProductos;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colprecioUnitario;
        private DevExpress.XtraGrid.Columns.GridColumn colcantidadStock;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnAgregarProducto;
        private DevExpress.XtraEditors.SimpleButton btnLimpiarProducto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gridDetalleVenta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleVenta;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.LabelControl lblMonto;
        private DevExpress.XtraEditors.SimpleButton btnFacturar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDetalleVenta;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarProducto;
    }
}