using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    class Milk
    {
        public int id { get; set; }

        public string NazwaMleka { get; set; }

        public string IloscKartonow { get; set; }

        public string CenaZaKartonBrutto { get; set; }

        public string WspolrzedneMagazynu { get; set; }


        public string FullInfo
        {
            // "Mleko1 2 (35)"
            get
            {
                return $"{ NazwaMleka }\t { IloscKartonow }\t\t { CenaZaKartonBrutto }\t\t {WspolrzedneMagazynu}";
            }
           
        }

    }
}
