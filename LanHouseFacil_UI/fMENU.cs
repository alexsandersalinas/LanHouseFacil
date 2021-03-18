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
    public partial class fMENU : Form
    {
        public fMENU()
        {
            InitializeComponent();
            frmGerenciador f = new frmGerenciador();
            f.MdiParent = this;
            f.Height = this.Height;
            f.Show();

        }

        private void fMENU_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e); 
        }
    }
}
