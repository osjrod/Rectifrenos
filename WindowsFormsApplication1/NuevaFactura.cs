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
    public partial class NuevaFactura : Form
    {
        decimal subtotal = 0;
        int? client = null;

        int usuario;
        int tipo;
        int? ver = null;
        int numero;

        public NuevaFactura()
        {
            InitializeComponent();
        }

        
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentRow.Cells[0].Value == null)
            {
                try
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
                catch
                {
                }
            }
            else
            {
                //string json = acceso.ObtenerDatos("productos/codigo/" + dataGridView1.CurrentRow.Cells[0].Value.ToString().ToUpper());

                //var producto = JsonConvert.DeserializeObject<Objetos.Productos.RootObject2>(json);


                //if (producto.resultados == true )
                //{
                //    dataGridView1.CurrentRow.Cells[1].Value = producto.producto.descripcion;
                //    dataGridView1.CurrentRow.Cells[3].Value = producto.producto.precio_venta;
                //    decimal venta = producto.producto.precio_venta;
                //    decimal importe = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[2].Value) * venta;
                //    dataGridView1.CurrentRow.Cells[4].Value = importe;

                //}
                //else
                //{
                //    MessageBox.Show("El codigo introducido no coincide con ningun articulo", "Error");
                //    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                //}

            }

            for (int i = 0; i < dataGridView1.RowCount - 2; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[0].Value.ToString()))
                {
                    double cantidad = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    cantidad++;
                    dataGridView1.Rows[i].Cells[2].Value = cantidad;
                    dataGridView1.Rows[i].Cells[4].Value = cantidad * Convert.ToDouble(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
                }
            }
            dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
            subtotal = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    subtotal += (decimal)row.Cells[4].Value;
                }
            }

            totales();
        }

        public void totales()
        {
            
            try
            {
                txtsubtotal.Text = subtotal.ToString();
                txttotal.Text = (subtotal - (subtotal * (int.Parse(txtdescuento.Text)) / 100)).ToString();
            }
            catch
            {
            }

        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[2].Value = 1;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                
            }
            else if (e.KeyValue == (char)Keys.Escape)
            {
               
            }
            else if (e.KeyValue == (char)Keys.F1)
            {
                
            }
            else if (e.KeyValue == (char)Keys.Delete)
            {
                if (dataGridView1.RowCount > 1)
                {
                    try
                    {
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    }
                    catch
                    {

                    }
                    
                }
                
            }
        }

        private void txtsubtotal_TextChanged(object sender, EventArgs e)
        {
            if (ver == null)
            {
                totales();
            }
        }

        private void txtdescuento_TextChanged(object sender, EventArgs e)
        {
            if (txtdescuento.Text == "")
            {
                txttotal.Text = txtsubtotal.Text;
            }
            else
            {
                totales();
            }
            
        }

        private void txtdescuento_Click(object sender, EventArgs e)
        {
            txtdescuento.SelectAll();
        }

        private void txtdescuento_KeyUp(object sender, KeyEventArgs e)
        {

        }




        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

       

       

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtcliente_Leave(object sender, EventArgs e)
        {
           
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //BuscarCliente buscar = new BuscarCliente(acceso);
            //buscar.ShowDialog();

            //if (buscar.Encontrado != "")
            //{
            //    txtcliente.Text = buscar.Encontrado;
            //}
            

        }

       

        private void button2_Click(object sender, EventArgs e)
        {

           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


      
        private void button5_Click(object sender, EventArgs e)
        {
           

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

  

        

        



    }
}
