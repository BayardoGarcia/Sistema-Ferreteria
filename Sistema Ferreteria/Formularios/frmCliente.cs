using DevExpress.Utils.DPI;
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
    public partial class frmCliente : DevExpress.XtraEditors.XtraForm
    {
        public bool Editar { get; set; }
        public int IdCliente { get; set; }
        public frmCliente()
        {
            InitializeComponent();
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            btnNuevoCliente.Enabled = true;
            if (xpClientes.Count != 0) gridClientes.Enabled = true;
            Editar = false;
            BloquearControles();
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
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                validado = false;
                XtraMessageBox.Show("El campo Teléfono es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                validado = false;
                XtraMessageBox.Show("El campo Dirección es obligatorio", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Se puede modificar si se desea que la cedula sea opcional o no dependiendo de los requerimientos de la ferreteria
            return validado;
        }
        private void Actualizar()
        {
            Clientes clientes = (Clientes)unitOfWork.GetObjectByKey(typeof(Clientes), IdCliente);
            //Alamacena datos dek usuario desde las cajas de texto
            clientes.nombre = txtNombre.Text.Trim();
            clientes.apellido = txtApellido.Text.Trim();
            clientes.cedula = txtCedula.Text.Trim();
            clientes.telefono = txtTelefono.Text.Trim();
            clientes.direccion = txtDireccion.Text.Trim();
            clientes.email = txtEmail.Text.Trim();
            clientes.fechaRegistro = dtpFecha.Value;
            clientes.activo = true;
            //Proceso de guardado
            clientes.Save();
            unitOfWork.CommitChanges();
            Editar = false;
        }
        private void Guardar()
        {
            Clientes clientes = new Clientes(unitOfWork);
            //Alamacena datos del usuario desde las cajas de texto
            clientes.nombre = txtNombre.Text.Trim();
            clientes.apellido = txtApellido.Text.Trim();
            clientes.cedula = txtCedula.Text.Trim();
            clientes.telefono = txtTelefono.Text.Trim();
            clientes.direccion = txtDireccion.Text.Trim();
            clientes.email = txtEmail.Text.Trim();
            clientes.fechaRegistro = dtpFecha.Value;
            clientes.activo = true;
            //Proceso de guardado
            clientes.Save();
            unitOfWork.CommitChanges();
        }
        private void ValidarTelefono(object sender, KeyPressEventArgs e)
        {
           TextEdit txt = (TextEdit)sender;
           if(string.IsNullOrEmpty(txt.Text))
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
        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            DesbloquearControles();
            btnNuevoCliente.Enabled = false;
            gridClientes.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            txtNombre.Focus();  
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!ValidarDatos())//Valida los datos
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
            xpClientes.Reload();//Recarga los datos de la base de datos
            BloquearControles();//Bloquea los controles
            btnNuevoCliente.Enabled = true;//Habilita el boton de nuevo cliente
            gridClientes.Enabled = true;//Habilita el grid de clientes
            LimpiarControles();//Limpia los controles
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            BloquearControles();    
            LimpiarControles(); 
            btnNuevoCliente.Enabled = true;
            gridClientes.Enabled = true;    
        }
        #endregion
        #region "Eventos de grid"
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = (Clientes)gridViewClientes.GetFocusedRow();//Obtiene el cliente seleccionado
            if (clientes != null)
            {
                DesbloquearControles();
                btnNuevoCliente.Enabled = false;
                gridClientes.Enabled = false;
                //Carga los datos del cliente seleccionado en las cajas de texto
                txtNombre.Text = clientes.nombre;
                txtApellido.Text = clientes.apellido;
                txtCedula.Text = clientes.cedula;
                txtTelefono.Text = clientes.telefono;
                txtDireccion.Text = clientes.direccion;
                txtEmail.Text = clientes.email;
                dtpFecha.Value = clientes.fechaRegistro;
                IdCliente = clientes.idCliente;
                gridClientes.Enabled = false;
                Editar = true; //Se activa la bandera de edicion
            }
        }
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            Clientes clientes = (Clientes)gridViewClientes.GetFocusedRow();//Obtiene el cliente seleccionado    
            if (clientes != null)
            {
                if (XtraMessageBox.Show("¿Está seguro de eliminar el cliente seleccionado?", "Sistema Ferreteria", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        clientes.Delete();//Elimina el cliente seleccionado
                        unitOfWork.CommitChanges();//Guarda los cambios
                        xpClientes.Reload();//Recarga los datos
                    }
                    catch (ConstraintViolationException)
                    {
                        MessageBox.Show("No se puede eliminar el cliente seleccionado, ya que tiene registros asociados", "Sistema Ferreteria", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        unitOfWork.ReloadChangedObjects();//Recarga los cambios
                    }
                }   
            }
        }
        #endregion
    }
}