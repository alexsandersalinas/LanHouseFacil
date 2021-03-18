using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LanHouseFacil_Util;
using System.Net.Sockets;
using System.Threading;
using LanHouseFacil_ENT;
using System.Management;
using System.Configuration;
using System.Diagnostics;

namespace LanHouseFacil
{
    
    public partial class frmGerenciador : Form
    {
        string sPATH ="";
        static bool bTaskbar = false;
        static bool sShutdown = false;
        static DateTime HS;
        static bool bAcessoLivre = false;
        static bool BootMaquina = false;
        static bool bSocketIniciado = false;
        static Thread tSocket;
        static IList<LanHouseFacil_ENT.estacaoENT> lst = new List<LanHouseFacil_ENT.estacaoENT>();
        static int iE1;
        static int iE2;
        static int iE3;
        static int iE4;
        static int iE5;
        static int iE6;
        static int iE7;
        static int iE8;
        static int iE9;
        static int iE10;
        static int iE11;
        static int iE12;
        static int iE13;
        static int iE14;
        static int iE15;
        static int iE16;
        static int iE17;
        static int iE18;
        static int iE19;
        static int iE20;
        static int iUltimaEstacao = -1;
        static int iUltimaEstacaoContador=0;
         
       // TcpListener serverSocket = new TcpListener(8888);
        static int iPortServer = Convert.ToInt32(ConfigurationManager.AppSettings["PortServer"]);    
        static bool bControl = Convert.ToBoolean(ConfigurationManager.AppSettings["Control"]);

      //  TcpListener serverSocket = new TcpListener(iPortServer);
        
        TcpClient clientSocket = default(TcpClient);

       
        public frmGerenciador()
        {
            InitializeComponent();

            try
            {
                LoadWallpaper();
            }
            catch
            {

            }

            ControleAcessoLivre(false);
            btnAcessoLivreICO();



            listBox1.Visible = bControl;
            button4.Visible = bControl;
            button3.Visible = bControl;
            button2.Visible = bControl;
            button5.Visible = bControl;


            mskINICIO.Text = "-";
            mskTempoInsert.Text = "-";
            mskTempoPendente.Text = "-";

            lst = LoadENT();
            sPATH = Application.StartupPath.ToString();
            // pctSocket.Enabled = false;
            timer2.Start();

            timer1.Start();
            timerHora.Start();
            BootMaquina = false;
            timerShutdownOFF.Start();
            //timer3.Start();

            AtivaSocketServer();
            //timerThread.Start();
           

        }

        private IList<LanHouseFacil_ENT.estacaoENT> LoadENT()
        {
            IList<LanHouseFacil_ENT.estacaoENT> lst = new List<LanHouseFacil_ENT.estacaoENT>();
           
            LanHouseFacil_ENT.estacaoENT e1 = new LanHouseFacil_ENT.estacaoENT();
            e1.EstacaoID = 1;

            LanHouseFacil_ENT.estacaoENT e2 = new LanHouseFacil_ENT.estacaoENT();
            e2.EstacaoID = 2;
            
            LanHouseFacil_ENT.estacaoENT e3 = new LanHouseFacil_ENT.estacaoENT();
            e3.EstacaoID = 3;

            LanHouseFacil_ENT.estacaoENT e4 = new LanHouseFacil_ENT.estacaoENT();
            e4.EstacaoID = 4;
            
            LanHouseFacil_ENT.estacaoENT e5 = new LanHouseFacil_ENT.estacaoENT();
            e5.EstacaoID = 5;

            LanHouseFacil_ENT.estacaoENT e6= new LanHouseFacil_ENT.estacaoENT();
            e6.EstacaoID = 6;

            LanHouseFacil_ENT.estacaoENT e7 = new LanHouseFacil_ENT.estacaoENT();
            e7.EstacaoID = 7;

            LanHouseFacil_ENT.estacaoENT e8 = new LanHouseFacil_ENT.estacaoENT();
            e8.EstacaoID = 8;

            LanHouseFacil_ENT.estacaoENT e9 = new LanHouseFacil_ENT.estacaoENT();
            e9.EstacaoID = 9;

            LanHouseFacil_ENT.estacaoENT e10= new LanHouseFacil_ENT.estacaoENT();
            e10.EstacaoID = 10;

            LanHouseFacil_ENT.estacaoENT e11= new LanHouseFacil_ENT.estacaoENT();
            e11.EstacaoID = 11;

            LanHouseFacil_ENT.estacaoENT e12= new LanHouseFacil_ENT.estacaoENT();
            e12.EstacaoID = 12;

            LanHouseFacil_ENT.estacaoENT e13= new LanHouseFacil_ENT.estacaoENT();
            e13.EstacaoID = 13;

            LanHouseFacil_ENT.estacaoENT e14= new LanHouseFacil_ENT.estacaoENT();
            e14.EstacaoID = 14;

            LanHouseFacil_ENT.estacaoENT e15= new LanHouseFacil_ENT.estacaoENT();
            e15.EstacaoID = 15;

            LanHouseFacil_ENT.estacaoENT e16= new LanHouseFacil_ENT.estacaoENT();
            e16.EstacaoID = 16;

            LanHouseFacil_ENT.estacaoENT e17 = new LanHouseFacil_ENT.estacaoENT();
            e17.EstacaoID = 17;

            LanHouseFacil_ENT.estacaoENT e18 = new LanHouseFacil_ENT.estacaoENT();
            e18.EstacaoID = 18;

            LanHouseFacil_ENT.estacaoENT e19 = new LanHouseFacil_ENT.estacaoENT();
            e19.EstacaoID = 19;

            LanHouseFacil_ENT.estacaoENT e20 = new LanHouseFacil_ENT.estacaoENT();
            e20.EstacaoID = 20;

            lst.Insert(0, e1);
            lst.Insert(1, e2);
            lst.Insert(2, e3);
            lst.Insert(3, e4);
            lst.Insert(4, e5);
            lst.Insert(5, e6);
            lst.Insert(6, e7);
            lst.Insert(7, e8);
            lst.Insert(8, e9);
            lst.Insert(9, e10);
            lst.Insert(10, e11);
            lst.Insert(11, e12);
            lst.Insert(12, e13);
            lst.Insert(13, e14);
            lst.Insert(14, e15);
            lst.Insert(15, e16);
            lst.Insert(16, e17);
            lst.Insert(17, e18);
            lst.Insert(18, e19);
            lst.Insert(19, e20);


            setEstacaoICO(1, 1);
            setEstacaoICO(1, 2);
            setEstacaoICO(1, 3);
            setEstacaoICO(1, 4);
            setEstacaoICO(1, 5);
            setEstacaoICO(1, 6);
            setEstacaoICO(1, 7);
            setEstacaoICO(1, 8);
            setEstacaoICO(1, 9);
            setEstacaoICO(1, 10);
            setEstacaoICO(1, 11);
            setEstacaoICO(1, 12);
            setEstacaoICO(1, 13);
            setEstacaoICO(1, 14);
            setEstacaoICO(1, 15);
            setEstacaoICO(1, 16);
            setEstacaoICO(1, 17);
            setEstacaoICO(1, 18);
            setEstacaoICO(1, 19);
            setEstacaoICO(1, 20);
            return lst;
        
        }

        private void AtivaSocketServer()
        {
            if (tSocket != null)
            {
                //clientSocket.Close();
                //Application.ExitThread();
            }
            
            try
            {
               
                    //Thread tSocket = new Thread(AtivarSocket);
                    tSocket = new Thread(new ThreadStart(AtivarSocket));
                    tSocket.Start();
                    bSocketIniciado = true;
                          
             }
            catch
            {
                tSocket = new Thread(new ThreadStart(AtivarSocket));
                tSocket.Start();
                bSocketIniciado = true;
            }
         

          }

        //private void timerThread_Tick(object sender, EventArgs e)
        //{
        //    AtivaSocketServer();
        //}

          
        
        private delegate void AddListBoxItemDelegate(object item);
        private void AddListBoxItem(object item)
        {
            if (this.listBox1.InvokeRequired)
            {
                // This is a worker thread so delegate the task.
                this.listBox1.Invoke(new AddListBoxItemDelegate(this.AddListBoxItem), item);
            }
            else
            {
                // This is the UI thread so perform the task.
                this.listBox1.Items.Add(item);
            }
        }

        public delegate void ClearDelegate(object item);

         private void ListBoxItemClear(object item)
        {
            if (this.listBox1.InvokeRequired)
            {
                // This is a worker thread so delegate the task.
                this.listBox1.Invoke(new ClearDelegate(ListBoxItemClear), new object[] { item });
            }
            else
            {
       
                // This is the UI thread so perform the task.
                this.listBox1.Items.Clear();
            }
        }


         private void ExecLoop(bool bExecucao, TcpListener serverSocket)
         {
             int requestCount = 0;
             int iMaquinaAtual = 0;
             string sID = "0";
             
             while ((true))
             {
                 Thread.Sleep(500);

                 if (bControl == true)
                 {
                     if (listBox1.Items.Count > 30)
                     {
                         ListBoxItemClear(listBox1);

                     }
                 }


                 //if (bSocketIniciado == false)
                 //{
                 //    //serverSocket.Stop();
                 //    break;
                 //}

                 //if (sShutdown == true)
                 //{
                 //    break;
                 //}

                 // requestCount = 0;
                 try
                 {


                     TcpClient clientSocket = serverSocket.AcceptTcpClient();

                     requestCount = requestCount + 1;
                     NetworkStream networkStream =  clientSocket.GetStream();
                     byte[] bytesFrom = new byte[10025];
                     int TotalBytes = (int)clientSocket.ReceiveBufferSize;

                     if (TotalBytes > 0 && clientSocket.Connected == true)
                     {

                         try
                         {
                             networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);


                             string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                             dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));

                             string[] arrEstacao = dataFromClient.Split('|');

                             sID = arrEstacao[0].ToString().Replace("E", "");


                             try
                             {
                                 iMaquinaAtual = Convert.ToInt32(sID);
                             }
                             catch
                             {
                                 iMaquinaAtual = -1;
                             }

                             if (iMaquinaAtual != iUltimaEstacao)
                             {


                                 try
                                 {
                                     iUltimaEstacao = Convert.ToInt32(sID);
                                 }
                                 catch
                                 {
                                     iUltimaEstacao = 0;
                                 }

                                 int EstacaoID = Convert.ToInt32(sID);
                                 setEstacaoStatus(EstacaoID);

                                 if (bControl == true)
                                 {
                                     try
                                     {
                                         AddListBoxItem(dataFromClient);
                                         // listBox1.Items.Add(dataFromClient);
                                     }
                                     catch
                                     {
                                         //  ListBoxItemClear(li;
                                     }
                                 }

                                 if (lst[EstacaoID - 1].EstacaoRUN == true)  //reiniciar
                                 {
                                     TimeSpan ts = new TimeSpan(HS.TimeOfDay.Hours, HS.TimeOfDay.Minutes, 0);
                                     if (DateTime.Now.Hour >= lst[EstacaoID - 1].TSEnd.Hours && DateTime.Now.Minute > lst[EstacaoID - 1].TSEnd.Minutes)
                                     {
                                         lst[EstacaoID - 1].EstacaoRUN = false;
                                         setEstacaoICO(2, EstacaoID);
                                     }
                                 }
                                 else
                                 {
                                     if (lst[EstacaoID - 1].setON == false)
                                     {
                                         //    setEstacaoICO(2, EstacaoID);

                                     }
                                 }

                                 if (bAcessoLivre == true)
                                 {

                                     TimeSpan ts = new TimeSpan(23, 59, 0);

                                     lst[EstacaoID - 1].TSEnd = ts;
                                     lst[EstacaoID - 1].EstacaoRUN = true;

                                 }


                                 string serverResponse = "DADOS|HS=" + DateTime.Now + "|SHUTDOWN=" + lst[EstacaoID - 1].Shutdown.ToString() + "|TSEND=" + lst[EstacaoID - 1].TSEnd;
                                 serverResponse += "|ESTACAORUN=" + lst[EstacaoID - 1].EstacaoRUN.ToString();
                                 serverResponse += "|REBOOT=" + lst[EstacaoID - 1].Reboot.ToString();
                                 serverResponse += "|DTSTART=" + lst[EstacaoID - 1].DTStart.ToString();
                                 serverResponse += "|END=";


                                 Byte[] sendBytes = Encoding.ASCII.GetBytes(serverResponse);

                                 try
                                 {
                                     networkStream.Write(sendBytes, 0, sendBytes.Length);
                                 }
                                 catch (Exception ex)
                                 {

                                 }

                             }

                             networkStream.Dispose();

                             iUltimaEstacaoContador += 1;
                             if (iUltimaEstacaoContador > 4)
                             {
                                 iUltimaEstacao = 0;

                             }

                         }
                         catch
                         {

                             iMaquinaAtual = -1;
                         }

                     }
                 }
                 catch (Exception ex)
                 {

                     if (bControl == true)
                     {
                         AddListBoxItem(ex.Message);

                     }

                     //AtivaSocketServer();

                 }

                // networkStream = null;

                 serverSocket.Stop();
                 serverSocket.Start();
             }

         }


         private void AtivarSocket()
         {

             TcpListener serverSocket = new TcpListener(System.Net.IPAddress.Any, iPortServer);
             serverSocket.Start();

             ExecLoop(true, serverSocket);

             //serverSocket.Stop();
             //AtivarSocket();


         }


        private void CloseThread()
        {
           
           // tSocket.Abort();

        }
        private void setEstacaoStatus(int id)
        {
           lst[id -1].EstacaoID = id;
           lst[id -1].StatusON = true;

        }

        private void iContadorTempoVidaEstacaoReset(int e)
        {
            if (1 == e)
            {
                iE1 = 1;
            }
            else if (2 == e)
            {
                iE2 = 1;
            }
            else if (3 == e)
            {
                iE3 = 1;
            }
            else if (4 == e)
            {
                iE4 = 1;
            }
            else if (5 == e)
            {
                iE5 = 1;
            }
            else if (6 == e)
            {
                iE6 = 1;
            }
            else if (7 == e)
            {
                iE7 = 1;
            }
            else if (8 == e)
            {
                iE8 = 1;
            }
            else if (9 == e)
            {
                iE9 = 1;
            }
            else if (10 == e)
            {
                iE10= 1;
            }
            else if (11 == e)
            {
                iE11 = 1;
            }
            else if (12 == e)
            {
                iE12 = 1;
            }
            else if (13 == e)
            {
                iE13 = 1;
            }
            else if (14 == e)
            {
                iE14 = 1;
            }
            else if (15 == e)
            {
                iE15 = 1;
            }
            else if (16 == e)
            {
                iE16 = 1;
            }
            else if (17 == e)
            {
                iE17 = 1;
            }
            else if (18 == e)
            {
                iE18 = 1;
            }
            else if (19 == e)
            {
                iE19 = 1;
            }
            else if (20 == e)
            {
                iE20 = 1;
            }

        }

        private void iContadorTempoVidaEstacao(int e)
        {
            if (1 ==e)
            {
                iE1 += 1;
            }
            else if (2 == e)
            {
                iE2 += 1;
            }
            else if (3 == e)
            {
                iE3 += 1;
            }
            else if (4 == e)
            {
                iE4 += 1;
            }
            else if (5 == e)
            {
                iE5 += 1;
            }
            else if (6 == e)
            {
                iE6 += 1;
            }
            else if (7 == e)
            {
                iE7 += 1;
            }
            else if (8 == e)
            {
                iE8 += 1;
            }
            else if (9 == e)
            {
                iE9 += 1;
            }
            else if (10 == e)
            {
                iE10 += 1;
            }
            else if (11 == e)
            {
                iE11 += 1;
            }
            else if (12 == e)
            {
                iE12 += 1;
            }
            else if (13 == e)
            {
                iE13 += 1;
            }
            else if (14 == e)
            {
                iE14 += 1;
            }
            else if (15 == e)
            {
                iE15 += 1;
            }
            else if (16 == e)
            {
                iE16 += 1;
            }
            else if (17 == e)
            {
                iE17 += 1;
            }
            else if (18 == e)
            {
                iE18 += 1;
            }
            else if (19 == e)
            {
                iE19 += 1;
            }
            else if (20 == e)
            {
                iE20 += 1;
            }

        }
        private bool iContadorTempoVidaEstacaoStatus(int e)
        {
            bool bRetorno = true;
            
            if (1 == e)
            {
                if (iE1 >= 100)
                {
                    iE1 = 0;
                    bRetorno= false;

                }
            }
            else if (2 == e)
            {
                if (iE2 >= 100)
                {
                    iE2 = 0;
                    bRetorno = false;
                }
            }
            else if (3 == e)
            {
                if (iE3 >= 100)
                {
                    iE3 = 0;
                    bRetorno = false;
                }
            }
            else if (4 == e)
            {
                if (iE4 >= 100)
                {
                    iE4 = 0;
                    bRetorno = false;
                }
            }
            else if (5 == e)
            {
                if (iE5 >= 100)
                {
                    iE5 = 0;
                    bRetorno = false;
                }
            }
            else if (6 == e)
            {
                if (iE6 >= 100)
                {
                    iE6 = 0;
                    bRetorno = false;
                }
            }
            else if (7 == e)
            {
                if (iE7 >= 100)
                {
                    iE7 = 0;
                    return false;
                }
            }
            else if (8 == e)
            {
                if (iE8 >= 100)
                {
                    iE8 = 0;
                    bRetorno = false;
                }
            }
            else if (9 == e)
            {
                if (iE9 >= 100)
                {
                    iE9 = 0;
                    bRetorno = false;
                }
            }
            else if (10 == e)
            {
                if (iE10 >= 100)
                {
                    iE10 = 0;
                    bRetorno = false;
                }
            }
            else if (11 == e)
            {
                if (iE11 >= 100)
                {
                    iE11 = 0;
                    bRetorno = false;
                }
            }
            else if (12 == e)
            {
                if (iE12 >= 100)
                {
                    iE12 = 0;
                    bRetorno = false;
                }
            }
            else if (13 == e)
            {
                if (iE13 >= 100)
                {
                    iE13 = 0;
                    bRetorno = false;
                }
            }
            else if (14 == e)
            {
                if (iE14 >= 100)
                {
                    iE14 = 0;
                    bRetorno = false;
                }
            }
            else if (15 == e)
            {
                if (iE15 >= 100)
                {
                    iE15 = 0;
                    bRetorno = false;
                }
            }
            else if (16 == e)
            {
                if (iE16 >= 100)
                {
                    iE16 = 0;
                    bRetorno = false;
                }
            }
            else if (17 == e)
            {
                if (iE17 >= 100)
                {

                    iE17 = 0;
                    bRetorno = false;
                }
            }
            else if (18 == e)
            {
                if (iE18 >= 100)
                {
                    iE18 = 0;
                    bRetorno = false;
                }
            }
            else if (19 == e)
            {
                if (iE19 >= 100)
                {
                    iE19 = 0;
                    bRetorno = false;
                }
            }
            else if (20 == e)
            {
                if (iE20 >= 100)
                {
                    iE20 = 0;
                    bRetorno = false;
                }
            }
            return bRetorno; ;
        }
        private  void setEstacaoICO(int status, int ID, string TempoRestante = null)
        {
       

                string sNomeObjeto = "Micro" + ID.ToString();
                for (int x = 0; x < this.Controls.Count ; x++)  //carrega controles do from
                {

                 
                    if (this.Controls[x].Name.StartsWith("toolStrip"))
                    {
                        for (int y = 0; y < ((ToolStrip)this.Controls[x]).Items.Count ; y++)   //ToolStrip
                        {
                            
                            if (((ToolStrip)this.Controls[x]).Items[y].Name == sNomeObjeto)
                                {
                                if (status == 4)
                                {

                                    //iContadorTempoVidaEstacao(ID);
                                    //if (iContadorTempoVidaEstacaoStatus(ID) == true)
                                    //{

                                        (((ToolStrip)this.Controls[x]).Items[y]).Image = LanHouseFacil.Properties.Resources.pc4;
                                        if (TempoRestante != null)
                                        {

                                            (((ToolStrip)this.Controls[x]).Items[y]).Text = TempoRestante;

                                        }
                                    //}
                                }
                                
                                else if (status == 3)
                                {
                                    (((ToolStrip)this.Controls[x]).Items[y]).Image = LanHouseFacil.Properties.Resources.pc3;
                                    (((ToolStrip)this.Controls[x]).Items[y]).Text = "";
                                }
                                else if (status == 2)
                                {
                                     //iContadorTempoVidaEstacao(ID);
                                     //if (iContadorTempoVidaEstacaoStatus(ID) == true)
                                     //{

                                         (((ToolStrip)this.Controls[x]).Items[y]).Image = LanHouseFacil.Properties.Resources.pc2;
                                         (((ToolStrip)this.Controls[x]).Items[y]).Text = "";
                                     //}
                                }
                                else
                                {
                                     iContadorTempoVidaEstacao(ID);
                                     if (iContadorTempoVidaEstacaoStatus(ID) == false)
                                     {
                                         (((ToolStrip)this.Controls[x]).Items[y]).Image = LanHouseFacil.Properties.Resources.pc1;
                                         (((ToolStrip)this.Controls[x]).Items[y]).Text = "";
                                     }
                                }
                            }

                            
                        }
                    } 

                 }
            
              
          
        }


        private void ValidaMicrosAtivos()
        {
            #region Micro1
            foreach (LanHouseFacil_ENT.estacaoENT item in lst)
            {
                if (item.StatusON == true &&  item.EstacaoRUN == true)
                {
                    setEstacaoICO(4, item.EstacaoID, TempoRestante( item.EstacaoID));

                }

                else if (item.setON == true && item.StatusON == true && item.EstacaoRUN == false)
                {
                    setEstacaoICO(3, item.EstacaoID);

                }
                else if (item.setON == false && item.StatusON == true && item.EstacaoRUN == false)
                {
                    setEstacaoICO(2, item.EstacaoID);

                }
                else //else if (item.setON = false && item.StatusON == false)
                {
                    setEstacaoICO(1, item.EstacaoID);

                }
             #endregion

            }

        }

        private void LoadWallpaper()
        {

            string sPATH = Application.StartupPath.ToString();
            LanHouseFacil_Util.clsFile f = new LanHouseFacil_Util.clsFile();

            string imgPath = f.ImageServer(sPATH, 1);
            Image i = new Bitmap(imgPath);
            this.BackgroundImage = i;
         }

    
        private void button3_Click(object sender, EventArgs e)
        {
            LoadWallpaper();         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LanHouseFacil_Util.clsTaskbar t = new LanHouseFacil_Util.clsTaskbar();

            if (bTaskbar == false)
            {
                t.Hide();
                bTaskbar = true;
            }
            else
            {
                if (bTaskbar == true)
                {
                    t.Show();
                    bTaskbar = false;
                }
            }

            t = null;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LanHouseFacil_Util.clsTaskbar t = new LanHouseFacil_Util.clsTaskbar();
            t.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LanHouseFacil_Util.clsKeyboard k = new LanHouseFacil_Util.clsKeyboard();
            k.KillCtrlAltDelete();
        }

        private void StatusMicroOFF()
        {

            foreach (LanHouseFacil_ENT.estacaoENT item in lst)
            {
                if (item.StatusON == true && item.setON == false)
                {
                    //item.setON = false;
                    item.StatusON = false;
                    item.Reboot = false;
                    item.Shutdown = false;
                    item.DtRUN = DateTime.Now;

                    //for (int i = 0; i <= 101; i++)
                    //{
                     // iContadorTempoVidaEstacao(item.EstacaoID);
                   //
                   //ContadorTempoVidaEstacaoStatus(item.EstacaoID);

                    setEstacaoICO(1, item.EstacaoID);
                }
             
            }
            
                   

        }


        private void BotaoSelecionado(int id)
        {
            mskTempoRestante.Text = "-";

            if (mskINICIO.Text == "" || mskINICIO.Text == "-")
            {
                mskINICIO.Text = "-";
            }

            if (mskTempoInsert.Text == "" || mskTempoInsert.Text == "-")
            {
                mskTempoInsert.Text = "-";
            }

            if (mskTempoPendente.Text == "" || mskTempoPendente.Text == "-")
            {
                mskTempoPendente.Text = "-";
            }
            
            foreach (LanHouseFacil_ENT.estacaoENT item in lst)
            {
                if (item.StatusON != false && item.EstacaoID == id)
                {
                    item.setON = !item.setON;
                    if (item.setON == true && item.EstacaoID == id)
                    {
                        setEstacaoICO(3, item.EstacaoID);
                        lblMicroSelecionado.Text = "Estação " + id.ToString();

                        if (item.EstacaoRUN == false)
                        {
                            btnLigar.Enabled = true;
                            mskINICIO.Text = "-";
                            mskTempoInsert.Text = "-";
                            mskTempoPendente.Text = "-";
                         //   lst[id - 1].DTStart = null;
                            TimeSpan ts = new TimeSpan(0, 0, 0);
                            item.TSInsert = ts;
                        }
                        else
                        {
                            if (item.DTStart != null)
                            {

                                mskINICIO.Text = item.DTStart.Value.Hour.ToString().PadLeft(2, '0') + ":" + item.DTStart.Value.Minute.ToString().PadLeft(2, '0');
                                mskTempoPendente.Text = DateTime.Today.Add(item.TSEnd).Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Today.Add(item.TSEnd).Minute.ToString().PadLeft(2, '0');
                                mskTempoInsert.Text = DateTime.Today.Add(item.TSInsert).Hour.ToString().PadLeft(2, '0') + ":" + DateTime.Today.Add(item.TSInsert).Minute.ToString().PadLeft(2, '0');

                                //item.TSInsert.ToString();

                                //meSpan ts1 = new TimeSpan(item.DTStart.Value.Hour, item.DTStart.Value.Minute, 0);

                                int hora = 0;
                                int min = 0;

                                hora = item.TSEnd.Hours - DateTime.Now.Hour;
                                min = item.TSEnd.Minutes - DateTime.Now.Minute;

                                TimeSpan ts2 = new TimeSpan(hora, min, 0);

                                mskTempoRestante.Text = ts2.TotalMinutes.ToString().Replace(".0", "").PadLeft(2, '0');


                            }

                        }
                    }
                }
                    
            }
           }

      

        private void button6_Click(object sender, EventArgs e)
        {
            sShutdown = true;
            timer2.Stop();
            timer1.Stop();
            // SynchronousSocketListener.StartListening();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ValidaMicrosAtivos();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            StatusMicroOFF();
        }

        private string TempoRestante(int id)
        {


            int hora = 0;
            int min = 0;

            hora = lst[id -1].TSEnd.Hours - DateTime.Now.Hour;
            min = lst[id - 1].TSEnd.Minutes - DateTime.Now.Minute;

            TimeSpan ts2 = new TimeSpan(hora, min, 0);

           return ts2.TotalMinutes.ToString().Replace(".0", "").PadLeft(2, '0');
          
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int id = Convert.ToInt32(lblMicroSelecionado.Text.Replace("Estação ", ""));

                if (id > 0)
                {
                    frmSetup s = new frmSetup();
                    s.ShowDialog();



                    string[] varr = s.Tempo.Split(':');
                    TimeSpan hr2 = new TimeSpan(Convert.ToInt32(varr[0]), Convert.ToInt32(varr[1]), 0);

                    lst[id - 1].TSInsert = lst[id - 1].TSInsert.Add(hr2);

                    mskTempoInsert.Text = lst[id - 1].TSInsert.ToString();
                    s = null;

                    ConfiguraAcesso(id);
                }
            }
            catch
            {
                MessageBox.Show("Selecione um estação!");

            }
            
           // ConfiguraAcesso();
           

        }

        private void ConfiguraAcesso(int id)
        {

                if (lst[id - 1].DTStart == null )
                {
                    lst[id - 1].DTStart = DateTime.Now;
                }

                TimeSpan hr1 = new TimeSpan(lst[id - 1].DTStart.Value.Hour, lst[id - 1].DTStart.Value.Minute, 0);
                mskINICIO.Text = hr1.ToString();



                string[] varr = mskTempoInsert.Text.Split(':');
                TimeSpan hr2 = new TimeSpan(Convert.ToInt32(varr[0]), Convert.ToInt32(varr[1]), 0);

                hr2 = hr1.Add(hr2);
                mskTempoPendente.Text = hr2.ToString();
                lst[id - 1].TSEnd = hr2;
                lst[id - 1].setON = false;
                setEstacaoICO(4, id);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblMicroSelecionado.Text.Replace("Estação ", ""));

            if (id > 0)
            {

                foreach (LanHouseFacil_ENT.estacaoENT item in lst)
                {
                    if (item.EstacaoID == id)
                    {

                        TimeSpan ts = new TimeSpan(0, 0, 0);

                        item.TSEnd = ts;
                     
                       
                        item.Shutdown = true;
                        item.setON = false;
                        setEstacaoICO(2, item.EstacaoID);
                       
                        //BootMaquina = true;
                        Thread.Sleep(1400);
                        DesligaShutdown(item.EstacaoID);
                    
                    }

                }

            }
        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblMicroSelecionado.Text.Replace("Estação ", ""));


                if (mskTempoInsert.Text.Replace("-", "") == "")
                {
                    MessageBox.Show("ENTRE COM O TEMPO PARA ACESSO!");
                }
                else
                {
                   
                    lst[id - 1].DTStart = DateTime.Now;
                    lst[id - 1].EstacaoRUN = true;
                    ConfiguraAcesso(id);
                   
                    btnLigar.Enabled = false;

                    //MatarSessao
                    for (int i=0; i <= 101; i++)
                    {
                        iContadorTempoVidaEstacao(id);
                    }
                    iContadorTempoVidaEstacaoStatus(id);
                    setEstacaoICO(1, id, "?");
                    

                }
            }
            catch
            {
                MessageBox.Show("Selecione uma estação!");
            }

        }

        private void btnTravarMicro_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblMicroSelecionado.Text.Replace("Estação ", ""));


               // lst[id - 1].EstacaoRUN = false;
                TimeSpan ts = new TimeSpan(0,0,0);

                lst[id - 1].TSEnd = ts;
                lst[id - 1].setON = false;
                lst[id - 1].DTStart = null;
                lst[id - 1].Reboot = false;
                lst[id - 1].Shutdown = false;
                setEstacaoICO(2, lst[id - 1].EstacaoID);
            
            }
            catch
            {
                MessageBox.Show("Selecione uma estação!");
            }
        }

        private void btnReiniciarMicro_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(lblMicroSelecionado.Text.Replace("Estação ", ""));

            if (id > 0)
            {

                foreach (LanHouseFacil_ENT.estacaoENT item in lst)
                {
                    if (item.EstacaoID == id)
                    {

                        TimeSpan ts = new TimeSpan(0, 0, 0);

                        item.TSEnd = ts;
                        item.Reboot = true;
                        item.setON = false;
                        setEstacaoICO(2, item.EstacaoID);
                        
                      //  BootMaquina = true;
                        Thread.Sleep(1400);
                        DesligaReboot(item.EstacaoID);


                    }

                }

            }
        }

        private void timerHora_Tick(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblMicroSelecionado.Text.Replace("Estação ", ""));
                if (id > 0)
                {

                    int hora = 0;
                    int min = 0;

                    hora = lst[id -1].TSEnd.Hours - DateTime.Now.Hour;
                    min = lst[id - 1].TSEnd.Minutes - DateTime.Now.Minute;

                    if (min >= 0)
                    {
                        TimeSpan ts2 = new TimeSpan(hora, min, 0);
                        mskTempoRestante.Text = ts2.TotalMinutes.ToString().Replace(".0", "");
                    }
                }
            }
            catch
            {

            }
            
            lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm");


        }


        private void btnAcessoLivreICO()
        {
            
                if (bAcessoLivre == true)
                {
                  
                       btnAcessoLivre.Image = LanHouseFacil.Properties.Resources.pc4;
                  
                }
                else
                {
                    btnAcessoLivre.Image = LanHouseFacil.Properties.Resources.pc3;
                }
        }
        private void ControleAcessoLivre(bool val)
        {   
            if (val == true)
            {
                 setEstacaoICO(4, 21);
            }
            else
            {
                setEstacaoICO(3, 21);

                foreach (LanHouseFacil_ENT.estacaoENT item in lst)
                {
                    TimeSpan ts = new TimeSpan(0, 0, 0);
                    
                    item.TSEnd = ts;
                    item.EstacaoRUN = false;
                    item.setON = false;
                    item.DTStart = null;
                    item.Reboot = false;
                    item.Shutdown = false;

                }
            }
        }
        private void btnAcessoLivre_Click(object sender, EventArgs e)
        {
            bAcessoLivre = !bAcessoLivre;
            ControleAcessoLivre(bAcessoLivre);
            btnAcessoLivreICO();
        }

        private void DesligaShutdown(int id )
        {
            
                foreach (LanHouseFacil_ENT.estacaoENT item in lst)
                {
                    if (item.EstacaoID == id)
                    {
                        item.Shutdown = true;
                    }
                }
            
        }

        private void DesligaReboot(int id)
        {
          
            
            foreach (LanHouseFacil_ENT.estacaoENT item in lst)
            {
                if (item.EstacaoID == id)
                {
                    item.Reboot = true;
                }
            }
        }

        //private void timerShutdownOFF_Tick(object sender, EventArgs e)
        //{
           
        //}

        private void Micro12_Click_1(object sender, EventArgs e)
        {
            BotaoSelecionado(12);
        }

        private void Micro20_Click_1(object sender, EventArgs e)
        {
            BotaoSelecionado(20);
        }

        private void Micro1_Click_1(object sender, EventArgs e)
        {
            BotaoSelecionado(1);
        }

        private void Micro2_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(2);
        }

        private void Micro3_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(3);
        }

        private void Micro4_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(4);
        }

        private void Micro5_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(5);
        }

        private void Micro6_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(6);
        }

        private void Micro7_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(7);
        }

        private void Micro8_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(8);
        }

        private void Micro9_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(9);
        }

        private void Micro10_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(10);
        }

        private void Micro11_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(11);
        }

        private void Micro13_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(13);
        }

        private void Micro14_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(14);
        }

        private void Micro15_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(15);
        }

        private void Micro16_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(16);
        }

        private void Micro17_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(17);
        }

        private void Micro18_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(18);
        }

        private void Micro19_Click(object sender, EventArgs e)
        {
            BotaoSelecionado(19);
        }

        private void microOFF_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirma a saida do sistema?", "Confirmation", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {

                bSocketIniciado = false;

                Thread.Sleep(5000);

                //   System.Threading.Thread.CurrentThread.Abort();
                string s = "starLANHOUSE.exe";

                foreach (System.Diagnostics.Process pr in System.Diagnostics.Process.GetProcessesByName(s))
                {
                    if (!pr.HasExited) pr.Kill();
                }

                System.Diagnostics.Process.GetCurrentProcess().Close();
                Application.ExitThread();
                Application.Exit();
            }
        }

        private void timerShutdownOFF_Tick(object sender, EventArgs e)
        {

        }

        //private void timerThread_Tick_1(object sender, EventArgs e)
        //{
        //    //AtivaSocketServer();
        //}

        private void frmGerenciador_Load(object sender, EventArgs e)
        {
            
      
            
        }

        

         public static bool VerificaProgramaEmExecucao()
        {
           return Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1;
        }


    }
}



