using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.klase
{
    public class Trudnoca
    {


        public int ID { get; set; }
        public int Trudnica_id { get; set; }
        public DateTime Vrijeme_zaceca { get; set; }
        public DateTime Termin_rodjenja { get; set; }
        public Trudnoca()
        {

        }

        public Trudnoca(int trudnica_id, DateTime vrijeme_zaceca, DateTime termin_rodjenja)
        {
            Trudnica_id = trudnica_id;
            Vrijeme_zaceca = vrijeme_zaceca;
            Termin_rodjenja = termin_rodjenja;
        }
    }
}
