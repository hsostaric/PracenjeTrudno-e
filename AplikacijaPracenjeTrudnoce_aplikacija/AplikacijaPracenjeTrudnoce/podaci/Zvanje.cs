using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.klase
{
    public class Zvanje
    {

        public int ID { get; set ; }
        public string Naziv { get; set ; }
        public string Opis { get ; set; }

        public Zvanje(string naziv, string opis)
        {
            Naziv = naziv;
            Opis = opis;
        }

    }
}
