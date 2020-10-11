using AplikacijaPracenjeTrudnoce.podaci;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.klase
{
    public class Lijecnik
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Kontakt { get; set; }
        public int Zvanje_id { get; set; }
        public string Adresa { get; set; }

        public Lijecnik()
        {
        }

        public override string ToString()
        {

            return this.Ime + " " + this.Prezime + ", " + LijecnikDAO.VratiTitulu(this.Zvanje_id);
        }
    }
}
