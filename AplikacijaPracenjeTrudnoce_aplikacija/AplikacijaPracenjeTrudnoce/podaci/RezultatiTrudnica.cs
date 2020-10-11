using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.klase
{
   public class RezultatiTrudnica
    {
      
        public int Pregled_id { get ; set ; }
        public double TjelesnaTezina { get ; set; }
        public string RhFaktor { get ; set ; }
        public string KrvnaGrupa { get ; set ; }
        public string KrvniTlak { get; set ; }

        public RezultatiTrudnica(int pregled_id, double tjelesnaTezina, string rhFaktor, string krvnaGrupa, string krvniTlak)
        {
            Pregled_id = pregled_id;
            TjelesnaTezina = tjelesnaTezina;
            RhFaktor = rhFaktor;
            KrvnaGrupa = krvnaGrupa;
            KrvniTlak = krvniTlak;
        }

        public RezultatiTrudnica()
        {

        }


    }
}
