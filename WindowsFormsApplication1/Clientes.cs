using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Clientes : Form
    {
        AccesoWebService acceso;
        public Clientes(AccesoWebService acceso)
        {
            InitializeComponent();
            this.acceso = acceso;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            string json = acceso.ObtenerDatos("clientes");
            var listaClientes = JsonConvert.DeserializeObject<Objetos.Clientes.RootObject>(json);
            dataGridView1.DataSource = listaClientes.clientes;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EdicionClientes edicionClientes = new EdicionClientes();
            edicionClientes.ShowDialog(this);
            edicionClientes.BringToFront();

            if (edicionClientes.Aceptar)
            {
                NameValueCollection parametros = new NameValueCollection();

                parametros.Add("codigo_cliente", edicionClientes.Codigo);
                parametros.Add("nombre", edicionClientes.Nombre);
                parametros.Add("correo", edicionClientes.Correo);
                parametros.Add("contacto", edicionClientes.Contacto);
                parametros.Add("telefono_1", edicionClientes.Telefono1);
                parametros.Add("telefono_2", edicionClientes.Telefono2);
                parametros.Add("telefono_3", edicionClientes.Telefono3);
                parametros.Add("direccion", edicionClientes.Contacto);
                parametros.Add("plazo_maximo", edicionClientes.Telefono1);
                parametros.Add("credito_maximo", edicionClientes.Telefono2);
                parametros.Add("observaciones", edicionClientes.Telefono3);

                string response;
                response = acceso.InsertarDatos("clientes", parametros);

                MessageBox.Show(response);

                Clientes_Load(sender, e);

            }
        }
    }
}
