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

namespace TransportnaApp.Forme
{
    public partial class NaloziFrm : Form
    {

        public NaloziFrm()
        {
            InitializeComponent();
            this.GenerirajTablicu();
           
        }
        
        private void NaloziFrm_Load(object sender, EventArgs e)
        {
            this.tablicaNalozi();
        }

        public void tablicaNalozi()
        {
            List<DodjelaVozila> vozila;

            Zaposlenik z = ((PocetnaFrm)this.MdiParent).prijavljeniZaposlenik;
            if (z.tipFK != 1)
            {
                vozila = TablicaDodjeljenaVozila.DohvatiPoKorisniku(z.id);
            }
            else
            {
                vozila = TablicaDodjeljenaVozila.Dohvati();
            }

            dgTablicaNalozi.DataSource = vozila;
        }

        private void GenerirajTablicu()
        {
            dgTablicaNalozi.AutoGenerateColumns = false;
            dgTablicaNalozi.ColumnCount = 8;

            dgTablicaNalozi.Columns[0].Name = "id";
            dgTablicaNalozi.Columns[0].HeaderText = "#";
            dgTablicaNalozi.Columns[0].DataPropertyName = "id";
            dgTablicaNalozi.Columns[0].Width = 50;

            dgTablicaNalozi.Columns[1].Name = "nazivVozila";
            dgTablicaNalozi.Columns[1].HeaderText = "Naziv vozila";
            dgTablicaNalozi.Columns[1].DataPropertyName = "nazivVozila";

            dgTablicaNalozi.Columns[2].Name = "nazivZaposlenik";
            dgTablicaNalozi.Columns[2].HeaderText = "Naziv zaposlenika";
            dgTablicaNalozi.Columns[2].DataPropertyName = "nazivZaposlenik";

            dgTablicaNalozi.Columns[3].Name = "naziv";
            dgTablicaNalozi.Columns[3].HeaderText = "Naziv";
            dgTablicaNalozi.Columns[3].DataPropertyName = "naziv";

            dgTablicaNalozi.Columns[4].Name = "mjestoPreuzimanja";
            dgTablicaNalozi.Columns[4].HeaderText = "Mjesto dostave";
            dgTablicaNalozi.Columns[4].DataPropertyName = "mjestoPreuzimanja";

            dgTablicaNalozi.Columns[5].Name = "datumPreuzimanjaEkran";
            dgTablicaNalozi.Columns[5].HeaderText = "Datum preuzimanja";
            dgTablicaNalozi.Columns[5].DataPropertyName = "datumPreuzimanjaEkran";

            dgTablicaNalozi.Columns[6].Name = "mjestoDostave";
            dgTablicaNalozi.Columns[6].HeaderText = "Mjesto dostave";
            dgTablicaNalozi.Columns[6].DataPropertyName = "mjestoDostave";

            dgTablicaNalozi.Columns[7].Name = "datumDostaveEkran";
            dgTablicaNalozi.Columns[7].HeaderText = "Datum dostave";
            dgTablicaNalozi.Columns[7].DataPropertyName = "datumDostaveEkran";

            
        }

        private void btNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PonistiSelekciju()
        {
            dgTablicaNalozi.CurrentCell = null;
            dgTablicaNalozi.ClearSelection();
        }

        private void dgvTablica_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.PonistiSelekciju();
        }

        private DodjelaVozila DohvatiSelekciju()
        {
            if (dgTablicaNalozi.CurrentCell == null)
            {
                return null;
            }

            int index = dgTablicaNalozi.CurrentCell.RowIndex;
            DataGridViewRow row = dgTablicaNalozi.Rows[index];
            int pk = Int32.Parse(row.Cells[0].Value.ToString());

            DodjelaVozila v = TablicaDodjeljenaVozila.Dohvati(pk);
            return v;
        }

        private void dgTablicaNalozi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DodjelaVozilaFrm dodjelaVozila = new DodjelaVozilaFrm();
            dodjelaVozila.SelektiranNalog = this.DohvatiSelekciju();
            dodjelaVozila.MdiParent = this.MdiParent;
            dodjelaVozila.Show();
            this.Close();
        }
        
    }
}
