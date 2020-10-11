using AplikacijaPracenjeTrudnoce.baza;
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
    public partial class NoviPregled : Form
    {
        private BindingList<VrstaPregleda> vrstePregleda = null;
        private BindingList<Lijecnik> lijecnici = null;
        private Lijecnik odabraniLijecnik = null;
        private VrstaPregleda vrstaPregleda = null;
        private Pregled noviPregled = null;

        public NoviPregled()
        {
            InitializeComponent();
        }

        private void NoviPregled_Load(object sender, EventArgs e)
        {
            PrikaziPreglede();
            PrikaziLijecnike();

        }

        private void PrikaziLijecnike()
        {
            LijecnikDAO lijecnikDAO = new LijecnikDAO();
            lijecnici = lijecnikDAO.dajSveLijecnike();
            lbLijecnici.DataSource = lijecnici;
            foreach (var item in lijecnici)
            {
                lbLijecnici.DisplayMember = item.ToString();
            }
        }

        private void PrikaziPreglede()
        {
            VrstaPregledaDAO vrstaPregledaDAO = new VrstaPregledaDAO();
            vrstePregleda = vrstaPregledaDAO.VratiVrstePregleda();
            cbVrstaPregleda.DataSource = vrstePregleda;
            foreach (VrstaPregleda vrstaPregleda in vrstePregleda)
            {
                cbVrstaPregleda.DisplayMember = vrstaPregleda.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            bool dodan = true;
            odabraniLijecnik = lbLijecnici.SelectedItem as Lijecnik;
            vrstaPregleda = cbVrstaPregleda.SelectedItem as VrstaPregleda;
            if (odabraniLijecnik != null && vrstaPregleda != null)
            {
                try
                {
                    noviPregled = new Pregled();
                    noviPregled.Opis = txtOpis.Text;
                    noviPregled.Lijecnik_id = odabraniLijecnik.ID;
                    noviPregled.Trudnica_id = Trudnica.prijavljeniKorisnik.ID;
                    noviPregled.Vrsta_id = vrstaPregleda.ID;
                    noviPregled.Datum_pregleda = dtOdabirDatumaPregleda.Value;
                    PregledDAO pregledDAO = new PregledDAO();
                    dodan = pregledDAO.RezervirajPregled(noviPregled);
                    this.Close();
                }
                catch (Exception ex)
                {
                    dodan = false;
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dodan == true)
                {
                    MessageBox.Show("Uspješno ste rezervirali pregled", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Niste odabrali sve argumente!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
