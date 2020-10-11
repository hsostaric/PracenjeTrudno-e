using AplikacijaPracenjeTrudnoce.baza;
using AplikacijaPracenjeTrudnoce.klase;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.podaci
{
    class RezultatiDijeteDAO
    {
        private RezultatiDijete rezultatiDijete;

        public RezultatiDijeteDAO()
        {
        }

        public RezultatiDijeteDAO(RezultatiDijete rezultatiDijete)
        {
            this.rezultatiDijete = rezultatiDijete;
        }

        public bool dodajRezultateDjeteta()
        {
            string sql = "INSERT INTO rezultati_dijete (pregled_id, otkucaji_srca, velicina, udaljenost_fundusa, opseg_glavice, opseg_tijela) VALUES " +
                "(" + rezultatiDijete.Pregled_id + ", " + rezultatiDijete.OtkucajiSrca + ", " + rezultatiDijete.Velicina + ", " + rezultatiDijete.UdaljenostFundusa + ", " +
                "" + rezultatiDijete.OpsegGlavice + ", " + rezultatiDijete.OpsegTijela + ")";
            return Baza.Instance.IzvrsiUpit(sql) > 0;
        }
        public RezultatiDijete dohvatiRezultateDijeteta(int _pregledID)
        {
            RezultatiDijete rezultatiDijete = null;
            string sql = "SELECT *FROM rezultati_dijete WHERE pregled_id=" + _pregledID;
            NpgsqlDataReader reader = Baza.Instance.DohvatiDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    rezultatiDijete = new RezultatiDijete();
                    rezultatiDijete.Pregled_id = reader.GetInt32(0);
                    rezultatiDijete.OtkucajiSrca = reader.GetInt32(1);
                    rezultatiDijete.Velicina = reader.GetDouble(2);
                    rezultatiDijete.UdaljenostFundusa = reader.GetDouble(3);
                    rezultatiDijete.OpsegGlavice = reader.GetDouble(4);
                    rezultatiDijete.OpsegTijela = reader.GetDouble(5);
                }
            }
            reader.Close();
            return rezultatiDijete;

        }

        public bool azurirajRezultateDjeteta()
        {
            string sql = "UPDATE rezultati_dijete SET otkucaji_srca=" + rezultatiDijete.OtkucajiSrca + ", velicina = " + rezultatiDijete.Velicina + ", " +
                "udaljenost_fundusa=" + rezultatiDijete.UdaljenostFundusa + ", opseg_glavice = " + rezultatiDijete.OpsegGlavice + ", opseg_tijela = " + rezultatiDijete.OpsegTijela + " " +
                "WHERE pregled_id=" + rezultatiDijete.Pregled_id;

            return Baza.Instance.IzvrsiUpit(sql) > 0;
        }
    }
}
