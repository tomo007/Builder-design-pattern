using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class LG : TvornicaMobitela
    {
        public LG() {
            mobitel=new Mobitel("LG K7");
        }

        public override void NapraviMasku()
        {
            mobitel["maska"] = "crna";
        }

        public override void NapraviMonitor()
        {
            mobitel["monitor"] = "5.0 inches";
        }

        public override void NapraviTouch()
        {
            mobitel["touch"] = "IPS LCD capacitive touchscreen";
        }

        public override void NapraviMatičnu()
        {
            string os = "OS\tAndroid 5.1";
            string chipset = "\t  Chipset\tQualcomm MSM8909 Snapdragon 210";
            string cpu = "\t  CPU\tQuad-core 1.3 GHz Cortex-A7";
            string gpu = "\t  GPU\tMali-400MP2";
            mobitel["matična"] = os+"\n"+chipset+"\n"+cpu+"\n"+gpu;
        }
    }
}
