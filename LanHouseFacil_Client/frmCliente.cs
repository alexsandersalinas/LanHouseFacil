using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using LanHouseFacil_Util;
using System.Configuration;
using System.Net.Sockets;
using System.Threading;


namespace LanHouseFacilClient
{
    public partial class frmCliente : Form
    {
        static bool bTaskbar = false;
        static bool bCursor = false;
        static int iTotalFileWallpaper = 0;
        static int iTotalWallpaper = 0;
        static bool bHideFormON = false;
        static bool SocketON = false;
        static bool EstacaoRUN = false;
        static Thread tSocketAlert;
        static IList<LanHouseFacil_ENT.estacaoENT> lst = new List<LanHouseFacil_ENT.estacaoENT>();
        static DateTime HS;
        static int iPortServer = Convert.ToInt32(ConfigurationManager.AppSettings["PortServer"]);
        static bool bAvisoMensagemCincoMinutos = false;
        static bool bAvisoCincoMinutosRecebido = false;
        static int iERROCONEXAO = 0;
        static bool  bAvisoTempoFim = false;
        static bool bControl = Convert.ToBoolean(ConfigurationManager.AppSettings["Control"]);
        public frmCliente()
        {
            InitializeComponent();
            LigarEstacao();
            
        }

        private void kill(string var)
        {
            LanHouseFacil_Util.Processos p = new Processos();
            try
            {

                p.KillProcess(var);
            }
            catch
            {

            }
            p = null;
        }

        private void CloseProcess()
        {
            kill("skype");
            kill("chrome");
            kill("iexplore");
            kill("firefox");
            kill("winword");
            kill("word");
            kill("excel");
            kill("Spotify.exe");
            kill("Spotify");
            kill("SpotifyCrashService.exe");
            kill("SpotifyWebHelper.exe");
            TravaNavegacao();
            bAvisoCincoMinutosRecebido = false;
        }
        private void LigarEstacao()
        {

            CloseProcess();

            LanHouseFacil_ENT.estacaoENT e1 = new LanHouseFacil_ENT.estacaoENT();
            e1.EstacaoID = Convert.ToInt32(ConfigurationManager.AppSettings["NClient"]);
            lblMaquina.Text = e1.EstacaoID.ToString();
         
            
                button4.Visible = bControl;
                button9.Visible = bControl;
                button10.Visible = bControl;
                button3.Visible = bControl;
                button6.Visible = bControl;
                button7.Visible = bControl;
                button8.Visible = bControl;
                button2.Visible = bControl;
                button5.Visible = bControl;
                button1.Visible = bControl;
                button11.Visible = bControl;
                listBox1.Visible = bControl;

            lst.Insert(0, e1);

            LoadWallpaper();

            travarBtnIniciar();
            TravarBTarefas();
            TravaTeclado();

        //   lblVersao.Top = frmCliente.ActiveForm.Height;

          

            timer1.Start();
            timerHide.Start();
            timerRUN.Start();
            timer2.Start();
            LoadFormAlert();
        
        }

        private void LoadWallpaper()
        {

            string sPATH = Application.StartupPath.ToString();
            LanHouseFacil_Util.clsFile f = new LanHouseFacil_Util.clsFile();


            iTotalFileWallpaper = f.ReturnCoutWallpaperClient(sPATH);

            
            string imgPath = f.IamgeClient(sPATH, iTotalWallpaper);
            Image i = new Bitmap(imgPath);
            this.BackgroundImage = i;



        }

        //private void CursorStatus()
        //{
        //    if (bCursor== true)
        //    {
        //          Cursor.Hide();
        //        bCursor = true;

        //    }
        //    else
        //    {
        //          Cursor.Show();
        //         bCursor = false;
        //    }
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

        private void button2_Click(object sender, EventArgs e)
        {
            TravarBTarefas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            travarBtnIniciar();
        }

        private void travarBtnIniciar()
        {
            LanHouseFacil_Util.clsKeyboard b = new LanHouseFacil_Util.clsKeyboard();
            b.HideBtnStart();
        }

        private void TravarBTarefas()
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

        private void button5_Click(object sender, EventArgs e)
        {
         //   BLL.clsKeyboard k = new BLL.clsKeyboard();
         //   k.KillCtrlAltDelete();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                tSocketAlert.Abort();
                tSocketAlert.Join();

            }
            catch
            {

            }
            
            this.FormClosing -= new System.Windows.Forms.FormClosingEventHandler(this.frmCliente_FormClosing);
            
            
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // CursorStatus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Maxmizer();
        }

        private void Maxmizer()
        {
            this.MaximizeBox = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      }
        private void button7_Click(object sender, EventArgs e)
        {
            DesligaPC();
        }

        private void DesligaPC()
        {
          
            LanHouseFacil_Util.clsShutdown bll = new LanHouseFacil_Util.clsShutdown();
            bll.ShutdownCmd();


        }

        private void ReiniciarPC()
        {

            LanHouseFacil_Util.clsShutdown bll = new LanHouseFacil_Util.clsShutdown();
            //bll.Restart();
            bll.RebootCmd();


        }


        private void InterrompeDesligaPC()
        {
           LanHouseFacil_Util.clsShutdown bll = new LanHouseFacil_Util.clsShutdown();
            bll.UnShutdownCmd();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InterrompeDesligaPC();
        }

        private void TravaTeclado()
        {
            LanHouseFacil_Util.clsKeyboard k = new clsKeyboard();
            k.LockKeyboard();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            TravaTeclado();
        }

        private void frmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (lst[0].EstacaoRUN == false)
            {

                if (e.KeyCode == Keys.LWin || e.KeyCode == Keys.RWin)
                {
                   // MessageBox.Show("TESTE");
                    this.Show();
                }
            }
        }

        private void frmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadWallpaper();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            LanHouseFacil_Util.clsManagerTask b = new clsManagerTask();
            b.Lock();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //SynchronousSocketClient.StartClient();
         //   ConectarServer();

        }

        private void IniciarStatusSocket()
        {

            if (SocketON == false)
            {
            Thread tSocket = new Thread(VerificaSinalSocketServerON);
            tSocket.Start();
            }

        }


        private void Conecta()
        {
           // Thread.Sleep(350);
            SocketON = true;
            System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();

            string appConfIP = ConfigurationManager.AppSettings["IPServer"].ToString();
            string NClient = "E" + ConfigurationManager.AppSettings["NClient"].ToString();
            clientSocket.Connect(appConfIP, iPortServer);

            NClient = NClient + "|RUN=" + EstacaoRUN.ToString() + "|HIDDEN=" + bHideFormON.ToString() + "|DTNOW:" + DateTime.Now.ToShortTimeString();
            NetworkStream serverSteam = clientSocket.GetStream();
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(NClient + "$");
            serverSteam.Write(outStream, 0, outStream.Length);
            serverSteam.Flush();

            string returndata = "";
            byte[] inStream = new byte[10025];
            try
            {
                serverSteam.Read(inStream, 0, (int)clientSocket.ReceiveBufferSize);
                 returndata = System.Text.Encoding.ASCII.GetString(inStream);

            }
            catch
            {

            }
            if (bControl == true)
            {
                try
                {
                    tSocketAlert.Abort();
                    tSocketAlert.Join();
                }
                catch(ThreadAbortException t)
                {
                    //
                }
                
                try
                {
                    AddListBoxItem(returndata);

                }
                catch (Exception ex)
                {


                    AddListBoxItem(ex.Message);
                }
            }
           
            if (returndata.Length > 0)
            {
                //SocketON = true;
                //try
                //{
                //    tSocketAlert.Abort();
                //}
                //catch
                //{
                //}
                string[] arr = returndata.Split('|');

                for (int i = 0; i <= (arr.Length - 1); i++)
                {
                    if (arr[i].ToString().StartsWith("SHUTDOWN"))
                    {
                        lst[0].Shutdown = Convert.ToBoolean(arr[i].ToString().Replace("SHUTDOWN=", ""));

                        if (lst[0].Shutdown == true)
                        {
                            DesligaPC();

                        }

                    }

                    if (arr[i].ToString().StartsWith("REBOOT"))
                    {
                        lst[0].Reboot = Convert.ToBoolean(arr[i].ToString().Replace("REBOOT=", ""));

                        if (lst[0].Reboot == true)
                        {
                            ReiniciarPC();
                        }

                    }

                    if (arr[i].ToString().StartsWith("TSEND"))
                    {
                        string val = arr[i].Replace("TSEND=", "").ToString();
                        string[] varr = val.Split(':');
                        TimeSpan hr2 = new TimeSpan(Convert.ToInt32(varr[0]), Convert.ToInt32(varr[1]), 0);
                        lst[0].TSEnd = hr2;

                    }

                    if (arr[i].ToString().ToUpper().StartsWith("DTSTART="))
                    {
                        if (arr[i].Replace("DTSTART=", "") != "")
                        {
                            lst[0].DTStart = Convert.ToDateTime(arr[i].Replace("DTSTART=", ""));
                           
                        }
                    }

                    if (arr[i].ToString().ToUpper().StartsWith("ESTACAORUN=T"))
                    {
                        lst[0].EstacaoRUN = true;

                        //  bAvisoMensagemCincoMinutos = true;

                    }
                    if (arr[i].ToString().ToUpper().StartsWith("ESTACAORUN=F"))
                    {
                        lst[0].EstacaoRUN = false;

                    }
                    if (arr[i].ToString().StartsWith("HS"))
                    {
                        HS = Convert.ToDateTime(arr[i].ToString().Replace("HS=", ""));

                    }

                   // TempoFIm();

                    #region AvisoCincoMinutos
                    int Hora = 0;
                    int minuto = 0;
                    int umminuto = 0;
                    Hora = lst[0].TSEnd.Hours;
                    minuto = Convert.ToInt32(lst[0].TSEnd.Minutes);
                    umminuto = umminuto - 1;
                    minuto = minuto - 5;
                    

                    //Thread.Sleep(400);
                    //if (lst[0].DTStart != null) // estacao devera esta ativa
                    //{
                    if (Convert.ToInt32(HS.Hour) <= Hora
                            && minuto <=Convert.ToInt32(HS.Minute) 
                            && EstacaoRUN == true
                            && bAvisoMensagemCincoMinutos == true)
                        {
                            if (bAvisoCincoMinutosRecebido == false)
                            {
                                bAvisoCincoMinutosRecebido = true;
                                bAvisoMensagemCincoMinutos = false;

                                // MessageBox.Show("Faltam 5 minutos para terminar o seu tempo!");
                                LanHouseFacil_Util.MessageBoxTimer msg = new LanHouseFacil_Util.MessageBoxTimer();

                                if (minuto >= Convert.ToInt32(HS.Minute))
                                {

                                    msg.Show("MessageBox Timeout", "Faltam 5 minutos para terminar o seu tempo!", 0, 12000);
                                    Thread.Sleep(2000);
                                }
                                //else if (umminuto == Convert.ToInt32(HS.Minute))
                                ////{
                                ////    msg.Show("MessageBox Timeout", "Falta 1 minuto para terminar o seu tempo!", 0, 9000);
                                ////    Thread.Sleep(2000);
                                ////}
                                //else
                                //{
                                //    msg.Show("MessageBox Timeout", "O seu tempo está terminando!", 0, 9000);
                                //    Thread.Sleep(2000);
                                //}

                              
                               
                            }
                        }
                    //}
                    #endregion

                    #region AtivaEstacao
                    if (lst[0].EstacaoRUN == true)
                    {
                        if (EstacaoRUN == false && bAvisoTempoFim==false)
                        {

                            TimeSpan ts = new TimeSpan(HS.TimeOfDay.Hours, HS.TimeOfDay.Minutes, 0);
                            //if (ts.Hours <= lst[0].TSEnd.Hours && ts.Minutes <= lst[0].TSEnd.Minutes)
                            if (ts <=  lst[0].TSEnd)
                            {
                               
                                bAvisoMensagemCincoMinutos = true;
                                bAvisoTempoFim = false;

                                EstacaoRUN = true;
                                bTaskbar = true;

                                TravarBTarefas();
                                bHideFormON = true;

                                LiberarNAvegacao();
                            }
                        }
                    }
                    #endregion

                }
                serverSteam.Flush();
                
                serverSteam.Dispose();
                clientSocket.Close();
                SocketON = false;
            }
        }



      
  
        private void VerificaSinalSocketServerON()
        {

           

                try
                {
                    iERROCONEXAO = 0;
                 //   SocketON = false;
                    Conecta();
                }
                catch
                {
                    iERROCONEXAO += 1;
                    if (iERROCONEXAO > 0)
                    {
                        SocketON = false;
                        tSocketAlert = new Thread(new ThreadStart(LoadFormAlert));
                        tSocketAlert.Start();

                        Thread.Sleep(200);
                        tSocketAlert.Abort();
                       
                    }
                }
               
        
       
        }

        private void LoadFormAlert()
        {

            if (EstacaoRUN == false)
            {

                //LanHouseFacil_Util.MessageBoxTimer msg = new LanHouseFacil_Util.MessageBoxTimer();
                //msg.Show("Comunicação....", "COMUNICANDO COM SERVIDOR....", 0, 5000);
                //Thread.Sleep(2000);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            VerificaSinalSocketServerON();
            //IniciarStatusSocket();
        }


        private void TempoFIm()
        {

                TimeSpan ts = new TimeSpan(HS.TimeOfDay.Hours, HS.TimeOfDay.Minutes, 0);

                if (lst[0].TSEnd < ts && EstacaoRUN == true && bHideFormON == true && bAvisoTempoFim == false)  ////if (ts.Hours >= lst[0].TSEnd.Hours && ts.Minutes > lst[0].TSEnd.Minutes)
                {
                    if (bAvisoTempoFim == false)
                    {
                        lst[0].EstacaoRUN = false;
                        bHideFormON = false;
                        EstacaoRUN = false;
                        bAvisoTempoFim = true;
                       
                        Libera();
                        CloseProcess();
                    }
                }
           
        }

        private void timerRUN_Tick(object sender, EventArgs e)
        {

            TempoFIm();
        }


        private void Libera()
        {
            if (bHideFormON == true)
            {
                this.Hide();

            }
            else if (bHideFormON == false && EstacaoRUN == false)
            {

                this.Show();
                if (bAvisoTempoFim == true)
                {
                    bAvisoTempoFim = false;
                    LanHouseFacil_Util.MessageBoxTimer msg = new LanHouseFacil_Util.MessageBoxTimer();
                    msg.Show("TEMPO", "O SEU TEMPO ACABOU!", 0, 15000);
                    TravaNavegacao();
                }

            
            }
        }
        private void timerHide_Tick(object sender, EventArgs e)
        {
            Libera();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TravaNavegacao();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //LiberarNAvegacao();
        }

        private void TravaNavegacao()
        {
         
              //  kill("EXPLORER.EXE");
         
          
        }


        private void LiberarNAvegacao()
        {
            //try
            //{
            //    //System.Diagnostics.Process.Start(@"C:\TEMP\1.BAT");
            //    System.Diagnostics.Process.Start("EXPLORER");
            //}
            //catch
            //{

            //}
        }
      

      
        //protected override void WndProc(ref Message m)
        //{
        //   switch(m.Msg){
        //       case 0x0112:
        //            in command = m.WParam.ToInt32() & 0xfff0;
        //           int ((new int[] {0xF010x 0XF120}).Contains(Command)){
        //               if (this.WindowState != FromWindowsState.Maxi
        //           }
        //}
    }
}
