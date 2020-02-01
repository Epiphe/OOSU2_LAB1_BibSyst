using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class Businessmanager
    {
        BokningarRepository BokningR = new BokningarRepository();
        BokRepository BokR = new BokRepository();
        public List<Bok> GetBokList()
        {
            return BokR.GetBokList();
        }

        ExpreditRepository Exp = new ExpreditRepository();
        FakturaRepository Fak = new FakturaRepository();
        MedlemRepository Med = new MedlemRepository();
    }
}
