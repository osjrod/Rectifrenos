using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class EdicionClientes : Form
    {
         private Boolean aceptar = false;
        public EdicionClientes()
        {
            InitializeComponent();
        }

        public EdicionClientes(int id, string codigo, string nombre, string correo, string contacto)
        {
            InitializeComponent();
            txtCodigo.Text = codigo;
            txtNombre.Text = nombre;
            txtCorreo.Text = correo;
            txtContacto.Text = contacto;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            aceptar = true;
            this.Close();
        }


        public Boolean Aceptar
        {
            get { return aceptar; }
        }

        public string Codigo
        {
            get { return txtCodigo.Text; }
        }

        public string Nombre
        {
            get { return txtNombre.Text; }
        }

        public string Correo
        {
            get { return txtCorreo.Text; }
        }

        public string Telefono1
        {
            get { return txtTelefono1.Text; }
        }

        public string Telefono2
        {
            get { return txtTelefono2.Text; }
        }

        public string Telefono3
        {
            get { return txtTelefono3.Text; }
        }

        public string Contacto
        {
            get { return txtContacto.Text; }
        }

        public string Direccion
        {
            get { return txtDireccion.Text; }
        }

        public string Plazo
        {
            get { return txtPlazo.Text; }
        }

        public string Credito
        {
            get { return txtCredito.Text; }
        }

        public string Observaciones
        {
            get { return txtObservaciones.Text; }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            aceptar = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
