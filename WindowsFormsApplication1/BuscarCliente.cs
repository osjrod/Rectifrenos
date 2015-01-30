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
    public partial class BuscarCliente : Form
    {
        DataTable datos;
        String encontrado = "";

        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void BuscarCliente_Load(object sender, EventArgs e)
        {
           // string json = acceso.ObtenerDatos("clientes");

           // var listaClientes = JsonConvert.DeserializeObject<Objetos.Clientes.RootObject>(json);


           //datos = Objetos.data.ConvertirListaClientesToDataTable(listaClientes.clientes);

           // dataGridView1.AutoGenerateColumns = false;
           // dataGridView1.DataSource = datos;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            string fieldName = string.Concat("[", datos.Columns[2].ColumnName, "]");
            datos.DefaultView.Sort = fieldName;
            DataView view = datos.DefaultView;
            view.RowFilter = string.Empty;
            if (toolStripTextBox1.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + toolStripTextBox1.Text + "%'";
            dataGridView1.DataSource = view;
            

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int fila = this.dataGridView1.CurrentRow.Index;

            encontrado = this.dataGridView1[2, fila].Value.ToString();

            Close();
            
        }

        public String Encontrado
        {
            get { return encontrado; }
        }
    }
}
