using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    class Expedit
    {
        private string Anstallninghsnummer { get; set; }
        public string ForNamn { get; set; }
        public string EfterNamn { get; set; }
        private string Losenord { get; set; }
        private string Roll { get; set; }
        public List<Bokning> Bokningar { get; set; }

        public Expedit(string anstNr, string fNamn, string eNamn, string losenord)
        {
            this.Anstallninghsnummer = anstNr;
            this.ForNamn = fNamn;
            this.EfterNamn = eNamn;
            this.Losenord = losenord;
            this.Roll = "expedit";
        }

    }
}
