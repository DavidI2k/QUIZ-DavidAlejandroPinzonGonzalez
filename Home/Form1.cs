using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtbGuardado.AppendText(txtNombres.Text + "\r\n");
            rtbGuardado.AppendText(txtApellidos.Text);
            rtbGuardado.AppendText(txtEmail.Text + "\r\n");
            rtbGuardado.AppendText(dtpFechaN.Value + "\r\n");
            rtbGuardado.AppendText(cmbGenero.Text + "\r\n");
            rtbGuardado.AppendText(cmbID.Text + "\r\n");
            rtbGuardado.AppendText(txtNumID.Text + "\r\n");
            rtbGuardado.AppendText(txtContra.Text + "\r\n");
            
            if (rbE1.Checked)
                rtbGuardado.AppendText(rbE1.Text);
            if (rbE2.Checked)
                rtbGuardado.AppendText(rbE2.Text);
            if (rbE3.Checked)
                rtbGuardado.AppendText(rbE3.Text);
            if (rbE4.Checked)
                rtbGuardado.AppendText(rbE4.Text);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report mireport = new Report(rtbGuardado.Text);
            mireport.Show();
        }
    }
}
