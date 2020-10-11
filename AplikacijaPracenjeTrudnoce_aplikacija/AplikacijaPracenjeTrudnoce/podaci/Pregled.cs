using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.klase
{
    public class Pregled
    {
        public int ID { get; set; }
        public DateTime Datum_pregleda { get; set; }
        public string Opis { get; set; }
        public int Vrsta_id { get; set; }
        public int Lijecnik_id { get; set; }
        public int Trudnica_id { get; set; }

        public Pregled()
        {

        }

        public Pregled(DateTime datum_pregleda, string opis, int vrsta_id, int lijecnik_id, int trudnica_id)
        {
            Datum_pregleda = datum_pregleda;
            Opis = opis;
            Vrsta_id = vrsta_id;
            Lijecnik_id = lijecnik_id;
            Trudnica_id = trudnica_id;
        }
        public override string ToString()
        {
            return this.Datum_pregleda.ToString("dd.MM.yyyy");
        }
    }
}
