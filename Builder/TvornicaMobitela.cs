using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class TvornicaMobitela
    {
        protected Mobitel mobitel;
        
        public Mobitel Mobitel
        { 
            get
            {
                return mobitel;
            }
        }
        public abstract void NapraviMasku();
        public abstract void NapraviMonitor();
        public abstract void NapraviMatičnu();
        public abstract void NapraviTouch();
    }
}
