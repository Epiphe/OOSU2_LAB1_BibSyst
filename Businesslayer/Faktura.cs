using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    class Faktura
    {
        public Bokning Bokning { get; set; }
        public int TotalPris { get; set; }
        public DateTime StartTid { get; set; }
        public DateTime SlutTid { get; set; }

        public Faktura(Bokning bokning, int totpris, DateTime startTid, DateTime slutTid)
        {
            this.Bokning = bokning;
            this.TotalPris = totpris;
            this.StartTid = startTid;
            this.StartTid = slutTid;
        }

    }
}
