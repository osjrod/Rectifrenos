using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsApplication1.Datos;
using WindowsFormsApplication1.Logica;
using WindowsFormsApplication1.Objetos;


namespace WindowsFormsApplication1
{
    public partial class Proveedores : Form
    {
        oProveedores.Proveedores todos;
        string id = String.Empty;
        public Proveedores(oProveedores.Proveedores todos)
        {
            InitializeComponent();
            this.todos = todos;
            timer1.Start();
            
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EdicionProveedores edicionProveedores = new EdicionProveedores();
            edicionProveedores.ShowDialog(this);
            edicionProveedores.BringToFront();

            if (edicionProveedores.Aceptar)
            {
                NameValueCollection parametros = new NameValueCollection();

                parametros.Add("codigo_proveedor", edicionProveedores.Codigo);
                parametros.Add("nombre", edicionProveedores.Nombre);
                parametros.Add("correo", edicionProveedores.Correo);
                parametros.Add("contacto", edicionProveedores.Contacto);
                parametros.Add("telefono_1", edicionProveedores.Telefono1);
                parametros.Add("telefono_2", edicionProveedores.Telefono2);
                parametros.Add("telefono_3", edicionProveedores.Telefono3);

                string response;
                //response = acceso.InsertarDatos("proveedores",parametros);

                //MessageBox.Show(response);

                Proveedores_Load(sender,e);

            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {


            if (this.dataGridView1.RowCount > 0)
            {
                int fila = this.dataGridView1.CurrentRow.Index;

                EdicionProveedores edicionProveedores = new EdicionProveedores(int.Parse(this.dataGridView1[0, fila].Value.ToString()),
                                                                 this.dataGridView1[1, fila].Value.ToString(),
                                                                 this.dataGridView1[2, fila].Value.ToString(),
                                                                 this.dataGridView1[3, fila].Value.ToString(),
                                                                 this.dataGridView1[4, fila].Value.ToString());

                edicionProveedores.ShowDialog(this);
                edicionProveedores.BringToFront();

                if (edicionProveedores.Aceptar)
                {
                    

                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Proveedores_Shown(object sender, EventArgs e)
        {
            
        }

        private void Proveedores_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void Proveedores_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
           
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = todos.proveedores;
            timer1.Stop();
        }
    }
}
