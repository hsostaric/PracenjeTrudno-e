using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.klase
{
    public class RezultatiDijete
    {
        public int Pregled_id { get ; set; }
        public int OtkucajiSrca { get ; set ; }
        public double Velicina { get ; set ; }
        public double UdaljenostFundusa { get ; set ; }
        public double OpsegGlavice { get ; set; }
        public double OpsegTijela { get ; set ; }

        public RezultatiDijete()
        {

        }

        public RezultatiDijete(int pregled_id, int otkucajiSrca, double velicina, double udaljenostFundusa, double opsegGlavice, double opsegTijela)
        {
            Pregled_id = pregled_id;
            OtkucajiSrca = otkucajiSrca;
            Velicina = velicina;
            UdaljenostFundusa = udaljenostFundusa;
            OpsegGlavice = opsegGlavice;
            OpsegTijela = opsegTijela;
        }
    }


}
