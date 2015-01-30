using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            //string json = acceso.ObtenerDatos("facturas");

            //var listaFacturas = JsonConvert.DeserializeObject<Objetos.Facturas.RootObject>(json);

            //dataGridView1.DataSource = listaFacturas.facturas;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            NuevaFactura nFactura = new NuevaFactura();
            nFactura.TopLevel = false;
            nFactura.AutoScroll = true;
            this.Parent.Controls.Add(nFactura);
            nFactura.Show();
            nFactura.BringToFront();
        }
    }
}
