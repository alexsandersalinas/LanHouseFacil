using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Management;
using LanHouseFacil_Util;
using System.Configuration;
using System.Net.Sockets;

namespace LanHouseFacilSetup
{
    public partial class fUpdate : Form
    {
        static bool bSistemaGerenciador = false;
        static string sPath = Convert.ToString(ConfigurationManager.AppSettings["PathRede"]);
        public fUpdate()
        {
            InitializeComponent();
        }
        private void LoadStart()
        {
            LanHouseFacil_Util.Processos p = new LanHouseFacil_Util.Processos();
               MataProcessos();
        

         
         if (File.Exists(@"c:\\smartbras\\LanHouseFacil.exe") == true)
         {
             bSistemaGerenciador = true;
         }

         if (File.Exists(@"C:\\Program Files\\smartbras\\LanHouseFacilClient.exe") == true)
         {
             bSistemaGerenciador = false;
         }


             //  ExecutaSistema();
        }

     

       
        //private void ExecutaSistema()
        //{
        //      if (bSistemaGerenciador == true)
        //     {
        
        //         timer1.Start();
        //         try
        //         {
        //             //System.Diagnostics.Process pEXE = System.Diagnostics.Process.Start(@"c:\\smartbras\\LanHouseFacil.exe");
        //             System.Diagnostics.Process.GetProcessesByName(@"c:\\smartbras\\LanHouseFacil.exe");
        //         }
        //         catch
        //         {

        //         }
             
        //      }
        //    else
        //    {
        //        timer1.Start();
        //        System.Diagnostics.Process pEXE = System.Diagnostics.Process.Start(@"C:\\Program Files\\smartbras\\LanHouseFacilC.exe");
        //       // System.Diagnostics.Process.GetProcessesByName(@"C:\\Program Files\\smartbras\\LanHouseFacilC.exe");

        //         //string sARQ = "C:\\Program Files\\smartbras\\LanHouseFacilC.exe";
        //         //string work = System.IO.Path.GetDirectoryName(sARQ);
        //         //System.Diagnostics.Process proc = new System.Diagnostics.Process();
        //         //proc.StartInfo.WorkingDirectory = work;
        //         //proc.StartInfo.UseShellExecute = true;
        //         //proc.StartInfo.FileName = sARQ;
        //         //proc.StartInfo.Arguments = "1,2,3";
            

        //       }
        //     }


     

        private void MataProcessos()
        {

            LanHouseFacil_Util.Processos p = new LanHouseFacil_Util.Processos();
            p.KillProcess("LanHouseFacilC");
            p.KillProcess("LanHouseFacil");

            p = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           // Application.Exit();
            LanHouseFacil_Util.Processos p = new LanHouseFacil_Util.Processos();
            p.KillProcess("LanHouseFacilClient");
            p = null;
        }

        private void fUpdate_Load(object sender, EventArgs e)
        {
            LoadStart();
        }

        private void CarregaDir()
        {
            //string sPathDestino="C:\\Program Files\\smartbras";
            string sPathDestino = "C:\\temp\\smartbras";
            string sPathDestino2 = sPathDestino + "\\images";
            string sPathDestino3 = sPathDestino2 + "\\Client";
           

            try
            {

                if (Directory.Exists(@sPathDestino) == false)
                {
                    Directory.CreateDirectory(@sPathDestino);
                }

                if (Directory.Exists(@sPathDestino2) == false)
                {
                    Directory.CreateDirectory(@sPathDestino2);
                }

                if (Directory.Exists(@sPathDestino3) == false)
                {
                    Directory.CreateDirectory(@sPathDestino3);
                }
                
                DirectoryInfo diretorio = new DirectoryInfo(@sPath);
                FileInfo[] arquivos = diretorio.GetFiles("*.*");


                #region InstallDir
                foreach (FileInfo fileinfo in arquivos)
                {


                    string sFile = @sPath + "\\" + fileinfo.FullName.Replace(sPath, "").Replace("\\", "");
                    string sFileDados = fileinfo.FullName.Replace(sPath, "").Replace("\\", "");
                    if (File.Exists(@sPathDestino + "\\" + sFileDados) == true)
                    {
                        File.Delete(@sPathDestino + "\\" + sFileDados);
                    }

                    fileinfo.CopyTo(@sPathDestino + "\\" + sFileDados);


                }
            #endregion

                DirectoryInfo diretorioImg = new DirectoryInfo(@sPath + "\\images\\Client");
                FileInfo[] arquivosImg = diretorioImg.GetFiles("*.*");

                foreach (FileInfo fileinfo in arquivosImg)
                {


                    string sFile = sPath + "\\images\\Client\\" + fileinfo.FullName.Replace(sPath, "").Replace("\\", "").Replace("images","").Replace("Client","");
                    string sFileImg = fileinfo.FullName.Replace(sPath, "").Replace("\\", "").Replace("images", "").Replace("Client", "");
                    if (File.Exists(@sFile) == true)
                    {
                        File.Delete(sPathDestino3 + "\\" + sFileImg);
                    }

                    fileinfo.CopyTo(sPathDestino3 + "\\" + sFileImg);


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foram encontrados arquivos para transferencia e instalação!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregaDir();
           
            SalvaArquivoXML();

            MessageBox.Show("Instalação Completa!\nPendente a instalação para iniciar automaticamente via registro.");
            this.Close();
        }

        private void SalvaArquivoXML()
        {

            string sFile = sPath + "\\LanHouseFacilClient.exe.config";

            try
            {
                if (File.Exists(@sFile) == true)
                {
                    File.Delete(@sFile);
                }

                StreamWriter sw = new StreamWriter(@sFile, true, Encoding.ASCII);
                sw.Write("<?xml version='1.0' encoding='utf-8' ?>\n");
                sw.Write("<configuration>\n");
                sw.Write("<appSettings>\n");
                sw.Write("<add key='IPServer' value='" + mskIP.Text + "'></add>\n");
                sw.Write("<add key='NClient' value='" + txtTerminal.Text + "'></add>\n");
                sw.Write("<add key ='Control' value='false'/>\n");
                sw.Write("<add key ='PortServer' value='" + mskPort.Text + "'/>\n");
                sw.Write("</appSettings>\n");
                sw.Write("</configuration>\n");
                sw.Flush();
                sw.Close();

            }
            catch
            {

            }

        }

    }
}
