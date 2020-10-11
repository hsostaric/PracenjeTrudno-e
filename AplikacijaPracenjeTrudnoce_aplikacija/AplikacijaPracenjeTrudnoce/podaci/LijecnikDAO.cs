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
    public class LijecnikDAO
    {
        public static string VratiTitulu(int id)
        {
            string titula = "";
            string sql = "SELECT naziv FROM zvanje WHERE \"ID\" = " + id;
            NpgsqlDataReader reader = Baza.Instance.DohvatiDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    titula = reader.GetString(0);
                }
            }
            reader.Close();
            return titula;
        }

        public BindingList<Lijecnik> dajSveLijecnike()
        {
            BindingList<Lijecnik> lista = new BindingList<Lijecnik>();
            string sql = "SELECT *FROM lijecnik";
            NpgsqlDataReader reader = Baza.Instance.DohvatiDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Lijecnik lijecnik = new Lijecnik();
                    lijecnik.ID = reader.GetInt32(0);
                    lijecnik.Ime = reader.GetString(1);
                    lijecnik.Prezime = reader.GetString(2);
                    lijecnik.Kontakt = reader.GetString(3);
                    lijecnik.Zvanje_id = reader.GetInt32(4);
                    lijecnik.Adresa = reader.GetString(5);
                    lista.Add(lijecnik);
                }
            }
            reader.Close();
            return lista;
        }
    }
}
