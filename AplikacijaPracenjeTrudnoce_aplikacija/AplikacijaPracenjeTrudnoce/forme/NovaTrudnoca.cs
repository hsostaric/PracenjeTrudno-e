using AplikacijaPracenjeTrudnoce.klase;
using AplikacijaPracenjeTrudnoce.podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaPracenjeTrudnoce.forme
{
    public partial class NovaTrudnoca : Form
    {
        private DateTime datumZaceca;
        private DateTime datumRodjenja;
        private Trudnoca novatrudnoca;
        private TrudnocaDAO trudnocaDAO;
        public NovaTrudnoca()
        {
            InitializeComponent();
        }

        private void uiDodajTrudnocu_Click(object sender, EventArgs e)
        {
            DodajTrudnocu();
        }

        private void DodajTrudnocu()
        {
            bool greska = false;
            try
            {
                datumZaceca = DateTime.ParseExact(uiDatumZaceca.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", null);
                datumRodjenja = dodajMjesece(datumZaceca, 9);
                novatrudnoca = new Trudnoca(Trudnica.prijavljeniKorisnik.ID, datumZaceca, datumRodjenja);
                trudnocaDAO = new TrudnocaDAO(novatrudnoca: novatrudnoca);
                trudnocaDAO.dodajTrudnocu();
            }
            catch (Exception ex)
            {
                greska = true;
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (greska == false)
            {
                MessageBox.Show("Uspješno ste dodali novu trudnoću !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        public DateTime dodajMjesece(DateTime date, int numberOfMonths)
        {
            DateTime nextMonth = date.AddMonths(numberOfMonths);

            if (date.Day != DateTime.DaysInMonth(date.Year, date.Month))
            {
                return nextMonth;
            }
            else
            {

                int addDays = DateTime.DaysInMonth(nextMonth.Year, nextMonth.Month) - nextMonth.Day;
                return nextMonth.AddDays(addDays);
            }
        }
    }
}
