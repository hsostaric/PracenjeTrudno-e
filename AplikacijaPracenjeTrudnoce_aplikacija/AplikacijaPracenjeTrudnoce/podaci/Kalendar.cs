using Npgsql.TypeHandlers.DateTimeHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.klase
{
    public class Kalendar
    {
        public int ID { get; set; }
        public DateTime Pocetak { get; set; }
        public DateTime Zavrsetak { get; set; }
        public int pregled_id { get; set; }
        public Kalendar()
        {

        }
    }
}
