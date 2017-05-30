using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Samsung : TvornicaMobitela
    {
        public Samsung()
        {
            mobitel = new Mobitel("Samsung Galaxy S7");
        }

        public override void NapraviMasku()
        {
            mobitel["maska"] = "bijela";
        }

        public override void NapraviMonitor()
        {
            mobitel["monitor"] = "5.1 inches";
        }

        public override void NapraviTouch()
        {
            mobitel["touch"] = "Super AMOLED capacitive touchscreen";
        }

        public override void NapraviMatičnu()
        {
            string os = "OS\tAndroid 6.0.1";
            string chipset = "\t  Chipset\tQualcomm MSM8996 Snapdragon 820";
            string cpu = "\t  CPU\tQuad-core (2x2.15 GHz Kryo & 2x1.6 GHz Kryo)";
            string gpu = "\t  GPU\tAdreno 530";
            mobitel["matična"] = os + "\n" + chipset + "\n" + cpu + "\n" + gpu;
        }
    }
}
