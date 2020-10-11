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
    public partial class MojeTrudnoce : Form
    {
        private BindingList<Trudnoca> trudnoce = null;
        private Trudnoca odabranaTrudnoca = null;
        public MojeTrudnoce()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MojeTrudnoce_Load(object sender, EventArgs e)
        {
            TrudnocaDAO trudnocaDAO = new TrudnocaDAO();
            trudnoce = trudnocaDAO.DajTrudnoceKorisnika(Trudnica.prijavljeniKorisnik);
            if (trudnoce == null || trudnoce.Count == 0)
            {
                btnDelete.Enabled = false;
            }
            dgvMojeTrudnoce.DataSource = null;
            dgvMojeTrudnoce.DataSource = trudnoce;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            odabranaTrudnoca = dgvMojeTrudnoce.SelectedRows[0].DataBoundItem as Trudnoca;

            if (odabranaTrudnoca != null)
            {
                TrudnocaDAO trudnocaDAO = new TrudnocaDAO();
                DialogResult result = MessageBox.Show("Želite li ukloniti odabranu trudnoću iz svoje baze podataka?", "Potvrda", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    if (trudnocaDAO.ObrisiTrudnocu(odabranaTrudnoca.ID) == false)
                    {
                        MessageBox.Show("Došlo je do greške prilikom brisanja zapisa!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        trudnoce.Remove(odabranaTrudnoca);
                        MessageBox.Show("Uspjesno ste obrisali zapis!", "Obavijest", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            if (trudnoce == null || trudnoce.Count == 0)
            {
                btnDelete.Enabled = false;
            }
        }
    }
}
