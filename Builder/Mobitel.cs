using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Mobitel
    {
        private string ime;
        private Dictionary<string, string> dijelovi;
        public Mobitel(string ime) {
            this.ime = ime;
            this.dijelovi = new Dictionary<string, string>();
        }
        public string this[string dio]
        {
            get { return dijelovi[dio]; }
            set { dijelovi[dio] = value; }
        }
        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Mobitel: {0}", ime);
            Console.WriteLine("Maska : {0}", dijelovi["maska"]);
            Console.WriteLine("Monitor : {0}", dijelovi["monitor"]);
            Console.WriteLine("Touch: {0}", dijelovi["touch"]);
            Console.WriteLine("Matična : {0}", dijelovi["matična"]);
        }

    }
}
