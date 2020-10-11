using AplikacijaPracenjeTrudnoce.klase;
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
    public partial class GlavniIzbornik : Form
    {
        public GlavniIzbornik()
        {
            InitializeComponent();
        }

        private void GlavniIzbornik_Load(object sender, EventArgs e)
        {
            uiLoginUser.Text += Trudnica.prijavljeniKorisnik.ToString();


        }

        private void uiLogOut_Click(object sender, EventArgs e)
        {
            Trudnica.prijavljeniKorisnik = null;
            this.Close();
        }

        private void uiDodajTrudnocu_Click(object sender, EventArgs e)
        {
            NovaTrudnoca novaTrudnoca = new NovaTrudnoca();
            novaTrudnoca.ShowDialog();
        }

        private void uiMojeTrudnoce_Click(object sender, EventArgs e)
        {
            MojeTrudnoce mojeTrudnoce = new MojeTrudnoce();
            mojeTrudnoce.ShowDialog();
        }

        private void uiZakaziPregled_Click(object sender, EventArgs e)
        {
            NoviPregled noviPregled = new NoviPregled();
            noviPregled.ShowDialog();
        }

        private void uiVidiPreglede_Click(object sender, EventArgs e)
        {
            MojiPregledi mojiPregledi = new MojiPregledi();
            mojiPregledi.ShowDialog();
        }
    }
}
