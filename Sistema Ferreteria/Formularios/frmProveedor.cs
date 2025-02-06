using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema_Ferreteria.Database;
using DevExpress.Xpo.DB.Exceptions;

namespace Sistema_Ferreteria.Formularios
{
    public partial class frmProveedor : DevExpress.XtraEditors.XtraForm
    {
        public int IdProveedor { get; set; }
        public bool Editar { get; set; }    
        public frmProveedor()
        {
            InitializeComponent();
        }
        private void frmProveedor_Load(object sender, EventArgs e)
        {
            BloquearComponentes();
            btnNuevoProveedor.Enabled = true;   
            gridProveedor.Enabled = true;
            Editar = false;
        }
        #region "Metodos Simples"
        private void BloquearComponentes() 
        {
            foreach (Control item in this.layoutControl1.Controls)  
                item.Enabled = false;
            
        }
        private void DesbloquearComponentes()
        {
            foreach (Control item in this.layoutControl1.Controls)
                item.Enabled = true;
        }
        private void LimpiarComponentes()
        {
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            dtpFecha.Value = DateTime.Now;
        }
        #endregion
        #region "Metodos de Validacion"
        private bool ValidarComponentes()
        {
            bool validar = true;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                XtraMessageBox.Show("El campo Nombre es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar = false;
                txtNombre.Focus();
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                XtraMessageBox.Show("El campo Direccion es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar = false;
                txtDireccion.Focus();
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                XtraMessageBox.Show("El campo Telefono es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar = false;
                txtTelefono.Focus();
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                XtraMessageBox.Show("El campo Email es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                validar = false;
                txtEmail.Focus();
            }
            return validar;  
        }
        #endregion
        #region "Metodos de eventos de botones"
        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            DesbloquearComponentes();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevoProveedor.Enabled = false;
            gridProveedor.Enabled = false;
            txtNombre.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarComponentes())
            {
                return;
            }
            Proveedores proveedor;
            if (Editar == true)
            {
                proveedor = (Proveedores)unitOfWork.GetObjectByKey(typeof(Proveedores), IdProveedor);
                Editar = false;
            }
            else
            {
                proveedor = new Proveedores(unitOfWork);
            }
            proveedor.nombre = txtNombre.Text.Trim();
            proveedor.direccion = txtDireccion.Text.Trim();
            proveedor.telefono = txtTelefono.Text.Trim();
            proveedor.email = txtEmail.Text.Trim();
            proveedor.fechaRegistro = dtpFecha.Value;
            proveedor.Save();
            unitOfWork.CommitChanges();
            xpProveedor.Reload();
            LimpiarComponentes();
            BloquearComponentes();
            btnNuevoProveedor.Enabled = true;
            gridProveedor.Enabled = true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BloquearComponentes();
            LimpiarComponentes();
            btnNuevoProveedor.Enabled = true;
            gridProveedor.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }
        #endregion
        #region "Metodos de eventos de grid"
        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = (Proveedores)gridViewProveedor.GetFocusedRow();
            if (proveedores != null)
            {
                DesbloquearComponentes();
                IdProveedor = proveedores.idProveedor;
                txtNombre.Text = proveedores.nombre;
                txtDireccion.Text = proveedores.direccion;
                txtTelefono.Text = proveedores.telefono;
                txtEmail.Text = proveedores.email;
                dtpFecha.Value = proveedores.fechaRegistro;
                Editar = true;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                btnNuevoProveedor.Enabled = false;
                gridProveedor.Enabled = false;
            }
        }
        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            Proveedores proveedores = (Proveedores)gridViewProveedor.GetFocusedRow();
            if (proveedores != null)
            {
                DialogResult dialogResult = XtraMessageBox.Show("¿Está seguro de eliminar el proveedor?", "Sistema Ferreteria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        proveedores.Delete();
                        unitOfWork.CommitChanges();
                        xpProveedor.Reload();
                    }
                    catch (ConstraintViolationException)
                    {
                        XtraMessageBox.Show("No se puede eliminar el proveedor, porque tiene registros asociados", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        xpProveedor.Reload();
                    }
                }
            }
        }
        #endregion
    }
}