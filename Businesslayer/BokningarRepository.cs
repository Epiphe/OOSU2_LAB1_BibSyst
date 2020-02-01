using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class BokningarRepository
    {
        private List<Bokning> Bokningar = new List<Bokning>()
        {
            new Bokning("B0",DateTime.Now,null,null,null)
        };

        public List<Bokning> GetBokningar ()
        {
            //Här måste det läggas till kod för att vara välja bokningar som finns tillgängliga. 
            return Bokningar;
        }

        public void AddBokning(string bokningsNummer, DateTime startDatum, List<Bok> bocker, Expedit expedit, Medlem medlem)
        {
            Bokningar.Add(new Bokning(bokningsNummer, startDatum, bocker, expedit, medlem));
        }

    }
}
