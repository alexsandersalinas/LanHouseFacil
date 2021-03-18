using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LanHouseFacil_ENT
{
    public  class estacaoENT
    {

        public int EstacaoID { get; set; }
        public bool StatusON { get; set; }
        public bool setON { get; set; }
        public bool EstacaoRUN {get;set;}
        public string IPServer { get; set; }
        public bool Shutdown { get; set; }
        public bool Reboot { get; set; }
        public DateTime DtRUN { get; set; }
        public DateTime? DTStart { get; set; }
        public TimeSpan TSEnd { get; set; }
        public TimeSpan TSInsert { get; set; }


    }
}
