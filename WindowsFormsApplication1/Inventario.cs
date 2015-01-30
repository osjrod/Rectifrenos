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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            //string json = acceso.ObtenerDatos("productos");

            //var listaProductos = JsonConvert.DeserializeObject<Objetos.Productos.RootObject>(json);

            //dataGridView1.DataSource = listaProductos.productos;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            Form1 edicionArticulos = new Form1();
            edicionArticulos.ShowDialog(this);
            edicionArticulos.BringToFront();

            if (edicionArticulos.Aceptar)
            {


                NameValueCollection parametros = new NameValueCollection();

                // Add necessary parameter/value pairs to the name/value container.
                parametros.Add("codigo_producto", edicionArticulos.Codigo);
                parametros.Add("descripcion", edicionArticulos.Descripcion);
                parametros.Add("stock", edicionArticulos.Cantidad.ToString());
                parametros.Add("cantidad_minima", "10");
                parametros.Add("precio_compra", edicionArticulos.Costo.ToString());
                parametros.Add("precio_venta", edicionArticulos.Venta.ToString());
                parametros.Add("proveedor_id", "1");
                parametros.Add("codigo_pedido", "1234");

                string response;
                //response = acceso.InsertarDatos("productos", parametros);

                // Decode and display the response.
                //MessageBox.Show(response);

                Inventario_Load(sender, e);

            }
            
        }
    }
}
