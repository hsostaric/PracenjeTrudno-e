using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.klase
{

    public class VrstaPregleda
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public int Trajanje { get; set; }

        public VrstaPregleda()
        {

        }

        public VrstaPregleda(int iD, string naziv, int trajanje)
        {
            ID = iD;
            Naziv = naziv;
            Trajanje = trajanje;
        }

        public override string ToString()
        {
            return this.Naziv + " -  " + this.Trajanje + " min";
        }
    }


}
