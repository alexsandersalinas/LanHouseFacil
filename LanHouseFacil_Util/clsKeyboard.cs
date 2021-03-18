using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Runtime.InteropServices;


namespace LanHouseFacil_Util
{
    public class clsKeyboard
    {

        //[DllImport("user32",EntryPoint="SetWindowsHookExA", CharSet= CharSet.Ansi,SetLastError =true, ExactSpelling = true)]

        //public static extern int SetWindowsHookEx(int idHook,LowLevelKeyboardProcDelegate lpfn, int hMod, int dwThreadId);


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int ShowWindow(int hWnd, int nCmdShow);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowsText);
    
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern void BlockInput([In, MarshalAs(UnmanagedType.Bool)]bool fBlockIt);

     

        //[System.Runtime.InteropServices.DllImport("user32.dll")]
        //static extern IntPtr GetConsoleWindows();


        private const int SW_HIDE = 0;
        // private const int SW_SHOW = 1;

        public void HideBtnStart()
        {

            int _taskbarHandle = FindWindow("Button", "Start");

            ShowWindow(_taskbarHandle, SW_HIDE);
        }
      


        public void KillCtrlAltDelete()
        {
            
            RegistryKey regkey;
            string KeyValueInt = "1";
            string subKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\System";

            try
            {
                regkey = Registry.CurrentUser.CreateSubKey(subKey);
                regkey.SetValue("DisableTaskMgr",KeyValueInt);
                regkey.Close();
 
            }
            catch(Exception ex)
            {
                throw ex;
            }
     
        }


        public void LockKeyboard()
        {
            BlockInput(true); 

        }
    }
}
