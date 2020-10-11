using AplikacijaPracenjeTrudnoce.baza;
using AplikacijaPracenjeTrudnoce.klase;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace AplikacijaPracenjeTrudnoce.podaci
{
    class TrudnicaDAO
    {
        private NpgsqlDataReader npgsqlData = null;
        public TrudnicaDAO()
        {
        }

        public Trudnica PrijavaKorisnika(string username, string password)
        {
            Trudnica trudnica = null;
            string sql = String.Format("Select *from trudnica WHERE username='{0}' AND password ='{1}'", username, password);
            npgsqlData = Baza.Instance.DohvatiDataReader(sql);
            if (npgsqlData.HasRows)
            {
                while (npgsqlData.Read())
                {
                    trudnica = new Trudnica(npgsqlData.GetInt16(0), username, password, npgsqlData.GetString(3),
                        npgsqlData.GetString(4), npgsqlData.GetString(5), npgsqlData.GetDateTime(6), npgsqlData.GetString(7));
                }
            }
            npgsqlData.Close();
            return trudnica;

        }


    }
}
