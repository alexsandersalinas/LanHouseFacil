using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LanHouseFacil_Util
{
    public class clsFile
    {

        public string ImageServer(string p, int s)
        {
            string sPath = p += "\\Images\\Server\\";
            string sReturn = "";
            
            DirectoryInfo d = new DirectoryInfo(@sPath);
            FileInfo[] files = d.GetFiles("*.jpg");

            for (int i = 0; (i <= files.Count() -1);i++ )
            {
                if (i == s)
                {
                    sReturn =  sPath+  files[i].Name;
                    break;
                }
            }

            return sReturn;
        }


        public int ReturnCoutWallpaperClient(string p)
        {

            string sPath =  p += "\\Images\\Client\\";
           

            DirectoryInfo d = new DirectoryInfo(@sPath);
            FileInfo[] files = d.GetFiles("*.jpg");
            return files.Length;

        }

        public string IamgeClient(string p, int s)
        {
            string sPath = p += "\\Images\\Client\\";
            string sReturn = "";

            DirectoryInfo d = new DirectoryInfo(@sPath);
            FileInfo[] files = d.GetFiles("*.jpg");

            for (int i = 0; (i <= files.Count() - 1); i++)
            {
                if (i == s)
                {
                    sReturn = sPath + files[i].Name;
                    break;
                }
            }
            
            
            return  sReturn;
        }
    }
}
