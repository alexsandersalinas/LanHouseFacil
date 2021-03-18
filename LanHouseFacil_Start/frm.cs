using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LanHouseFacil_Util;
using System.Threading;

namespace LanHouseFacil_START
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string s = "LanHouseFacil";

            foreach (System.Diagnostics.Process pr in System.Diagnostics.Process.GetProcessesByName(s))
            {
                if (!pr.HasExited) pr.Kill();
            }
            
            string s1 ="H:\\LanHouse\\LanHouse\\LanHouseFacil\\LanHouseFacil\\bin\\Release\\LanHouseFacil.exe";
            string s2 ="c:\\smartbras\\LanHouseFacil.exe";

            try
            {
                System.Diagnostics.Process.Start(@s1);
            }
            catch
            {

            }

            try
            {
                System.Diagnostics.Process.Start(@s2);
            }
            catch
            {

            }
            System.Diagnostics.Process.GetCurrentProcess().Close();
            Application.ExitThread();
            Application.Exit();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
