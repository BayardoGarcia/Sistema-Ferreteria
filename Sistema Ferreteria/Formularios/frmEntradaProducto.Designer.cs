namespace Sistema_Ferreteria.Formularios
{
    partial class frmEntradaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradaProducto));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lblImporte = new DevExpress.XtraEditors.LabelControl();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.slueProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.slueViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtProducto = new DevExpress.XtraEditors.TextEdit();
            this.txtPrecioCompra = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardarEntrada = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelarOperacion = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciProducto = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSeleccionProducto = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSeleccionProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelControl3);
            this.layoutControl1.Controls.Add(this.lblImporte);
            this.layoutControl1.Controls.Add(this.nudCantidad);
            this.layoutControl1.Controls.Add(this.slueProducto);
            this.layoutControl1.Controls.Add(this.dtpFechaEntrada);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.txtProducto);
            this.layoutControl1.Controls.Add(this.txtPrecioCompra);
            this.layoutControl1.Controls.Add(this.btnGuardarEntrada);
            this.layoutControl1.Controls.Add(this.btnCancelarOperacion);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(509, 16, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(448, 280);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 252);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(362, 16);
            this.labelControl3.StyleController = this.layoutControl1;
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Si cancela la operación se cerrará automaticamente esté menú";
            // 
            // lblImporte
            // 
            this.lblImporte.Location = new System.Drawing.Point(12, 176);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(50, 16);
            this.lblImporte.StyleController = this.layoutControl1;
            this.lblImporte.TabIndex = 10;
            this.lblImporte.Text = "Importe:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(158, 121);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(278, 23);
            this.nudCantidad.TabIndex = 8;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // slueProducto
            // 
            this.slueProducto.Location = new System.Drawing.Point(158, 95);
            this.slueProducto.Name = "slueProducto";
            this.slueProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slueProducto.Properties.DataSource = this.xpProductos;
            this.slueProducto.Properties.DisplayMember = "nombre";
            this.slueProducto.Properties.PopupView = this.slueViewProductos;
            this.slueProducto.Properties.ValueMember = "idProducto";
            this.slueProducto.Size = new System.Drawing.Size(278, 22);
            this.slueProducto.StyleController = this.layoutControl1;
            this.slueProducto.TabIndex = 7;
            this.slueProducto.EditValueChanged += new System.EventHandler(this.slueProducto_EditValueChanged);
            // 
            // xpProductos
            // 
            this.xpProductos.ObjectType = typeof(Sistema_Ferreteria.Database.Productos);
            this.xpProductos.Session = this.unitOfWork;
            // 
            // slueViewProductos
            // 
            this.slueViewProductos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.slueViewProductos.Name = "slueViewProductos";
            this.slueViewProductos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.slueViewProductos.OptionsView.ShowGroupPanel = false;
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Location = new System.Drawing.Point(158, 40);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(278, 23);
            this.dtpFechaEntrada.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(122, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(207, 24);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Entrada de Producto";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(158, 69);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(278, 22);
            this.txtProducto.StyleController = this.layoutControl1;
            this.txtProducto.TabIndex = 6;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(158, 150);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPrecioCompra.Properties.MaskSettings.Set("mask", "n");
            this.txtPrecioCompra.Size = new System.Drawing.Size(278, 22);
            this.txtPrecioCompra.StyleController = this.layoutControl1;
            this.txtPrecioCompra.TabIndex = 9;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // btnGuardarEntrada
            // 
            this.btnGuardarEntrada.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGuardarEntrada.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarEntrada.ImageOptions.Image")));
            this.btnGuardarEntrada.Location = new System.Drawing.Point(238, 196);
            this.btnGuardarEntrada.Name = "btnGuardarEntrada";
            this.btnGuardarEntrada.Size = new System.Drawing.Size(88, 36);
            this.btnGuardarEntrada.StyleController = this.layoutControl1;
            this.btnGuardarEntrada.TabIndex = 5;
            this.btnGuardarEntrada.Text = "Guardar";
            this.btnGuardarEntrada.Click += new System.EventHandler(this.btnGuardarEntrada_Click);
            // 
            // btnCancelarOperacion
            // 
            this.btnCancelarOperacion.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarOperacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarOperacion.ImageOptions.Image")));
            this.btnCancelarOperacion.Location = new System.Drawing.Point(340, 196);
            this.btnCancelarOperacion.Name = "btnCancelarOperacion";
            this.btnCancelarOperacion.Size = new System.Drawing.Size(96, 36);
            this.btnCancelarOperacion.StyleController = this.layoutControl1;
            this.btnCancelarOperacion.TabIndex = 6;
            this.btnCancelarOperacion.Text = "Cancelar ";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.lciProducto,
            this.lciSeleccionProducto,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.layoutControlItem10});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(448, 280);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 224);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(428, 16);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(110, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(321, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(107, 28);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(110, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(211, 28);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dtpFechaEntrada;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(428, 29);
            this.layoutControlItem2.Text = "Fecha:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(134, 16);
            // 
            // lciProducto
            // 
            this.lciProducto.Control = this.txtProducto;
            this.lciProducto.Location = new System.Drawing.Point(0, 57);
            this.lciProducto.Name = "lciProducto";
            this.lciProducto.Size = new System.Drawing.Size(428, 26);
            this.lciProducto.Text = "Producto:";
            this.lciProducto.TextSize = new System.Drawing.Size(134, 16);
            // 
            // lciSeleccionProducto
            // 
            this.lciSeleccionProducto.Control = this.slueProducto;
            this.lciSeleccionProducto.Location = new System.Drawing.Point(0, 83);
            this.lciSeleccionProducto.Name = "lciSeleccionProducto";
            this.lciSeleccionProducto.Size = new System.Drawing.Size(428, 26);
            this.lciSeleccionProducto.Text = "Seleccione el producto:";
            this.lciSeleccionProducto.TextSize = new System.Drawing.Size(134, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.nudCantidad;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 109);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(428, 29);
            this.layoutControlItem5.Text = "Cantidad:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(134, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtPrecioCompra;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 138);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(428, 26);
            this.layoutControlItem6.Text = "Precio Compra:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(134, 16);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lblImporte;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 164);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(428, 20);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.btnGuardarEntrada;
            this.layoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem8.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem8.Location = new System.Drawing.Point(226, 184);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(92, 40);
            this.layoutControlItem8.Text = "layoutControlItem1";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.btnCancelarOperacion;
            this.layoutControlItem9.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem9.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem9.Location = new System.Drawing.Point(328, 184);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(100, 40);
            this.layoutControlItem9.Text = "layoutControlItem2";
            this.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.emptySpaceItem4.AppearanceItemCaption.Options.UseFont = true;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem4.Location = new System.Drawing.Point(318, 184);
            this.emptySpaceItem4.MaxSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem4.MinSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 40);
            this.emptySpaceItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem4.Text = "emptySpaceItem1";
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.emptySpaceItem5.AppearanceItemCaption.Options.UseFont = true;
            this.emptySpaceItem5.CustomizationFormText = "emptySpaceItem2";
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 184);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(226, 40);
            this.emptySpaceItem5.Text = "emptySpaceItem2";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.labelControl3;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(428, 20);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // frmEntradaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 280);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmEntradaProducto.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEntradaProducto";
            this.Text = "Entrada de Producto";
            this.Load += new System.EventHandler(this.frmEntradaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slueViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecioCompra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSeleccionProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SearchLookUpEdit slueProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView slueViewProductos;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private DevExpress.XtraEditors.TextEdit txtProducto;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem lciProducto;
        private DevExpress.XtraLayout.LayoutControlItem lciSeleccionProducto;
        private DevExpress.XtraEditors.LabelControl lblImporte;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private DevExpress.XtraEditors.TextEdit txtPrecioCompra;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnGuardarEntrada;
        private DevExpress.XtraEditors.SimpleButton btnCancelarOperacion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.Xpo.UnitOfWork unitOfWork;
        private DevExpress.Xpo.XPCollection xpProductos;
    }
}