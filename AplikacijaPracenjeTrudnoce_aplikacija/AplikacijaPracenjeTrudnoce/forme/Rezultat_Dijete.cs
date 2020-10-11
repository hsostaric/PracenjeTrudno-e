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
    public partial class Rezultat_Dijete : Form
    {
        private Pregled odabraniPregled;
        private RezultatiDijete rezultatiDijete = null;

        public Rezultat_Dijete()
        {
            InitializeComponent();
        }

        public Rezultat_Dijete(Pregled odabraniPregled)
        {
            InitializeComponent();
            this.odabraniPregled = odabraniPregled;
        }

        private void Rezultat_Dijete_Load(object sender, EventArgs e)
        {
            RezultatiDijeteDAO dijeteDAO = new RezultatiDijeteDAO();

            rezultatiDijete = dijeteDAO.dohvatiRezultateDijeteta(odabraniPregled.ID);
            if (rezultatiDijete != null)
            {
                uiSpremi_btn.Text = "Ažuriraj";
                uiOpsegGlavice.Value = (decimal)rezultatiDijete.OpsegGlavice / 100;
                uiOpsegTijela.Value = (decimal)rezultatiDijete.OpsegTijela / 100;
                uiOtkucajiSrca.Value = rezultatiDijete.OtkucajiSrca;
                uiUdaljenostFundusa.Value = (decimal)rezultatiDijete.UdaljenostFundusa / 100;
                uiVelicinaFetusa.Value = (decimal)rezultatiDijete.Velicina / 100;
            }
        }

        private void uiZatvori_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSpremi_btn_Click(object sender, EventArgs e)
        {
            if (rezultatiDijete == null)
            {
                dodajRezultateDijeteta();
            }
            else
            {
                azurirajRezultate();
            }

        }
        private void azurirajRezultate()
        {
            rezultatiDijete = new RezultatiDijete();
            rezultatiDijete.Velicina = Double.Parse(uiVelicinaFetusa.Value.ToString(), CultureInfo.InvariantCulture);
            rezultatiDijete.UdaljenostFundusa = Double.Parse(uiUdaljenostFundusa.Value.ToString(), CultureInfo.InvariantCulture);
            rezultatiDijete.Pregled_id = odabraniPregled.ID;
            rezultatiDijete.OpsegGlavice = Double.Parse(uiOpsegGlavice.Value.ToString(), CultureInfo.InvariantCulture);
            rezultatiDijete.OpsegTijela = Double.Parse(uiOpsegTijela.Value.ToString(), CultureInfo.InvariantCulture);
            rezultatiDijete.OtkucajiSrca = int.Parse(uiOtkucajiSrca.Value.ToString(), CultureInfo.InvariantCulture);
            RezultatiDijeteDAO rezultatiDijeteDAO = new RezultatiDijeteDAO(rezultatiDijete);
            bool azuriraj = rezultatiDijeteDAO.azurirajRezultateDjeteta();
            if (azuriraj == true)
            {
                MessageBox.Show("Rezultati djeteta su ažurirani !", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom ažuriranja rezultata !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dodajRezultateDijeteta()
        {
            rezultatiDijete = new RezultatiDijete();
            rezultatiDijete.Velicina = Double.Parse(uiVelicinaFetusa.Value.ToString(), CultureInfo.InvariantCulture);
            rezultatiDijete.UdaljenostFundusa = Double.Parse(uiUdaljenostFundusa.Value.ToString(), CultureInfo.InvariantCulture);
            rezultatiDijete.Pregled_id = odabraniPregled.ID;
            rezultatiDijete.OpsegGlavice = Double.Parse(uiOpsegGlavice.Value.ToString(), CultureInfo.InvariantCulture);
            rezultatiDijete.OpsegTijela = Double.Parse(uiOpsegTijela.Value.ToString(), CultureInfo.InvariantCulture);
            rezultatiDijete.OtkucajiSrca = int.Parse(uiOtkucajiSrca.Value.ToString(), CultureInfo.InvariantCulture);
            RezultatiDijeteDAO rezultatiDijeteDAO = new RezultatiDijeteDAO(rezultatiDijete);
            bool dodan = rezultatiDijeteDAO.dodajRezultateDjeteta();
            if (dodan == true)
            {
                MessageBox.Show("Rezultati djeteta su dodani !", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Došlo je do greške prilikom dodavanja rezultata !", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
