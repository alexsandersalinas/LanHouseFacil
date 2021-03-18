using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace LanHouseFacil_Util
{
    public class clsShutdown
    {

        public void Shutdown()
        {

            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");

            // Flag 1 means we want to shut down the system. Use "2" to reboot.
            mboShutdownParams["Flags"] = "1";
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }

        }


        public void ShutdownCmd()
        {
          //  System.Diagnostics.Process.Start("shutdown", "-rf");
            var s = new System.Diagnostics.ProcessStartInfo("shutdown", "/s /t 55");
            s.CreateNoWindow = true;
            s.UseShellExecute = false;
            System.Diagnostics.Process.Start(s);

        }

        public void RebootCmd()
        {
            //  System.Diagnostics.Process.Start("shutdown", "-rf");
            var s = new System.Diagnostics.ProcessStartInfo("shutdown", "/r");
            s.CreateNoWindow = true;
            s.UseShellExecute = false;
            System.Diagnostics.Process.Start(s);

        }


        public void UnShutdownCmd()
        {
            //  System.Diagnostics.Process.Start("shutdown", "-rf");
            var s = new System.Diagnostics.ProcessStartInfo("shutdown", "/a");
            s.CreateNoWindow = true;
            s.UseShellExecute = false;
            System.Diagnostics.Process.Start(s);

        }

        public void Restart()
        {

            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");

            // Flag 1 means we want to shut down the system. Use "2" to reboot.
            mboShutdownParams["Flags"] = "1";
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }

        }

    }
}
