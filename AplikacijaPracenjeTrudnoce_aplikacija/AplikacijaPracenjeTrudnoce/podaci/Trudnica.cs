using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacijaPracenjeTrudnoce.klase
{
    public class Trudnica
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public string Kontakt { get; set; }
        public static Trudnica prijavljeniKorisnik = null;
        public Trudnica()
        {

        }
        public Trudnica(int id, string username, string password, string ime, string prezime, string email, DateTime datumRodjenja, string kontakt)
        {
            ID = id;
            Username = username;
            Password = password;
            Ime = ime;
            Prezime = prezime;
            Email = email;
            DatumRodjenja = datumRodjenja;
            Kontakt = kontakt;
        }
        public override string ToString()
        {
            return this.Ime + " " + this.Prezime;
        }
    }
}
