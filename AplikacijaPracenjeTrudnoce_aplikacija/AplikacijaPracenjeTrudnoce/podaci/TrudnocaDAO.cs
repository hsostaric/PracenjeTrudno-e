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
    class TrudnocaDAO
    {
        private Trudnoca novatrudnoca;

        public TrudnocaDAO(Trudnoca novatrudnoca)
        {
            this.novatrudnoca = novatrudnoca;
        }

        public TrudnocaDAO()
        {
        }

        public bool dodajTrudnocu()
        {
            string sql = "INSERT INTO trudnoca (trudnica_id, vrijeme_zaceca, termin_rodjenja) " +
                "values(" + novatrudnoca.Trudnica_id + ", '" + novatrudnoca.Vrijeme_zaceca.ToString("yyyy-MM-dd") + "', '" + novatrudnoca.Termin_rodjenja.ToString("yyyy-MM-dd") + "')";

            return Baza.Instance.IzvrsiUpit(sql) > 0;
        }
        public BindingList<Trudnoca> DajTrudnoceKorisnika(Trudnica trudnica)
        {
            BindingList<Trudnoca> lista = new BindingList<Trudnoca>();
            string sql = "SELECT *FROM trudnoca WHERE trudnica_id =" + trudnica.ID;
            NpgsqlDataReader adapter = Baza.Instance.DohvatiDataReader(sql);
            if (adapter.HasRows)
            {
                while (adapter.Read())
                {
                    Trudnoca trudnoca = new Trudnoca();
                    trudnoca.ID = adapter.GetInt32(0);
                    trudnoca.Trudnica_id = adapter.GetInt32(1);
                    trudnoca.Vrijeme_zaceca = adapter.GetDateTime(2);
                    trudnoca.Termin_rodjenja = adapter.GetDateTime(3);
                    lista.Add(trudnoca);
                }
                adapter.Close();
            }
            return lista;
        }
        public bool ObrisiTrudnocu(int id)
        {
            string sql = "Delete FROM trudnoca WHERE \"ID\" = " + id;
            return Baza.Instance.IzvrsiUpit(sql) > 0;

        }
    }
}
