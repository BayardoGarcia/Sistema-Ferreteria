namespace Sistema_Ferreteria.Formularios
{
    partial class frmDetalleProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetalleProveedores));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridProveedores = new DevExpress.XtraGrid.GridControl();
            this.xpProveedores = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewProveedores = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaRegistro1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnExportarExcel = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colnombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colapellido = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colactivo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.gridProveedores);
            this.layoutControl1.Controls.Add(this.btnExportarExcel);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1303, 821);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(530, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(244, 24);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 8;
            this.labelControl1.Text = "Detalles de Proveedores";
            // 
            // gridProveedores
            // 
            this.gridProveedores.DataSource = this.xpProveedores;
            this.gridProveedores.Location = new System.Drawing.Point(12, 83);
            this.gridProveedores.MainView = this.gridViewProveedores;
            this.gridProveedores.Name = "gridProveedores";
            this.gridProveedores.Size = new System.Drawing.Size(1279, 686);
            this.gridProveedores.TabIndex = 7;
            this.gridProveedores.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProveedores});
            // 
            // xpProveedores
            // 
            this.xpProveedores.ObjectType = typeof(Sistema_Ferreteria.Database.Proveedores);
            this.xpProveedores.Session = this.unitOfWork;
            // 
            // gridViewProveedores
            // 
            this.gridViewProveedores.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnombre1,
            this.coltelefono1,
            this.colemail1,
            this.coldireccion1,
            this.colfechaRegistro1});
            this.gridViewProveedores.GridControl = this.gridProveedores;
            this.gridViewProveedores.Name = "gridViewProveedores";
            // 
            // colnombre1
            // 
            this.colnombre1.Caption = "Nombre";
            this.colnombre1.FieldName = "nombre";
            this.colnombre1.MinWidth = 25;
            this.colnombre1.Name = "colnombre1";
            this.colnombre1.Visible = true;
            this.colnombre1.VisibleIndex = 0;
            this.colnombre1.Width = 94;
            // 
            // coltelefono1
            // 
            this.coltelefono1.Caption = "Teléfono";
            this.coltelefono1.FieldName = "telefono";
            this.coltelefono1.MinWidth = 25;
            this.coltelefono1.Name = "coltelefono1";
            this.coltelefono1.Visible = true;
            this.coltelefono1.VisibleIndex = 1;
            this.coltelefono1.Width = 94;
            // 
            // colemail1
            // 
            this.colemail1.Caption = "Email";
            this.colemail1.FieldName = "email";
            this.colemail1.MinWidth = 25;
            this.colemail1.Name = "colemail1";
            this.colemail1.Visible = true;
            this.colemail1.VisibleIndex = 2;
            this.colemail1.Width = 94;
            // 
            // coldireccion1
            // 
            this.coldireccion1.Caption = "Dirección";
            this.coldireccion1.FieldName = "direccion";
            this.coldireccion1.MinWidth = 25;
            this.coldireccion1.Name = "coldireccion1";
            this.coldireccion1.Visible = true;
            this.coldireccion1.VisibleIndex = 3;
            this.coldireccion1.Width = 94;
            // 
            // colfechaRegistro1
            // 
            this.colfechaRegistro1.Caption = "Fecha de Registro";
            this.colfechaRegistro1.FieldName = "fechaRegistro";
            this.colfechaRegistro1.MinWidth = 25;
            this.colfechaRegistro1.Name = "colfechaRegistro1";
            this.colfechaRegistro1.Visible = true;
            this.colfechaRegistro1.VisibleIndex = 4;
            this.colfechaRegistro1.Width = 94;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarExcel.ImageOptions.Image")));
            this.btnExportarExcel.Location = new System.Drawing.Point(1060, 773);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(231, 36);
            this.btnExportarExcel.StyleController = this.layoutControl1;
            this.btnExportarExcel.TabIndex = 6;
            this.btnExportarExcel.Text = "Exportar a Excel";
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.emptySpaceItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.emptySpaceItem4,
            this.emptySpaceItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1303, 821);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 28);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1283, 43);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnExportarExcel;
            this.layoutControlItem3.Location = new System.Drawing.Point(1048, 761);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(235, 40);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 761);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(1048, 40);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridProveedores;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1283, 690);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelControl1;
            this.layoutControlItem4.Location = new System.Drawing.Point(518, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(248, 28);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(518, 28);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(766, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(517, 28);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colnombre
            // 
            this.colnombre.Caption = "Nombre";
            this.colnombre.FieldName = "nombre";
            this.colnombre.MinWidth = 25;
            this.colnombre.Name = "colnombre";
            this.colnombre.Visible = true;
            this.colnombre.VisibleIndex = 0;
            this.colnombre.Width = 94;
            // 
            // colapellido
            // 
            this.colapellido.Caption = "Apellido";
            this.colapellido.FieldName = "apellido";
            this.colapellido.MinWidth = 25;
            this.colapellido.Name = "colapellido";
            this.colapellido.Visible = true;
            this.colapellido.VisibleIndex = 1;
            this.colapellido.Width = 94;
            // 
            // colcedula
            // 
            this.colcedula.Caption = "Cédula";
            this.colcedula.FieldName = "cedula";
            this.colcedula.MinWidth = 25;
            this.colcedula.Name = "colcedula";
            this.colcedula.Visible = true;
            this.colcedula.VisibleIndex = 2;
            this.colcedula.Width = 94;
            // 
            // coltelefono
            // 
            this.coltelefono.Caption = "Teléfono";
            this.coltelefono.FieldName = "telefono";
            this.coltelefono.MinWidth = 25;
            this.coltelefono.Name = "coltelefono";
            this.coltelefono.Visible = true;
            this.coltelefono.VisibleIndex = 3;
            this.coltelefono.Width = 94;
            // 
            // colemail
            // 
            this.colemail.Caption = "Email";
            this.colemail.FieldName = "email";
            this.colemail.MinWidth = 25;
            this.colemail.Name = "colemail";
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 4;
            this.colemail.Width = 94;
            // 
            // coldireccion
            // 
            this.coldireccion.Caption = "Dirección";
            this.coldireccion.FieldName = "direccion";
            this.coldireccion.MinWidth = 25;
            this.coldireccion.Name = "coldireccion";
            this.coldireccion.Visible = true;
            this.coldireccion.VisibleIndex = 5;
            this.coldireccion.Width = 94;
            // 
            // colfechaRegistro
            // 
            this.colfechaRegistro.Caption = "Fecha de Registro";
            this.colfechaRegistro.FieldName = "fechaRegistro";
            this.colfechaRegistro.MinWidth = 25;
            this.colfechaRegistro.Name = "colfechaRegistro";
            this.colfechaRegistro.Visible = true;
            this.colfechaRegistro.VisibleIndex = 6;
            this.colfechaRegistro.Width = 94;
            // 
            // colactivo
            // 
            this.colactivo.Caption = "Activo";
            this.colactivo.FieldName = "activo";
            this.colactivo.MinWidth = 25;
            this.colactivo.Name = "colactivo";
            this.colactivo.Visible = true;
            this.colactivo.VisibleIndex = 7;
            this.colactivo.Width = 94;
            // 
            // frmDetalleProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 821);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmDetalleProveedores";
            this.Text = "Detalles de Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnExportarExcel;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.Xpo.UnitOfWork unitOfWork;
        private DevExpress.Xpo.XPCollection xpProveedores;
        private DevExpress.XtraGrid.GridControl gridProveedores;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProveedores;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre1;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono1;
        private DevExpress.XtraGrid.Columns.GridColumn colemail1;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion1;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaRegistro1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colnombre;
        private DevExpress.XtraGrid.Columns.GridColumn colapellido;
        private DevExpress.XtraGrid.Columns.GridColumn colcedula;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn coldireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colfechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn colactivo;
    }
}