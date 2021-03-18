using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace  LanHouseFacil_Util
{
    
   public  class clsTaskbar
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int FindWindow(string className, string windowsText);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int ShowWindow(int hwnd, int command);

        private const int SW_HIDE = 0;
        private const int SW_SHOW = 1;
        //private const int SW_SHOW_RUN = 5;

        //public void New()
        //{
            
        //}
        public void Show()
        {
            int _taskbarHandle = FindWindow("Shell_TrayWnd", "");
            ShowWindow(_taskbarHandle, SW_SHOW);
        }

        public void Hide()
        {
            int _taskbarHandle = FindWindow("Shell_TrayWnd", "");
            ShowWindow(_taskbarHandle, SW_HIDE);
        }


      

    }
}


