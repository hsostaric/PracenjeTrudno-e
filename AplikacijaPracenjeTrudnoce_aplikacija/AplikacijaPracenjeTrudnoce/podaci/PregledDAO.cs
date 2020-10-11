using AplikacijaPracenjeTrudnoce.baza;
using AplikacijaPracenjeTrudnoce.klase;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.podaci
{
    public class PregledDAO
    {
        public bool RezervirajPregled(Pregled pregled)
        {
            string sql = "INSERT INTO pregled(datum_pregleda, opis, vrsta_id, lijecnik_id, trudnica_id) VALUES ('" + pregled.Datum_pregleda.ToString("yyyy-MM-dd") + "'" +
                ", '" + pregled.Opis + "', " + pregled.Vrsta_id + ", " + pregled.Lijecnik_id + ", " + pregled.Trudnica_id + ")";
            return Baza.Instance.IzvrsiUpit(sql) > 0;

        }
        public BindingList<Pregled> DohvatiPregledeKorisnika(Trudnica trudnica)
        {
            Pregled pregledKorisnika = null;
            BindingList<Pregled> lista = new BindingList<Pregled>();
            string sql = "SELECT *FROM pregled where trudnica_id=" + trudnica.ID;
            NpgsqlDataReader reader = Baza.Instance.DohvatiDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pregledKorisnika = new Pregled();
                    pregledKorisnika.ID = reader.GetInt32(0);
                    pregledKorisnika.Datum_pregleda = reader.GetDateTime(1);
                    if (reader.GetString(2) == null)
                    {
                        pregledKorisnika.Opis = "";
                    }
                    else
                    {
                        pregledKorisnika.Opis = reader.GetString(2);
                    }
                    pregledKorisnika.Vrsta_id = reader.GetInt32(3);
                    pregledKorisnika.Lijecnik_id = reader.GetInt32(4);
                    pregledKorisnika.Trudnica_id = reader.GetInt32(5);
                    lista.Add(pregledKorisnika);
                }
                reader.Close();
            }
            return lista;
        }
    }
}
