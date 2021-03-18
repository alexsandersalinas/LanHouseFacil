using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections;

using System.Runtime.InteropServices;
namespace LanHouseFacil_Util
{
    public class Processos
    {

        // Get the current process.
        static Process currentProcess = Process.GetCurrentProcess();
        static ArrayList lst = new ArrayList();


        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);



        public ArrayList CarregaDados()
        {
            Processos myProcess = new Processos();
            myProcess.BindToRunningProcesses();


            return lst;
        }

        public Process infoProcess()
        {

            return currentProcess;
        }

        private void BindToRunningProcesses()
        {
            lst.Clear();
            // Get all processes running on the local computer.
            Process[] localAll = Process.GetProcesses();

            int contato = 0;
            for (int i = 0; i <= (localAll.Count() - 1); i++)
            {
                if (localAll[i].ProcessName.StartsWith("firefox") || localAll[i].ProcessName.StartsWith("iexplore")
                    || localAll[i].ProcessName.StartsWith("chrome") || localAll[i].ProcessName.StartsWith("tor"))
                {
                    lst.Insert(contato, localAll[i].ProcessName + ":" + localAll[contato].Id.ToString() + ":" + localAll[contato].StartInfo);
                    contato = contato + 1;
                }
            }




        }

        private void teste()
        {

            //Process p = Process.Start(@"X:\SYSTEM\Aplicacao\_Net\AcompanhamentoPend2\TF.AcompanhamentoDePendentes2.exe");
            //p.WaitForInputIdle();
            //Thread.Sleep(500);
            //SetParent(p.MainWindowHandle, panel2.Handle); 
        }

        public void KillProcess(String nome)
        {
            // Obtém lista de processos
            Process[] processos = Process.GetProcesses();

            foreach (Process p in processos)
            {
                if (p.ProcessName.ToUpper() ==  nome.ToUpper())
                {
                    try
                    {
                        p.Kill();
                        p.Close(); // Libera recursos associados.
                    }
                    catch
                    {

                    }
                }
            }
        }

        public void LoadApplication(string path, IntPtr handle, string browse)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int timeout = 10 * 1000;     // Timeout value (10s) in case we want to cancel the task if it's taking too long.


            string exe = browse;

            Process p = Process.Start(exe, path);


            while (p.MainWindowHandle == IntPtr.Zero)
            {
                System.Threading.Thread.Sleep(10);
                p.Refresh();

                if (sw.ElapsedMilliseconds > timeout)
                {
                    sw.Stop();
                    return;
                }
            }

            SetParent(p.MainWindowHandle, handle);      // Set the process parent window to the window we want
            SetWindowPos(p.MainWindowHandle, 0, 0, 0, 0, 0, 0x0001 | 0x0040);       // Place the window in the top left of the parent window without resizing it
        }


    
    }
}