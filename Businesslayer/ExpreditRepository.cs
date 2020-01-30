using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    class ExpreditRepository
    {
        private List<Expedit> Expediter = new List<Expedit>()
        {
            new Expedit("E000001","Bruce","Willis","qwerty")
        };

        public List<Expedit> GetExpedit()
        {
            return Expediter;
        }

        public void AddExpedit(string anstNr, string fNamn, string eNamn, string losenord)
        {
            Expediter.Add(new Expedit(anstNr, fNamn, eNamn, losenord));
        }
    }
}
