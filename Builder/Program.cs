using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            TvornicaMobitela tvornica;
            Dućan dućan = new Dućan();

            tvornica = new LG();
            dućan.Naruči(tvornica);
            tvornica.Mobitel.Show();

            tvornica = new Samsung();
            dućan.Naruči(tvornica);
            tvornica.Mobitel.Show();

            tvornica = new Sony();
            dućan.Naruči(tvornica);
            tvornica.Mobitel.Show();

            Console.ReadKey();
        }
    }
}
