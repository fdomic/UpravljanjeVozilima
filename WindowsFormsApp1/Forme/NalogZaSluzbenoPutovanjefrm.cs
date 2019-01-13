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

    public partial class NalogZaSluzbenoPutovanjefrm : Form
    {
        public NalogZaSluzbenoPutovanjefrm()
        {
            InitializeComponent();
            UcitajTablicu();
           
        }

        private void UcitajTablicu()
        {
            List<NalogZaSluzbenoPutovanje> nalogZaSluzbena = TablicaNalogZaSluzbenoPutovanje.Dohvati();
            dgvTablica.DataSource = nalogZaSluzbena;
        }

        private NalogZaSluzbenoPutovanje DohvatiSelekciju()
        {
            if (dgvTablica.CurrentCell == null)
            {
                return null;
            }

            int index = dgvTablica.CurrentCell.RowIndex;
            DataGridViewRow row = dgvTablica.Rows[index];
            int pk = Int32.Parse(row.Cells[0].Value.ToString());

            NalogZaSluzbenoPutovanje n = TablicaNalogZaSluzbenoPutovanje.Dohvati(pk);
            return n;
        }

        private void PonistiSelekciju()
        {
            dgvTablica.CurrentCell = null;
            dgvTablica.ClearSelection();
        }

        private void PocistiFormu()
        {
            tbRazlog.Text = "" +
                "";
            tbTeret.Text  = "";
            
            this.PonistiSelekciju();
        }

        private NalogZaSluzbenoPutovanje KopirajFormaUModel()
        {
            NalogZaSluzbenoPutovanje n = new NalogZaSluzbenoPutovanje();

            n.razlog = tbRazlog.Text;
            n.teret = tbTeret.Text;

            return n;
        }

        private void KopirajModelUFormu(NalogZaSluzbenoPutovanje v)
        {
            tbRazlog.Text = v.razlog ;
            tbTeret.Text= v.teret ;

        }

        private void btSpremi_Click(object sender, EventArgs e)
        {
            bool spremljeno = false;

            NalogZaSluzbenoPutovanje selektirano = this.DohvatiSelekciju();
            if (selektirano != null)
            {
                try
                {
                    NalogZaSluzbenoPutovanje v = this.KopirajFormaUModel();
                    v.id = selektirano.id;
                    TablicaNalogZaSluzbenoPutovanje.Azuriraj(v);
                    spremljeno = true;
                }
                catch (Exception)
                {
                    lbGreska.Text = "Ažuriranje neuspjelo!";
                    lbGreska.Visible = true;
                }
            }
            else
            {
                try
                {
                    NalogZaSluzbenoPutovanje v = this.KopirajFormaUModel();
                    TablicaNalogZaSluzbenoPutovanje.Spremi(v);
                    spremljeno = true;
                }
                catch (Exception)
                {
                    lbGreska.Text = "Spremanje neuspjelo!";
                    lbGreska.Visible = true;
                }
            }

            if (spremljeno)
            {
                lbGreska.Visible = false;

                this.UcitajTablicu();
                this.PocistiFormu();
            }
        }

        private void btNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTablica_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.PonistiSelekciju();
        }

        private void btBrisi_Click(object sender, EventArgs e)
        {
            NalogZaSluzbenoPutovanje selektirano = this.DohvatiSelekciju();
            TablicaNalogZaSluzbenoPutovanje.Obrisi(selektirano);


            this.UcitajTablicu();
            this.PocistiFormu();
        }

        private void dgvTablica_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btBrisi.Visible = true;
            NalogZaSluzbenoPutovanje v = this.DohvatiSelekciju();
            this.KopirajModelUFormu(v);
        }
    }
}
