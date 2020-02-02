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
                         where startDatum > bokn.StartDatum && startDatum < bokn.SlutDatum 
                         select bokn.Bocker;
            //Skapar en temp boklista att lägga uppbokade böcker i.
            List<Bok> uppbokadeBocker = new List<Bok>();
            //Plockar ur de böcker som är uppbokade
            foreach (List<Bok> B in result)
            {
                if (B is null)
                {
                    break;
                }
                foreach (Bok bok in B)
                {
                    uppbokadeBocker.Add(bok);
                }
            }
            List<Bok> tillGangligaBocker = new List<Bok>(); 
            //Lägger alla böcker i listan tillgängliga böcker.
            tillGangligaBocker = BokR.GetBokList();
            //Plockar bort alla böcker som är uppbokade från listan tillgängliga böcker. 
            foreach (Bok B in uppbokadeBocker)
            {
                tillGangligaBocker.Remove(B);
            }
            //Skickar tillbaka listan med tillgängliga böcker.
            return tillGangligaBocker;
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
