using AplikacijaPracenjeTrudnoce.baza;
using AplikacijaPracenjeTrudnoce.klase;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace AplikacijaPracenjeTrudnoce.podaci
{
    public class DetaljiPregledaDAO
    {
        public DetaljiPregledaDAO()
        {

        }

        public DetaljiPregleda dajDetaljePregledaKorisnika(Pregled pregled)
        {
            DetaljiPregleda detalji = null;
            string sql = "SELECT vp.naziv,vp.trajanje, lij.ime, lij.prezime, zv.naziv, kal.pocetak, kal.zavrsetak FROM pregled pr INNER JOIN vrsta_pregleda vp ON pr.vrsta_id = vp.\"ID\" INNER JOIN kalendar kal ON pr.\"ID\"= kal.pregled_id " +
                "INNER JOIN lijecnik lij ON pr.lijecnik_id = lij.\"ID\" INNER JOIN zvanje zv ON lij.zvanje_id = zv.\"ID\" WHERE pr.\"ID\" = '" + pregled.ID + "'";
            NpgsqlDataReader reader = Baza.Instance.DohvatiDataReader(sql);
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    detalji = new DetaljiPregleda();
                    detalji.VrstaPregleda = reader.GetString(0);
                    detalji.Trajanje = reader.GetInt32(1);
                    detalji.NazivLiječnika = reader.GetString(2) + " " + reader.GetString(3) + ", " + reader.GetString(4);
                    detalji.PocetakPregleda = reader.GetDateTime(5);
                    detalji.ZavrsetakPregleda = reader.GetDateTime(6);
                }

            }
            reader.Close();
            return detalji;
        }
    }
}
