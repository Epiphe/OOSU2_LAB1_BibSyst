using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    class BokningarRepository
    {
        private List<Bokning> Bokningar = new List<Bokning>();

        public List<Bokning> GetBokningar ()
        {
            return Bokningar;
        }

        public void AddBokning(string boknr, DateTime startdatum)
        {
            Bokningar.Add(new Bokning(boknr, startdatum));
        }

    }
}
