using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.baza
{
    public sealed class Baza
    {
        private NpgsqlConnection connection;
        private static Baza instance = null;
        private string connectionString;

        public static Baza Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Baza();
                }
                return instance;
            }
        }
        private Baza()
        {
            connectionString = "Server = localhost; Port = 5432; Database = postgres; User Id = postgres; Password = root";
            connection = new NpgsqlConnection(connectionString);
            connection.Open();

        }
        public NpgsqlDataReader DohvatiDataReader(string sql)
        {
            return new NpgsqlCommand(sql, connection)
                .ExecuteReader();
        }
        public object DohvatiVrijednost(string sql)
        {
            return new NpgsqlCommand(sql, connection)
                .ExecuteScalar();
        }
        public int IzvrsiUpit(string sql)
        {
            return new NpgsqlCommand(sql, connection)
                .ExecuteNonQuery();
        }
    }
}
