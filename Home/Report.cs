﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home
{
    public partial class Report : Form
    {
        public Report(string pMensaje)
        {
            InitializeComponent();
            lblMensaje.Text = pMensaje;
        }
    }
}