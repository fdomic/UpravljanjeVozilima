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
    public partial class VozilaFrm : Form
    {
        public VozilaFrm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.UcitajTablicu();
        }

        private void UcitajTablicu()
        {
            List<Vozilo> vozila = TablicaVozila.Dohvati();
            dgvTablica.DataSource = vozila;
        }

        private Vozilo DohvatiSelekciju()
        {
            if (dgvTablica.CurrentCell == null)
            {
                return null;
            }

            int index = dgvTablica.CurrentCell.RowIndex;
            DataGridViewRow row = dgvTablica.Rows[index];
            int pk = Int32.Parse(row.Cells[0].Value.ToString());

            Vozilo v = TablicaVozila.Dohvati(pk);
            return v;
        }

        private void PonistiSelekciju()
        {
            dgvTablica.CurrentCell = null;
            dgvTablica.ClearSelection();
        }

        private void PocistiFormu()
        {
           

            tbMarka.Text = "";
            tbTip.Text = "";
            tbReg.Text = "";
            btnObrisi.Visible = false;
            this.PonistiSelekciju();
        }

        private Vozilo KopirajFormaUModel()
        {
            Vozilo v = new Vozilo();
            v.marka = tbMarka.Text;
            v.tip = tbTip.Text;
            v.registracija = tbReg.Text;
            return v;
        }

        private void KopirajModelUFormu(Vozilo v)
        {
            tbMarka.Text = v.marka;
            tbTip.Text = v.tip;
            tbReg.Text = v.registracija;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            bool spremljeno = false;

            if (tbReg.Text == "")
            {
                lbGreska.Text = "Registracijska oznaka ne može biti prazna!";
                lbGreska.Visible = true;
                return;
            }

            Vozilo selektiranoVozilo = this.DohvatiSelekciju();
            if(selektiranoVozilo != null )
            {
                try
                {
                    Vozilo v = this.KopirajFormaUModel();
                    v.id = selektiranoVozilo.id;
                    TablicaVozila.Azuriraj(v);
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
                    Vozilo v = this.KopirajFormaUModel();
                    TablicaVozila.Spremi(v);
                    spremljeno = true;
                }
                catch (Exception)
                {
                    lbGreska.Text = "Spremanje neuspjelo!";
                    lbGreska.Visible = true;
                }
            }

            if(spremljeno)
            {
                lbGreska.Visible = false;

                this.UcitajTablicu();
                this.PocistiFormu();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            Vozilo selektiranoVozilo = this.DohvatiSelekciju();
            TablicaVozila.Obrisi(selektiranoVozilo);


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
            Vozilo v = this.DohvatiSelekciju();
            this.KopirajModelUFormu(v);
        }

    }
}
