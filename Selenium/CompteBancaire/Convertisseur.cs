using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clsMBA
{
    public class Convertisseur
    {
        public WSBanqMCII.WSbanqOP WS { get; set; }

        public Convertisseur()
        {
            this.WS = new WSBanqMCII.WSbanqOPClient();
        }
        public virtual Single getTaux (enumMonnaie pMonnaieIn, enumMonnaie pMonnaieOUT)
        {
            String res = this.WS.getTaux(pMonnaieIn.ToString(), pMonnaieOUT.ToString());
            return Convert.ToSingle(res);
        }
    }
    /*
    public class ConvertisseurStub:Convertisseur
    {
        public override Single getTaux(enumMonnaie pMonnaieIn, enumMonnaie pMonnaieOUT)
        {
            if (pMonnaieIn == pMonnaieOUT)
            {
                return 1;
            }
            else
            {
                return 0.5F;
            }
        }
    }
    */
}
