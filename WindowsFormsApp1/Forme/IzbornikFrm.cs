using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportnaApp.Modeli;
using TransportnaApp.Baza;


namespace TransportnaApp.Forme
{
    public partial class IzbornikFrm : Form
    {
        
        public IzbornikFrm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void IzbornikFrm_Loaded(object sender, EventArgs e)
        {
            PocetnaFrm p = (PocetnaFrm)this.MdiParent;
            lblImeKorisnika.Text = p.prijavljeniZaposlenik.puniNaziv;
            this.DodjelaOvlasti();

        }
        
        private void DodjelaOvlasti()
        {
            Zaposlenik z = ((PocetnaFrm)MdiParent).prijavljeniZaposlenik;
            if (z.tipFK != 1)
            {
                btnIzradaNaloga.Visible = false;
                btnVozila.Visible = false;
                btnVozaci.Visible = false;
                btnDodVozila.Visible = false;
                
                panel2.Visible = false;
                panel6.Visible = false;
                panel8.Visible = false;
                panel12.Visible = false;
            }

        }


        private Form GetMdiParent()
        {
            return this.MdiParent;
        }

        private void btnVozila_Click(object sender, EventArgs e)
        {
            Form vozila = new VozilaFrm();
            vozila.MdiParent = this.MdiParent;
            vozila.Show();
        }

        private void btnVozaci_Click(object sender, EventArgs e)
        {
            Form zaposlenici = new ZaposleniciFrm();
            zaposlenici.MdiParent = this.MdiParent;
            zaposlenici.Show();
        }

        private void btnDodjelaVozila_Click(object sender, EventArgs e)
        {
            Form dodjelaVozila = new DodjelaVozilaFrm();
            dodjelaVozila.MdiParent = this.MdiParent;
            dodjelaVozila.Show();
        }

        private void btnNalozi_Click(object sender, EventArgs e)
        {

            Form NaloziFrm = new NaloziFrm();
            NaloziFrm.MdiParent = this.MdiParent;
            NaloziFrm.Show();
        }

        private void btOdjava_Click(object sender, EventArgs e)
        {
            Form login = new LoginFrm();
            login.MdiParent = this.MdiParent;
            login.Show();

            this.Close();


        }

        private void btnZVozila_Click(object sender, EventArgs e)
        {
            Form login = new ZauzetaVozilaFrm();
            login.MdiParent = this.MdiParent;
            login.Show();
        }

        private void btPutniNalog_Click(object sender, EventArgs e)
        {
            Form login = new NalogZaSluzbenoPutovanjefrm();
            login.MdiParent = this.MdiParent;
            login.Show();
        }
    }
}
