﻿using System;
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
    public partial class Proformas2 : Form
    {
        AccesoWebService acceso;
        public Proformas2(AccesoWebService acceso)
        {
            InitializeComponent();
            this.acceso = acceso;
        }
    }
}
