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
    public class VrstaPregledaDAO
    {
        public BindingList<VrstaPregleda> VratiVrstePregleda()
        {
            BindingList<VrstaPregleda> lista = new BindingList<VrstaPregleda>();
            string sql = "SELECT *FROM vrsta_pregleda";
            NpgsqlDataReader adapter = Baza.Instance.DohvatiDataReader(sql);
            if (adapter.HasRows)
            {
                while (adapter.Read())
                {
                    VrstaPregleda vrstaPregleda = new VrstaPregleda();
                    vrstaPregleda.ID = adapter.GetInt32(0);
                    vrstaPregleda.Naziv = adapter.GetString(1);
                    vrstaPregleda.Trajanje = adapter.GetInt32(2);
                    lista.Add(vrstaPregleda);
                }
            }
            adapter.Close();
            return lista;
        }
    }
}
