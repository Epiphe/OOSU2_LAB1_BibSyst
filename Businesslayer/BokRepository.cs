using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer
{
    public class BokRepository
    {

        private List<Bok> Bocker = new List<Bok>()
        {
            new Bok("B000001", "978-91-44-05562-6", "Förvaltning och medborgarskap i förändring"),
            new Bok("B000002", "978-91-44-12537-4","Rättsinformatik"),
            new Bok("B000003", "978-1-292-15346-9","Visual C# How to program")
        };

        public List<Bok> GetBokList()
        {
            return Bocker;
        }

        public void AddBook(string bokId, string isbn, string titel)
        {
            Bocker.Add(new Bok(bokId,isbn,titel));
        }
    }
}
