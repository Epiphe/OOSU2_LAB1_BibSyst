using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    class Medlem
    {
        public string MedlemsNummer { get; set; }
        public string ForNamn { get; set; }
        public string EfterNamn { get; set; }
        public int TelefonNummer { get; set; }
        public string EPost { get; set; }
        public List<Bokning> Bokningar { get; set; }

        public Medlem(string medlemsNr, string fNamn, string eNamn, int telNr, string epost)
        {
            this.MedlemsNummer = medlemsNr;
            this.ForNamn = fNamn;
            this.EfterNamn = eNamn;
            this.TelefonNummer = telNr;
            this.EPost = eNamn;

        }

    }
}
