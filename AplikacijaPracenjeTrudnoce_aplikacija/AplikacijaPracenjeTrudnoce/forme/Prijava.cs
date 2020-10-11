using AplikacijaPracenjeTrudnoce.forme;
using AplikacijaPracenjeTrudnoce.klase;
using AplikacijaPracenjeTrudnoce.podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacijaPracenjeTrudnoce
{
    public partial class Prijava : Form
    {
        private TrudnicaDAO trudnicaDAO;
        public Prijava()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrijaviMe_Click(object sender, EventArgs e)
        {
            trudnicaDAO = new TrudnicaDAO();
            Trudnica.prijavljeniKorisnik = trudnicaDAO.PrijavaKorisnika(txtUsername.Text, txtLozinka.Text);
            if (Trudnica.prijavljeniKorisnik == null)
            {
                lbNeuspjesnaPrijava.Text = "Unijeli ste pogrešne podatke !";

            }
            else
            {

                GlavniIzbornik glavniIzbornik = new GlavniIzbornik();
                this.Hide();
                ocistiPodatke();
                glavniIzbornik.ShowDialog();
                this.Show();

            }

        }

        private void ocistiPodatke()
        {
            lbNeuspjesnaPrijava.Text = "";
            txtUsername.Clear();
            txtLozinka.Clear();
        }

    }
}
