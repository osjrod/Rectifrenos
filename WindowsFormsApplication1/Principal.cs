using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Datos;

namespace WindowsFormsApplication1
{
    public partial class Principal : Form
    {
        private int imageNumber = 1;
        public Principal()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(!this.panel2.HasChildren){
                Factura facturas = new Factura();
                facturas.TopLevel = false;
                facturas.AutoScroll = true;
                this.panel2.Controls.Add(facturas);
                facturas.Show();

            }
            else
            {
                Control[] control = this.panel2.Controls.Find("facturas", false);


                if (control.Length == 0)
                {
                    this.panel2.Controls.Clear();
                    Factura facturas = new Factura();
                    facturas.TopLevel = false;
                    facturas.AutoScroll = true;
                    this.panel2.Controls.Add(facturas);
                    facturas.Show();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Width = this.panel1.Width-20;
            pictureBox1.Height = this.panel1.Width - 20;
        }

        private void loadNextImage()
        {
            if (imageNumber == 4)
            {
                imageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"C:\Users\oscarluis\Desktop\imagenes rectifrenos\slide{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadNextImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.panel2.HasChildren)
            {
                Proveedores proveedores = new Proveedores();
                proveedores.TopLevel = false;
                proveedores.AutoScroll = true;
                this.panel2.Controls.Add(proveedores);
                proveedores.Show();

            }
            else
            {
                Control[] control = this.panel2.Controls.Find("proveedores",false);


                if (control.Length == 0)
                {
                    this.panel2.Controls.Clear();
                    Proveedores proveedores = new Proveedores();
                    proveedores.TopLevel = false;
                    proveedores.AutoScroll = true;
                    this.panel2.Controls.Add(proveedores);
                    proveedores.Show();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!this.panel2.HasChildren)
            {
                Inventario inventario = new Inventario();
                inventario.TopLevel = false;
                inventario.AutoScroll = true;
                this.panel2.Controls.Add(inventario);
                inventario.Show();

            }
            else
            {
                Control[] control = this.panel2.Controls.Find("inventario", false);


                if (control.Length == 0)
                {
                    this.panel2.Controls.Clear();
                    Inventario inventario = new Inventario();
                    inventario.TopLevel = false;
                    inventario.AutoScroll = true;
                    this.panel2.Controls.Add(inventario);
                    inventario.Show();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!this.panel2.HasChildren)
            {
                Clientes clientes = new Clientes();
                clientes.TopLevel = false;
                clientes.AutoScroll = true;
                this.panel2.Controls.Add(clientes);
                clientes.Show();

            }
            else
            {
                Control[] control = this.panel2.Controls.Find("clientes", false);


                if (control.Length == 0)
                {
                    this.panel2.Controls.Clear();
                    Clientes clientes = new Clientes();
                    clientes.TopLevel = false;
                    clientes.AutoScroll = true;
                    this.panel2.Controls.Add(clientes);
                    clientes.Show();
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!this.panel2.HasChildren)
            {
                Proformas1 proforma1 = new Proformas1();
                proforma1.TopLevel = false;
                proforma1.AutoScroll = true;
                this.panel2.Controls.Add(proforma1);
                proforma1.Show();

            }
            else
            {
                Control[] control = this.panel2.Controls.Find("Proforma1", false);


                if (control.Length == 0)
                {
                    this.panel2.Controls.Clear();
                    Proformas1 proforma1 = new Proformas1();
                    proforma1.TopLevel = false;
                    proforma1.AutoScroll = true;
                    this.panel2.Controls.Add(proforma1);
                    proforma1.Show();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!this.panel2.HasChildren)
            {
                Proformas2 proforma2 = new Proformas2();
                proforma2.TopLevel = false;
                proforma2.AutoScroll = true;
                this.panel2.Controls.Add(proforma2);
                proforma2.Show();

            }
            else
            {
                Control[] control = this.panel2.Controls.Find("Proforma2", false);


                if (control.Length == 0)
                {
                    this.panel2.Controls.Clear();
                    Proformas2 proforma2 = new Proformas2();
                    proforma2.TopLevel = false;
                    proforma2.AutoScroll = true;
                    this.panel2.Controls.Add(proforma2);
                    proforma2.Show();
                }
            }
        }
    }
}
