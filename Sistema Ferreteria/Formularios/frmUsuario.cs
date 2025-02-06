using DevExpress.Xpo;
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
    public partial class frmUsuario : DevExpress.XtraEditors.XtraForm
    {
        private int IdUsuario { get; set; }
        private int IdRol { get; set; }
        private bool Editar { get; set; }
        public frmUsuario()
        {
            InitializeComponent();
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            BloquearControles();
            btnNuevoUsuario.Enabled = true;
            gridUsuarios.Enabled = true;
            Editar = false;
        }
        #region "Metodos simples"
        private void BloquearControles()
        {
            foreach (Control control in this.layoutControl1.Controls)
            {
                control.Enabled = false;
            }
        }
        private void DesbloquearControles()
        {
            foreach (Control control in this.layoutControl1.Controls)
            {
                control.Enabled = true;
            }
        }
        private void LimpiarControles()
        {
            foreach (Control control in this.layoutControl1.Controls)
            {
                if (control is TextEdit)
                {
                    control.Text = string.Empty;
                }
            }
        }
        private void SeleccionTexto(object sender, EventArgs e)
        {
            TextEdit txt = (TextEdit)sender;//sender es el objeto que envia el evento
            txt.SelectAll();//Selecciona todo el texto del control
        }
        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)sender;
            if(comboBox.SelectedIndex == -1)
            {
                return;
            }
            IdRol = (int)comboBox.SelectedValue;
        }
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.Properties.PasswordChar = '\0';
            }
            else
            {
                txtPassword.Properties.PasswordChar = '*';
            }
        }
        #endregion
        #region "Metodos de guardado de datos y validacion"
        private bool ValidarDatos()
        {
            bool validado = true;
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                validado = false;
                XtraMessageBox.Show("El campo Nombre es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(txtApellido.Text))
            {
                validado = false;
                XtraMessageBox.Show("El campo Apellido es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                validado = false;
                XtraMessageBox.Show("El campo Usuario es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (txtPassword.Enabled == true && string.IsNullOrEmpty(txtPassword.Text))
            {
                validado = false;
                XtraMessageBox.Show("El campo Contraseña es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                validado = false;
                XtraMessageBox.Show("El campo Teléfono es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                validado = false;
                XtraMessageBox.Show("El campo Email es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(txtCedula.Text))
            {
                validado = false;
                XtraMessageBox.Show("El campo Cedula es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (IdRol == 0)
            {
                validado = false;
                XtraMessageBox.Show("El campo Rol es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Se puede modificar si se desea que la cedula sea opcional o no dependiendo de los requerimientos de la ferreteria
            //Si se desea de igual manera solo puede ser usuario, password y rol sean obligatorios
            return validado;
        }
        private void Actualizar()
        {
            Usuarios usuarios = unitOfWork.GetObjectByKey<Usuarios>(IdUsuario);
            usuarios.nombre = txtNombre.Text.Trim();
            usuarios.apellido = txtApellido.Text.Trim();
            usuarios.usuario = txtUsuario.Text.Trim();
            usuarios.password = Encrypt.GetMD5String(txtPassword.Text.Trim());
            usuarios.cedula = txtCedula.Text.Trim();
            usuarios.telefono = txtTelefono.Text.Trim();
            usuarios.email = txtEmail.Text.Trim();
            usuarios.fecha = dtpFecha.Value;
            usuarios.rol = (Roles)unitOfWork.GetObjectByKey(typeof(Roles), IdRol);
            usuarios.activo = true;
            usuarios.Save();
            unitOfWork.CommitChanges();
            gridUsuarios.Enabled = true;
        }
        private void Guardar()
        {
            Usuarios usuarios = new Usuarios(unitOfWork);
            usuarios.nombre = txtNombre.Text.Trim();
            usuarios.apellido = txtApellido.Text.Trim();
            usuarios.usuario = txtUsuario.Text.Trim();
            usuarios.password = Encrypt.GetMD5String(txtPassword.Text.Trim());
            usuarios.cedula = txtCedula.Text.Trim();
            usuarios.telefono = txtTelefono.Text.Trim();
            usuarios.email = txtEmail.Text.Trim();
            usuarios.fecha = dtpFecha.Value;
            usuarios.rol = (Roles)unitOfWork.GetObjectByKey(typeof(Roles), IdRol);
            usuarios.activo = true;  
            usuarios.Save();
            unitOfWork.CommitChanges();
        }
        private void ValidarTelefono(object sender, KeyPressEventArgs e)
        {
            TextEdit txt = (TextEdit)sender;
            if (string.IsNullOrEmpty(txt.Text))
            {
                return;
            }
            long numero;
            try
            {
                numero = long.Parse(txt.Text);
            }
            catch (Exception)
            {
                txt.SelectAll();
                XtraMessageBox.Show("Solo se permiten números en este campo", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
            }
        }
        #endregion
        #region "Eventos de botones"
        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            DesbloquearControles();
            btnNuevoUsuario.Enabled = false;
            gridUsuarios.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            txtNombre.Focus();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos())//Valida los datos
            {
                return;
            }
            if (Editar == true)//Si se esta editando un cliente
            {
                Actualizar();
            }
            else//Si se esta guardando un nuevo cliente
            {
                Guardar();
            }
            xpUsuarios.Reload();//Recarga los datos de la base de datos
            BloquearControles();//Bloquea los controles
            btnNuevoUsuario.Enabled = true;//Habilita el boton de nuevo cliente
            gridUsuarios.Enabled = true;//Habilita el grid de clientes
            LimpiarControles();//Limpia los controles
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BloquearControles();
            LimpiarControles();
            btnNuevoUsuario.Enabled = true;
            gridUsuarios.Enabled = true;
        }
        #endregion   
        #region "Eventos de grid"
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = (Usuarios)gridViewUsuarios.GetFocusedRow();//Obtiene el cliente seleccionado
            if (usuarios != null)
            {
                DesbloquearControles();
                gridUsuarios.Enabled = false;
                txtPassword.Enabled = false;
                txtPassword.Visible = false;
                chkShow.Visible = false;
                chkShow.Enabled = false;
                //Botones de edicion
                btnNuevoUsuario.Enabled = false;
                btnGuardar.Enabled = true;
                btnCancelar.Enabled = true;
                //Datos del usuario 
                txtNombre.Text = usuarios.nombre;
                txtApellido.Text = usuarios.apellido;
                txtUsuario.Text = usuarios.usuario;
                txtPassword.Text = usuarios.password;
                txtCedula.Text = usuarios.cedula;
                txtTelefono.Text = usuarios.telefono;
                dtpFecha.Value = usuarios.fecha;
                txtEmail.Text = usuarios.email;
                IdRol = usuarios.rol.idRol;
                cboRol.Text = usuarios.rol.rol;
                IdUsuario = usuarios.idUsuario;
                Editar = true;
            }
        }
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = (Usuarios)gridViewUsuarios.GetFocusedRow();
            if (usuarios != null)
            {
                if (XtraMessageBox.Show("¿Está seguro de eliminar el usuario seleccionado?", "Sistema Ferreteria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        usuarios.activo = false;
                        unitOfWork.Delete(usuarios);
                        unitOfWork.CommitChanges();
                        xpUsuarios.Reload();
                    }
                    catch (ConstraintViolationException)
                    {
                        XtraMessageBox.Show("No se puede eliminar el usuario seleccionado porque tiene registros asociados", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        unitOfWork.RollbackTransaction();
                    }
                }
            }
        }
        #endregion
    }
}