using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class Bokning
    {
        public string BokningsNummer { get; }
        public DateTime StartDatum { get; set; }
        public DateTime SlutDatum { get; set; }
        public DateTime AterlamningsDatum { get; set; }
        public List<Bok> Bocker { get; set; }
        public Expedit Expedit { get; set; }
        public Medlem Medlem { get; set; }
        public Faktura Faktura { get; set; }

        public Bokning(string bokningsNummer, DateTime startDatum, List<Bok> bocker, Expedit expedit, Medlem medlem)
        {
            this.BokningsNummer = bokningsNummer;
            this.StartDatum = startDatum;
            this.SlutDatum = startDatum.AddDays(28.0);
            this.Bocker = bocker;
            this.Expedit = expedit;
            this.Medlem = medlem;
        }
    }
}
