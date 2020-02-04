using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class Bok
    {
        public string BokID { get; set; }
        public string Isbn { get; set; }
        public string Titel { get; set; }
        public bool Utlanad { get; set; }
        public List<Bokning> Bokningar = new List<Bokning>();

        public Bok(string bokId, string isbn, string titel)
        {
            this.BokID = bokId;
            this.Isbn = isbn;
            this.Titel = titel;
            this.Utlanad = false;
        }

    }
}
