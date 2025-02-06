using DevExpress.Xpo.DB.Exceptions;
using DevExpress.XtraEditors;
using Sistema_Ferreteria.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ferreteria.Formularios
{
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {
        public bool Editar { get; set; }
        public int IdCategoria { get; set; }
        public frmCategorias()
        {
            InitializeComponent();
        }
        private void frmCategorias_Load(object sender, EventArgs e)
        {
            BloquearComponentes();
            btnNuevaCategoria.Enabled = true;
            gridCategorias.Enabled = true;
            Editar = false;
        }
        #region "Metodos simples"   
        private void BloquearComponentes()
        {
            foreach (Control control in this.layoutControl1.Controls)
                control.Enabled = false;
        }
        private void DesbloquearComponentes()
        {
            foreach (Control control in this.layoutControl1.Controls)
                control.Enabled = true;
        }
        private void cboCategoriaPadre_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            if (comboBox.SelectedIndex == -1) return;
        }
        #endregion
        #region "Metodos de guardado"
        private void Actualizar()
        {
            Categorias categorias = (Categorias)unitOfWork.GetObjectByKey(typeof(Categorias), IdCategoria);
            categorias.nombre = txtNombreCategoria.Text.Trim();
            categorias.Save();
            unitOfWork.CommitChanges();
            Editar = false;
        }
        private void Guardar()
        {
            Categorias categorias = new Categorias(unitOfWork);
            categorias.nombre = txtNombreCategoria.Text.Trim();
            categorias.Save();
            unitOfWork.CommitChanges();
            xpCategorias.Reload();
        }
        #endregion
        #region "Eventos de botones"
        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            DesbloquearComponentes();
            btnNuevaCategoria.Enabled = false;
            gridCategorias.Enabled = false;
            txtNombreCategoria.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreCategoria.Text))
            {
                XtraMessageBox.Show("Ingrese el nombre de la categoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreCategoria.Focus();
                return;
            }
            if(Editar == true )
            {
                Actualizar();
            }
            else
            {
                Guardar();
            }
            BloquearComponentes();
            btnNuevaCategoria.Enabled = true;
            gridCategorias.Enabled = true;  
            xpCategorias.Reload();
            txtNombreCategoria.Text = string.Empty;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BloquearComponentes();
            btnNuevaCategoria.Enabled = true;
            gridCategorias.Enabled = true;
            txtNombreCategoria.Text = string.Empty;
        }
        #endregion
        #region "Eventos de grid"
        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            Categorias categorias = (Categorias)gridViewCategorias.GetFocusedRow();
            if (categorias != null)
            {
                txtNombreCategoria.Text = categorias.nombre;
                IdCategoria = categorias.idCategoria;
                Editar = true;
                DesbloquearComponentes();
                btnNuevaCategoria.Enabled = false;
                gridCategorias.Enabled = false;
            }
        }
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            Categorias categorias = (Categorias)gridViewCategorias.GetFocusedRow();
            if (categorias != null)
            {
                DialogResult result = XtraMessageBox.Show("¿Está seguro de eliminar la categoria?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        categorias.Delete();
                        unitOfWork.CommitChanges();
                        xpCategorias.Reload();
                    }
                    catch (ConstraintViolationException)
                    {
                        XtraMessageBox.Show("No se puede eliminar la categoria, porque tiene productos asociados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        unitOfWork.ReloadChangedObjects();
                        xpCategorias.Reload();
                    }
                }

            }
        }
        #endregion
    }
}