using AplikacijaPracenjeTrudnoce.klase;
using AplikacijaPracenjeTrudnoce.podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaPracenjeTrudnoce.forme
{
    public partial class Rezultat_Trudnice : Form
    {
        private Pregled odabraniPregled;
        private RezultatiTrudnica rezultatiTrudnica = null;

        public Rezultat_Trudnice()
        {
            InitializeComponent();
        }

        public Rezultat_Trudnice(Pregled odabraniPregled)
        {
            InitializeComponent();
            this.odabraniPregled = odabraniPregled;
        }

        private void uiNazad_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rezultat_Trudnice_Load(object sender, EventArgs e)
        {
            RezultatiTrudnicaDAO rezultatiTrudnicaDAO = new RezultatiTrudnicaDAO();
            rezultatiTrudnica = rezultatiTrudnicaDAO.dohvatiRezultateTrudnice(odabraniPregled.ID);
            uiKrvnaGrupa.Text = "Text";
            uiKrvnaGrupa.ValueMember = "Value";
            uiKrvnaGrupa.Items.Add(new { Text = "A", Value = "A" });
            uiKrvnaGrupa.Items.Add(new { Text = "B", Value = "B" });
            uiKrvnaGrupa.Items.Add(new { Text = "AB", Value = "AB" });
            uiKrvnaGrupa.Items.Add(new { Text = "0", Value = "0" });
            uiRhFaktor.Text = "Text";
            uiRhFaktor.ValueMember = "Value";
            uiRhFaktor.Items.Add(new { Text = "+", Value = "+" });
            uiRhFaktor.Items.Add(new { Text = "-", Value = "-" });
            if (rezultatiTrudnica == null)
            {
                uiKrvnaGrupa.SelectedIndex = 0;
                uiRhFaktor.SelectedIndex = 0;

            }
            else
            {
                uiSpremi_btn.Text = "Ažuriraj";
                uiKrvnaGrupa.SelectedIndex = uiKrvnaGrupa.FindString(rezultatiTrudnica.KrvnaGrupa);
                uiRhFaktor.SelectedIndex = uiRhFaktor.FindString(rezultatiTrudnica.RhFaktor);
                uiTjelesnaTezina.Value = (decimal)rezultatiTrudnica.TjelesnaTezina;
                string[] polje = rezultatiTrudnica.KrvniTlak.Split('/');
                uiPrviDioTlaka.Value = int.Parse(polje[0]);
                uiDrugiDio.Value = int.Parse(polje[1]);

            }


        }

        private void uiSpremi_btn_Click(object sender, EventArgs e)
        {
            if (rezultatiTrudnica == null)
            {
                dodavanjeZapisaUBazu();
            }
            else
            {
                azuriranjeZapisaUBazi();
            }

        }
        private void azuriranjeZapisaUBazi()
        {
            string krvnaGrupa = (uiKrvnaGrupa.SelectedItem as dynamic).Value;
            string rhFaktor = (uiRhFaktor.SelectedItem as dynamic).Value;
            rezultatiTrudnica = new RezultatiTrudnica();
            rezultatiTrudnica.KrvnaGrupa = krvnaGrupa;
            rezultatiTrudnica.RhFaktor = rhFaktor;
            rezultatiTrudnica.Pregled_id = odabraniPregled.ID;
            rezultatiTrudnica.TjelesnaTezina = Double.Parse(uiTjelesnaTezina.Value.ToString());
            rezultatiTrudnica.KrvniTlak = uiPrviDioTlaka.Value.ToString() + "/" + uiDrugiDio.Value.ToString();
            RezultatiTrudnicaDAO rezultatiTrudnicaDAO = new RezultatiTrudnicaDAO(rezultatiTrudnica);
            bool azuriran = rezultatiTrudnicaDAO.azurirajRezultateTrudnice();
            if (azuriran == true)
            {
                MessageBox.Show("Rezultati trudnice su ažurirani !", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom ažuriranja rezultata !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dodavanjeZapisaUBazu()
        {
            string krvnaGrupa = (uiKrvnaGrupa.SelectedItem as dynamic).Value;
            string rhFaktor = (uiRhFaktor.SelectedItem as dynamic).Value;
            rezultatiTrudnica = new RezultatiTrudnica();
            rezultatiTrudnica.KrvnaGrupa = krvnaGrupa;
            rezultatiTrudnica.RhFaktor = rhFaktor;
            rezultatiTrudnica.Pregled_id = odabraniPregled.ID;
            rezultatiTrudnica.TjelesnaTezina = Double.Parse(uiTjelesnaTezina.Value.ToString());
            rezultatiTrudnica.KrvniTlak = uiPrviDioTlaka.Value.ToString() + "/" + uiDrugiDio.Value.ToString();
            RezultatiTrudnicaDAO rezultatiTrudnicaDAO = new RezultatiTrudnicaDAO(rezultatiTrudnica);
            bool dodan = rezultatiTrudnicaDAO.dodajRezultatTrudnice();
            if (dodan == true)
            {
                MessageBox.Show("Rezultati trudnice su dodani !", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom dodavanja rezultata !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
