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
    public partial class MojiPregledi : Form
    {
        private Pregled odabraniPregled = null;
        private DetaljiPregledaDAO detaljiPregledaDAO = null;
        private DetaljiPregleda detaljiPregleda = null;
        public MojiPregledi()
        {
            InitializeComponent();
        }
        private BindingList<Pregled> preglediKorisnika = null;
        private void MojiPregledi_Load(object sender, EventArgs e)
        {
            PregledDAO pregledDAO = new PregledDAO();

            preglediKorisnika = pregledDAO.DohvatiPregledeKorisnika(Trudnica.prijavljeniKorisnik);
            if (preglediKorisnika.Count > 0
               && preglediKorisnika != null)
            {

                uiPrikazPregledaListBox.DataSource = preglediKorisnika;
                foreach (var pregled in preglediKorisnika)
                {
                    uiPrikazPregledaListBox.DisplayMember = pregled.ToString();
                }
                uiPrikazPregledaListBox.SelectedIndex = 0;
                prikaziPreglede();
            }

        }

        private void prikaziPreglede()
        {
            prikaziRezultatePregleda();


        }

        private void prikaziRezultatePregleda()
        {
            odabraniPregled = uiPrikazPregledaListBox.SelectedItem as Pregled;
            if (odabraniPregled != null)
            {
                detaljiPregledaDAO = new DetaljiPregledaDAO();
                detaljiPregleda = detaljiPregledaDAO.dajDetaljePregledaKorisnika(odabraniPregled);
                uiVrstaPregleda_TextBox.Text = detaljiPregleda.VrstaPregleda;
                uiLijecnik_TextBox.Text = detaljiPregleda.NazivLiječnika;
                uiTrajanjePregleda_TextBox.Text = detaljiPregleda.Trajanje.ToString();
                uiPocetakPregleda_TextBox.Text = detaljiPregleda.PocetakPregleda.ToString("dd.MM.yyyy HH:mm");
                uizavrsetakPregleda_TextBox.Text = detaljiPregleda.ZavrsetakPregleda.ToString("dd.MM.yyyy HH:mm");
            }
        }

        private void uiPrikazPregledaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prikaziPreglede();
        }

        private void uiNAZAD_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiPodaciTrudnice_Click(object sender, EventArgs e)
        {
            if (odabraniPregled != null)
            {
                Rezultat_Trudnice rezultat_Trudnice = new Rezultat_Trudnice(odabraniPregled);
                rezultat_Trudnice.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niste odabrali pregled !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void uiRezultatiDjeteta_Click(object sender, EventArgs e)
        {
            if (odabraniPregled != null)
            {
                Rezultat_Dijete rezultat_Dijete = new Rezultat_Dijete(odabraniPregled);
                rezultat_Dijete.ShowDialog();
            }
            else
            {
                MessageBox.Show("Niste odabrali pregled !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
