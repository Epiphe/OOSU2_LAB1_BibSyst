using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    class FakturaRepository
    {
        private List<Faktura> Fakturor = new List<Faktura>();

        public List<Faktura> GetFakturor()
        {
            return Fakturor;
        }

        public void AddFaktura(Bokning bokning, int totpris, DateTime startTid, DateTime slutTid)
        {
            Fakturor.Add(new Faktura(bokning, totpris, startTid, slutTid));
        }
    }
}
