using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Dućan
    {
        public void Naruči(TvornicaMobitela tvornicaMobitela)
        {
            tvornicaMobitela.NapraviMasku();
            tvornicaMobitela.NapraviMatičnu();
            tvornicaMobitela.NapraviMonitor();
            tvornicaMobitela.NapraviTouch();
        }
    }
}
