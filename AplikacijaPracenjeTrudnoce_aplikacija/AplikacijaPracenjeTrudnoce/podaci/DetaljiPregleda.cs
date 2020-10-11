using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.podaci
{
    public class DetaljiPregleda
    {
        public string VrstaPregleda { get; set; }
        public string NazivLiječnika { get; set; }
        public DateTime PocetakPregleda { get; set; }
        public DateTime ZavrsetakPregleda { get; set; }
        public int Trajanje { get; set; }

        public DetaljiPregleda()
        {

        }

        public DetaljiPregleda(string vrstaPregleda, string nazivLiječnika, DateTime pocetakPregleda, DateTime zavrsetakPregleda, int trajanje)
        {
            VrstaPregleda = vrstaPregleda;
            NazivLiječnika = nazivLiječnika;
            PocetakPregleda = pocetakPregleda;
            ZavrsetakPregleda = zavrsetakPregleda;
            Trajanje = trajanje;
        }
    }
}
