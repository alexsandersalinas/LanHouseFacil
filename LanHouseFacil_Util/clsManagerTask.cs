using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace LanHouseFacil_Util
{
    public class clsManagerTask
    {

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int ShowWindow(int hWnd, int nCmdShow);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowsText);


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr GetConsoleWindows();


        private const int SW_HIDE = 0;
       // private const int SW_SHOW = 1;

        public void Hide()
        {

            int _taskbarHandle = FindWindow("Button", "Start");

            ShowWindow(_taskbarHandle, SW_HIDE);
        }


        public  void Lock()
        {

            
//Desabilitar e habilitar o gerenciador de tarefas
                  
            //if (btnManageForm.Content == "Desactivar")//Quando nCmdShow=0--- Escondido nCmdShow=1--- display;
            //{
                //Desativar o gerenciador de tarefas
                Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", 1);
               
            //O usuário desativar o gerenciador de tarefas
                Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", 1);
              //  btnManageForm.Content = "Activar";
            //}
            //else
            //{
            //    //Desativar o gerenciador de tarefas
            //    Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", 0);
            //    //O usuário desativar o gerenciador de tarefas
            //    Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "DisableTaskMgr", 0);
            //    btnManageForm.Content = "Desactivar";
            //}
        }
    }
}
