namespace Sistema_Ferreteria.Formularios
{
    partial class frmCategorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategorias));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridCategorias = new DevExpress.XtraGrid.GridControl();
            this.gridViewCategorias = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtNombreCategoria = new DevExpress.XtraEditors.TextEdit();
            this.txtDescripcionCategoría = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.xpCategorias = new DevExpress.Xpo.XPCollection(this.components);
            this.unitOfWork = new DevExpress.Xpo.UnitOfWork(this.components);
            this.contextMenuStripCategoria = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnEditarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEliminarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCategoría.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).BeginInit();
            this.contextMenuStripCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridCategorias);
            this.layoutControl1.Controls.Add(this.comboBox1);
            this.layoutControl1.Controls.Add(this.labelControl1);
            this.layoutControl1.Controls.Add(this.txtNombreCategoria);
            this.layoutControl1.Controls.Add(this.txtDescripcionCategoría);
            this.layoutControl1.Controls.Add(this.simpleButton11);
            this.layoutControl1.Controls.Add(this.simpleButton2);
            this.layoutControl1.Controls.Add(this.simpleButton3);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(909, 213, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(848, 538);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridCategorias
            // 
            this.gridCategorias.Location = new System.Drawing.Point(12, 136);
            this.gridCategorias.MainView = this.gridViewCategorias;
            this.gridCategorias.Name = "gridCategorias";
            this.gridCategorias.Size = new System.Drawing.Size(824, 380);
            this.gridCategorias.TabIndex = 8;
            this.gridCategorias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCategorias});
            // 
            // gridViewCategorias
            // 
            this.gridViewCategorias.GridControl = this.gridCategorias;
            this.gridViewCategorias.Name = "gridViewCategorias";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.xpCategorias;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(579, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "idCategoria";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(317, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 24);
            this.labelControl1.StyleController = this.layoutControl1;
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Categorías";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(165, 40);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(257, 22);
            this.txtNombreCategoria.StyleController = this.layoutControl1;
            this.txtNombreCategoria.TabIndex = 5;
            // 
            // txtDescripcionCategoría
            // 
            this.txtDescripcionCategoría.Location = new System.Drawing.Point(165, 70);
            this.txtDescripcionCategoría.Name = "txtDescripcionCategoría";
            this.txtDescripcionCategoría.Size = new System.Drawing.Size(671, 22);
            this.txtDescripcionCategoría.StyleController = this.layoutControl1;
            this.txtDescripcionCategoría.TabIndex = 6;
            // 
            // simpleButton11
            // 
            this.simpleButton11.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.simpleButton11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton11.ImageOptions.Image")));
            this.simpleButton11.Location = new System.Drawing.Point(22, 96);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(147, 36);
            this.simpleButton11.StyleController = this.layoutControl1;
            this.simpleButton11.TabIndex = 4;
            this.simpleButton11.Text = "Nueva Categoria";
            // 
            // simpleButton2
            // 
            this.simpleButton2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(183, 96);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(105, 36);
            this.simpleButton2.StyleController = this.layoutControl1;
            this.simpleButton2.TabIndex = 5;
            this.simpleButton2.Text = "Guardar";
            // 
            // simpleButton3
            // 
            this.simpleButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(302, 96);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(92, 36);
            this.simpleButton3.StyleController = this.layoutControl1;
            this.simpleButton3.TabIndex = 6;
            this.simpleButton3.Text = "Cancelar";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem3,
            this.emptySpaceItem6,
            this.emptySpaceItem7,
            this.layoutControlItem1,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(848, 538);
            this.Root.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 508);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(828, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(416, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(412, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNombreCategoria;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(414, 30);
            this.layoutControlItem2.Text = "Nombre de la Categoría:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(141, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtDescripcionCategoría;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 58);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(828, 26);
            this.layoutControlItem3.Text = "Descripción: ";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(141, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.comboBox1;
            this.layoutControlItem4.Location = new System.Drawing.Point(414, 28);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(414, 30);
            this.layoutControlItem4.Text = "Categoría Padre:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(141, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.simpleButton11;
            this.layoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem5.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem5.Location = new System.Drawing.Point(10, 84);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(151, 40);
            this.layoutControlItem5.Text = "layoutControlItem1";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.simpleButton2;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "layoutControlItem2";
            this.layoutControlItem6.Location = new System.Drawing.Point(171, 84);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(109, 40);
            this.layoutControlItem6.Text = "layoutControlItem2";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.simpleButton3;
            this.layoutControlItem7.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem7.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem7.Location = new System.Drawing.Point(290, 84);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(96, 40);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(96, 40);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.Text = "layoutControlItem3";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.emptySpaceItem4.AppearanceItemCaption.Options.UseFont = true;
            this.emptySpaceItem4.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem4.Location = new System.Drawing.Point(280, 84);
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
            this.emptySpaceItem5.Location = new System.Drawing.Point(161, 84);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(10, 27);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 40);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.Text = "emptySpaceItem2";
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 84);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(10, 40);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.emptySpaceItem6.AppearanceItemCaption.Options.UseFont = true;
            this.emptySpaceItem6.CustomizationFormText = "emptySpaceItem1";
            this.emptySpaceItem6.Location = new System.Drawing.Point(386, 84);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(442, 40);
            this.emptySpaceItem6.Text = "emptySpaceItem1";
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(305, 28);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.labelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(305, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(111, 28);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.gridCategorias;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 124);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(828, 384);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // xpCategorias
            // 
            this.xpCategorias.ObjectType = typeof(Sistema_Ferreteria.Database.Categorias);
            this.xpCategorias.Session = this.unitOfWork;
            // 
            // contextMenuStripCategoria
            // 
            this.contextMenuStripCategoria.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripCategoria.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEditarCategoria,
            this.btnEliminarCategoria});
            this.contextMenuStripCategoria.Name = "contextMenuStripCategoria";
            this.contextMenuStripCategoria.Size = new System.Drawing.Size(200, 52);
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(210, 24);
            this.btnEditarCategoria.Text = "Editar categoría";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(199, 24);
            this.btnEliminarCategoria.Text = "Eliminar categoría";
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 538);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmCategorias.IconOptions.LargeImage")));
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescripcionCategoría.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWork)).EndInit();
            this.contextMenuStripCategoria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.TextEdit txtNombreCategoria;
        private DevExpress.XtraEditors.TextEdit txtDescripcionCategoría;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraGrid.GridControl gridCategorias;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCategorias;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.Xpo.XPCollection xpCategorias;
        private DevExpress.Xpo.UnitOfWork unitOfWork;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCategoria;
        private System.Windows.Forms.ToolStripMenuItem btnEditarCategoria;
        private System.Windows.Forms.ToolStripMenuItem btnEliminarCategoria;
    }
}