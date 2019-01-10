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
using TransportnaApp.Utils;

namespace TransportnaApp.Forme
{
    public partial class ZauzetaVozilaFrm : Form
    {

        public ZauzetaVozilaFrm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.GenerirajTablicu();
            this.UcitajTablicu();
        }

        private void GenerirajTablicu()
        {
            dgvTablica.AutoGenerateColumns = false;
            dgvTablica.ColumnCount = 3;

            dgvTablica.Columns[0].Name = "marka";
            dgvTablica.Columns[0].HeaderText = "Marka";
            dgvTablica.Columns[0].DataPropertyName = "marka";

            dgvTablica.Columns[1].Name = "tip";
            dgvTablica.Columns[1].HeaderText = "Tip";
            dgvTablica.Columns[1].DataPropertyName = "tip";

            dgvTablica.Columns[2].Name = "registracija";
            dgvTablica.Columns[2].HeaderText = "Registracija";
            dgvTablica.Columns[2].DataPropertyName = "registracija";
        }

        private void UcitajTablicu()
        {

            double v1 = Util.PretvoriDatumUtimestamp(Util.StartOfDay(dtDatum.Value));
            
            List<Vozilo> vozila = TablicaVozila.DohvatiZauzetaVozila(v1);
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
        
        private void dtDatum_ValueChanged(object sender, EventArgs e)
        {
            UcitajTablicu();
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
