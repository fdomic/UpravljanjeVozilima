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
    public partial class ZaposleniciFrm : Form
    {
        public ZaposleniciFrm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.GenerirajTablicu();
            this.UcitajTablicu();

            this.NapuniListuTip();
        }

        private void NapuniListuTip()
        {
            List<ZaposlenikTip> zaposlenik = TablicaZaposleniciTip.Dohvati();
            cbTip.DataSource = zaposlenik;
            cbTip.DisplayMember = "naziv";
        }

        private void GenerirajTablicu()
        {
            dgvTablica.AutoGenerateColumns = false;
            dgvTablica.ColumnCount = 3;

            dgvTablica.Columns[0].Name = "id";
            dgvTablica.Columns[0].HeaderText = "#";
            dgvTablica.Columns[0].DataPropertyName = "id";

            dgvTablica.Columns[1].Name = "puniNaziv";
            dgvTablica.Columns[1].HeaderText = "Ime i prezime";
            dgvTablica.Columns[1].DataPropertyName = "puniNaziv";

            dgvTablica.Columns[2].Name = "oib";
            dgvTablica.Columns[2].HeaderText = "OIB";
            dgvTablica.Columns[2].DataPropertyName = "oib";
        }

        private void UcitajTablicu()
        {
            List<Zaposlenik> vozila = TablicaZaposlenika.Dohvati();
            dgvTablica.DataSource = vozila;
        }

        private Zaposlenik DohvatiSelekciju()
        {
            if (dgvTablica.CurrentCell == null)
            {
                return null;
            }

            int index = dgvTablica.CurrentCell.RowIndex;
            DataGridViewRow row = dgvTablica.Rows[index];
            int pk = Int32.Parse(row.Cells[0].Value.ToString());

            Zaposlenik v = TablicaZaposlenika.Dohvati(pk);
            return v;
        }

        private void PonistiSelekciju()
        {
            dgvTablica.CurrentCell = null;
            dgvTablica.ClearSelection();
        }

        private void PocistiFormu()
        {
            tbIme.Text = "";
            tbPrezime.Text = "";
            tbOib.Text= "";
            dtDatumRod.Value = DateTime.Today;
            
            btnObrisi.Visible = false;
            this.PonistiSelekciju();
        }

        private Zaposlenik KopirajFormaUModel()
        {
            Zaposlenik v = new Zaposlenik();
            v.ime = tbIme.Text;
            v.prezime = tbPrezime.Text;
            v.oib = tbOib.Text;
            v.datumRod = Util.PretvoriDatumUtimestamp(dtDatumRod.Value);
            v.tipFK = ((ZaposlenikTip)cbTip.SelectedValue).id;
            return v;
        }

        private void KopirajModelUFormu(Zaposlenik v)
        {
            tbIme.Text = v.ime;
            tbPrezime.Text = v.prezime;
            tbOib.Text = v.oib;
            dtDatumRod.Value = Util.PretvoriTmestampUdatum(v.datumRod);
            cbTip.SelectedItem = cbTip.Items.Cast<ZaposlenikTip>().First(item => item.id == v.tipFK);
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            Zaposlenik selektiranoZaposlenik = this.DohvatiSelekciju();
            if (selektiranoZaposlenik != null)
            {
                Zaposlenik v = this.KopirajFormaUModel();
                v.id = selektiranoZaposlenik.id;
                TablicaZaposlenika.Azuriraj(v);
            }
            else
            {
                Zaposlenik v = this.KopirajFormaUModel();
                TablicaZaposlenika.Spremi(v);
            }

            this.UcitajTablicu();
            this.PocistiFormu();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Zaposlenik selektiraniZaposlenik = this.DohvatiSelekciju();
            TablicaZaposlenika.Obrisi(selektiraniZaposlenik);


            this.UcitajTablicu();
            this.PocistiFormu();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTablica_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.PonistiSelekciju();
        }

        private void dgvTablica_RedakSelektiran(object sender, DataGridViewCellEventArgs e)
        {
            btnObrisi.Visible = true;
            Zaposlenik v = this.DohvatiSelekciju();
            this.KopirajModelUFormu(v);
        }

        private void tbOib_Leave(object sender, EventArgs e)
        {
            bool ispravan = Util.ProvjeriOIB(tbOib.Text);
            if(!ispravan) 
            {

                lbGreskaoOib.Visible = true;
                Console.WriteLine("Nespravan OIB");
            } else
            {

                lbGreskaoOib.Visible = false;
                Console.WriteLine("OK OIB");

            }
        }
    }
}
