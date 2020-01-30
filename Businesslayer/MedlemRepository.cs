using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    class MedlemRepository
    {
        private List<Medlem> Medlemmar = new List<Medlem>()
        {
            new Medlem("M000001","Johan","Nyberg",0500445423, "s183413@hb.student.se"),
            new Medlem("M000002","Usain", "Bolt",0500335764,"therealflash@usainbolt.com"),
            new Medlem("M000003","Elon", "Musk", 033561711,"tesla4ever@telia.se")
        };

        public List<Medlem> GetMedlemmar()
        {
            return Medlemmar;
        }
        public void AddMedlem(string medlemsNr, string fNamn, string eNamn, int telNr, string epost)
        {
            Medlemmar.Add(new Medlem(medlemsNr, fNamn, eNamn, telNr, epost));
        }

    }
}
