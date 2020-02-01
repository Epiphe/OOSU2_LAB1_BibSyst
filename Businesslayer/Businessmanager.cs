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
        public List<Bokning> GetBokningar()
        {
            return BokningR.GetBokningar();
        }
        public void AddBokning(string bokningsNummer, DateTime startDatum, List<Bok> bocker, Expedit expedit, Medlem medlem)
        {          
            BokningR.AddBokning(bokningsNummer, startDatum, bocker, expedit, medlem);
        }

        BokRepository BokR = new BokRepository();
        public List<Bok> GetBokList()
        {
            return BokR.GetBokList();
        }

        ExpreditRepository Exp = new ExpreditRepository();
        public List<Expedit> GetExpediter()
        {
            return Exp.GetExpedit();
        }
        FakturaRepository Fak = new FakturaRepository();
        MedlemRepository Med = new MedlemRepository();
        public List<Medlem> GetMedlemmar()
        {
            return Med.GetMedlemmar();
        }
    }
}
