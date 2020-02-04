using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class BokningarRepository
    {
        BokRepository BokR = new BokRepository();

        private List<Bokning> Bokningar = new List<Bokning>()
        {
            new Bokning("B0",DateTime.Now,null,null,null)
        };

        public List<Bok> GetTillGangligaBocker (DateTime startDatum)
        {
            //Filtrerar fram de bokningar startar undertiden som denna bokning är planerad.
            var result = from bokn in Bokningar
                         where startDatum > bokn.StartDatum && startDatum < bokn.SlutDatum || startDatum.AddDays(28) < bokn.StartDatum && startDatum.AddDays(28) > bokn.SlutDatum
                         select bokn.Bocker;
            
            //Skapar en temp boklista att lägga uppbokade böcker i.
            List<Bok> uppbokadeBocker = new List<Bok>();
            //Plockar ur de böcker som är uppbokade 
            foreach (List<Bok> B in result)
            {
                if (B is null)
                {
                    continue;
                }
                foreach (Bok bok in B)
                {
                    uppbokadeBocker.Add(bok);
                }
            }
            List<Bok> tillGangligaBocker = new List<Bok>();
            List<Bok> allaBocker = new List<Bok>();    
            //Lägger alla böcker i listan allaBocker.
            allaBocker = BokR.GetBokList();
            //Går igenom listan alla böcker och kollar mot listan med uppbokade böcker. Om boken INTE är uppbokad läggs den i lsiatn med tillgängliga böcker.
            foreach (Bok B in allaBocker)
            {
                foreach (Bok C in uppbokadeBocker)
                {
                    if (B.BokID != C.BokID )
                    {
                        tillGangligaBocker.Add(B);
                    }
                }
            }

            //Om listan med uppbokade böcker är tom läggs det inget i tillgängliga böcker i den och då skickas listan med alla böcker istället.
            if (tillGangligaBocker.Count == 0)
            {
                return allaBocker;
            }
            else
            {
                return tillGangligaBocker;
            }

        }
        public List<Bokning> GetTotalAntalBokningar()
        { 
            return Bokningar;
        }

        public void AddBokning(string bokningsNummer, DateTime startDatum, List<Bok> bocker, Expedit expedit, Medlem medlem)
        {
            Bokningar.Add(new Bokning(bokningsNummer, startDatum, bocker, expedit, medlem));
        }

    }
}
