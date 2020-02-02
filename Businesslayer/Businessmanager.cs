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
        //Varför finns denna här? Jo för Bokningarna är ju information expert om vilka böcker som är bokade.
        public List<Bok> GetTillGangligaBocker(DateTime startDatum)
        {
            return BokningR.GetTillGangligaBocker(startDatum);
        }
        public void AddBokning(string bokningsNummer, DateTime startDatum, List<Bok> bocker, Expedit expedit, Medlem medlem)
        {          
            BokningR.AddBokning(bokningsNummer, startDatum, bocker, expedit, medlem);
        }
        public List<Bokning> GetTotalAntalBokningar()
        {
            return BokningR.GetTotalAntalBokningar();
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
