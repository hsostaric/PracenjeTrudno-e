using AplikacijaPracenjeTrudnoce.baza;
using AplikacijaPracenjeTrudnoce.klase;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.podaci
{
    class RezultatiTrudnicaDAO
    {
        private RezultatiTrudnica rezultatiTrudnica;

        public RezultatiTrudnicaDAO()
        {
        }

        public RezultatiTrudnicaDAO(RezultatiTrudnica rezultatiTrudnica)
        {
            this.rezultatiTrudnica = rezultatiTrudnica;
        }

        public bool dodajRezultatTrudnice()
        {
            string sql = "INSERT INTO rezultati_trudnica (pregled_id, tjelesna_tezina, rh_faktor, krvna_grupa, krvni_tlak) VALUES " +
                "(" + rezultatiTrudnica.Pregled_id + ", " + rezultatiTrudnica.TjelesnaTezina + ", '" + rezultatiTrudnica.RhFaktor + "', " +
                "'" + rezultatiTrudnica.KrvnaGrupa + "', '" + rezultatiTrudnica.KrvniTlak + "')";
            return Baza.Instance.IzvrsiUpit(sql) > 0;
        }
        public RezultatiTrudnica dohvatiRezultateTrudnice(int _pregledID)
        {
            RezultatiTrudnica rezultatiTrudnica = null;
            string sql = "Select *FROM rezultati_trudnica where pregled_id = " + _pregledID;
            NpgsqlDataReader reader = Baza.Instance.DohvatiDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    rezultatiTrudnica = new RezultatiTrudnica();
                    rezultatiTrudnica.Pregled_id = _pregledID;
                    rezultatiTrudnica.TjelesnaTezina = reader.GetDouble(1);
                    rezultatiTrudnica.RhFaktor = reader.GetString(2);
                    rezultatiTrudnica.KrvnaGrupa = reader.GetString(3);
                    rezultatiTrudnica.KrvniTlak = reader.GetString(4);
                }

            }
            reader.Close();
            return rezultatiTrudnica;
        }

        public bool azurirajRezultateTrudnice()
        {
            string sql = "UPDATE rezultati_trudnica SET tjelesna_tezina = " + rezultatiTrudnica.TjelesnaTezina + ", rh_faktor='" + rezultatiTrudnica.RhFaktor + "', " +
                "krvna_grupa = '" + rezultatiTrudnica.KrvnaGrupa + "', krvni_tlak = '" + rezultatiTrudnica.KrvniTlak + "' WHERE pregled_id = '" + rezultatiTrudnica.Pregled_id + "'";
            return Baza.Instance.IzvrsiUpit(sql) > 0;
        }
    }
}
