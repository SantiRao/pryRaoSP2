using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRaoSP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            if (txtDias.Text != "")
            {
                mrcAdicionales.Enabled = true;
                mrcFormasdePago.Enabled = true;
            }
            else
            {
                mrcAdicionales.Enabled = false;
                mrcFormasdePago.Enabled = false;
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex != -1)
            {
                cboPersonas.Enabled = true ;
            }
        }

        private void cboPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPersonas.SelectedIndex != -1)
            {
                txtDias.Enabled = true;
            }
        }
    }
}
