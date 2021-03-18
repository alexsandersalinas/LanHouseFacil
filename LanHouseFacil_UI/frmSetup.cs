using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LanHouseFacil
{
    public partial class frmSetup : Form
    {
        public string Tempo = "0:00";
        public frmSetup()
        {
            InitializeComponent();
            mskTempo.Focus();
        }

        private void btnINCLUIR_Click(object sender, EventArgs e)
        {
            Tempo = mskTempo.Text;
            this.Close();
        }
    }
}
