using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Sony : TvornicaMobitela
    {
        public Sony()
        {
            mobitel = new Mobitel("Sony Xperia X");
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
            string os = "OS\tAndroid 6.0.1";
            string chipset = "\t  Chipset\tQualcomm MSM8956 Snapdragon 650";
            string cpu = "\t  CPU\tHexa-core (4x1.4 GHz Cortex-A53 & 2x1.8 GHz Cortex-A72)";
            string gpu = "\t  GPU\tAdreno 510";
            mobitel["matična"] = os + "\n" + chipset + "\n" + cpu + "\n" + gpu;
        }
    }
}
