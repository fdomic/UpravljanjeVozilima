using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportnaApp.Baza;
using TransportnaApp.Modeli;
using TransportnaApp.Utils;

namespace TransportnaApp.Forme
{
    public partial class DodjelaVozilaFrm : Form
    {
        public DodjelaVozila SelektiranNalog { get; set; }

        public DodjelaVozilaFrm()
        {
            InitializeComponent();
            this.NapuniListuRegistracija();
            this.NapuniListuimePrezime();
        }
        
        private void DodjelaVozilaFrm_Load(object sender, EventArgs e)
        {
            this.KopirajModelUFormu(this.SelektiranNalog);
            this.DodjelaOvlasti();
        }

        private void DodjelaOvlasti()
        {
            Zaposlenik z = ((PocetnaFrm)this.MdiParent).prijavljeniZaposlenik;
            if (z.tipFK != 1)
            {
                btSpremi.Visible = false;
                cbImePrezime.Enabled = false;
                cbReg.Enabled = false;
            }

        }

        private void NapuniListuRegistracija()
        {
            double v1 = Util.PretvoriDatumUtimestamp(Util.StartOfDay(dtPreuzimanje.Value));
            double v2 = Util.PretvoriDatumUtimestamp(Util.EndOfDay(dtDostave.Value));

            List<Vozilo> vozila = TablicaVozila.DohvatiSlobodne(v1, v2);
            cbReg.DataSource = vozila;
            cbReg.DisplayMember = "registracija";
        }

        private void NapuniListuimePrezime()
        {
            double v1 = Util.PretvoriDatumUtimestamp(Util.StartOfDay(dtPreuzimanje.Value));
            double v2 = Util.PretvoriDatumUtimestamp(Util.EndOfDay(dtDostave.Value));

            List<Zaposlenik> Zaposlenik = TablicaZaposlenika.DohvatiSlobodnogVozaca(v1, v2);
            cbImePrezime.DataSource = Zaposlenik;
            cbImePrezime.DisplayMember = "puniNaziv";
        }

        private void cbReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            Vozilo v = (Vozilo)cbReg.SelectedValue;
            tbMarka.Text = v.marka;
            tbTip.Text = v.tip;

        }

        private void cbImePrezime_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zaposlenik z = (Zaposlenik)cbImePrezime.SelectedValue;
            tbOib.Text = z.oib;
            tbDatumRod.Text = Util.PretvoriTmestampUdatum(z.datumRod).ToString("dd.MM.yyyy.");
        }

        private DodjelaVozila KopirajFormaUModel()
        {
            DodjelaVozila d = new DodjelaVozila();
            d.idVozilo = ((Vozilo)cbReg.SelectedValue).id;
            d.idZaposlenik = ((Zaposlenik)cbImePrezime.SelectedValue).id;
            d.naziv = tbNaziv.Text;
            d.mjestoPreuzimanja = tbMjPreuzimanja.Text;
            d.datumPreuzimanja = Util.PretvoriDatumUtimestamp(Util.StartOfDay(dtPreuzimanje.Value));
            d.mjestoDostave = tbMjDostave.Text;
            d.datumDostave = Util.PretvoriDatumUtimestamp(Util.EndOfDay(dtDostave.Value));

            return d;

        }

        private void KopirajModelUFormu(DodjelaVozila v)
        {
            if (v == null)
            {
                return;
            }

            tbNaziv.Text = v.naziv;
            tbMjPreuzimanja.Text = v.mjestoPreuzimanja;
            dtPreuzimanje.Value = Util.PretvoriTmestampUdatum(v.datumPreuzimanja);
            tbMjDostave.Text = v.mjestoDostave;
            dtDostave.Value = Util.PretvoriTmestampUdatum(v.datumDostave);
            cbImePrezime.SelectedItem = cbImePrezime.Items.Cast<Zaposlenik>().First(item => item.id == v.idZaposlenik);
            cbReg.SelectedItem = cbReg.Items.Cast<Vozilo>().First(item => item.id == v.idVozilo);


        }
        
        private void btSpremi_Click(object sender, EventArgs e)
        {

            if(this.SelektiranNalog != null)
            {
                DodjelaVozila d = this.KopirajFormaUModel();
                d.id = this.SelektiranNalog.id;
                TablicaDodjeljenaVozila.Azuriraj(d);
            }
            else
            {
                DodjelaVozila d = this.KopirajFormaUModel();
                TablicaDodjeljenaVozila.Spremi(d);
            }
            

            this.Close();

        }

        private void dtPreuzimanje_ValueChanged(object sender, EventArgs e)
        {
            this.NapuniListuRegistracija();
        }

        private void dtDostave_ValueChanged(object sender, EventArgs e)
        {
            this.NapuniListuRegistracija();
        }

        private void btNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
 
}
