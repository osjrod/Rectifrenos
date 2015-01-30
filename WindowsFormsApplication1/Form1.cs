
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string Direccion; string nombreArchivo;

        private Boolean aceptar;
        string fotourl;
        public Form1()
        {
            InitializeComponent();
            this.aceptar = false;
        }

       
        public Boolean Aceptar
        {
            get { return aceptar; }
        }

        public string Codigo
        {
            get { return txtcodigo.Text.ToUpper(); }
        }

        public string Descripcion
        {
            get { return txtdescripcion.Text; }
        }

        public double Costo
        {
            get { return double.Parse(txtcosto.Text); }
        }

        public double Utilidad
        {
            get { return double.Parse(txtutilidad.Text); }
        }

        public double Venta
        {
            get { return double.Parse(txtventa.Text); }
        }

        public int Cantidad
        {
            get { return int.Parse(txtcantidad.Text); }
        }

        public string Foto
        {
            get { return txtimagen.Text; }
        }
        


        private void btnAceptar_Click(object sender, EventArgs e)
        {
          
                if (!txtcodigo.Text.Equals(""))
                {
                    try
                    {
                        FileInfo archivo = new FileInfo(Direccion);
                        archivo.CopyTo("C:/OSJROD/fotos/" + txtcodigo.Text + ".jpg");
                    }
                    catch { }
                    this.aceptar = true;
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Debe ingresar un codigo al producto");
                }
            
        }

        private void seleccionar_Click(object sender, EventArgs e)
        {
            abrir.ShowDialog();

            txtimagen.Text = abrir.FileName;

            Bitmap Picture = new Bitmap(txtimagen.Text);

            foto.BackgroundImage = Picture;

            Direccion = abrir.FileName;
            nombreArchivo = System.IO.Path.GetFileName(abrir.FileName);

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtcodigo.Select();
        }

        private void txtcodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();

                }
            }
        }

        private void txtdescripcion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();

                }
            }
        }

        private void txtcosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();

                }
            }
        }

        private void txtutilidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();

                }
            }
        }

        private void txtventa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();

                }
            }
        }

        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    e.Handled = true;
                    this.GetNextControl(ActiveControl, true).Focus();

                }
            }
        }

        private void txtcosto_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcosto_Click(object sender, EventArgs e)
        {
            txtcosto.SelectAll();
        }

        private void txtutilidad_Click(object sender, EventArgs e)
        {
            txtutilidad.SelectAll();
        }

        private void txtventa_Click(object sender, EventArgs e)
        {
            txtventa.SelectAll();
        }

        private void txtutilidad_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtventa_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtventa_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                double util = double.Parse(txtventa.Text) - double.Parse(txtcosto.Text);
                double cost = double.Parse(txtcosto.Text);


                txtutilidad.Text = (100 * util / cost).ToString();
            }
            catch
            {
            }

            
        }

        private void txtutilidad_KeyUp(object sender, KeyEventArgs e)
        {
            try{
                txtventa.Text = (double.Parse(txtcosto.Text) + (double.Parse(txtcosto.Text) * (double.Parse(txtutilidad.Text) / 100))).ToString();
            }
            catch
            {
            }
        }

        private void txtcosto_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtventa.Text = (double.Parse(txtcosto.Text) + (double.Parse(txtcosto.Text) * (double.Parse(txtutilidad.Text) / 100))).ToString();
            }
            catch { 
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }
    }
}
