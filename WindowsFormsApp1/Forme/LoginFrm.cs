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
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Zaposlenik z = TablicaZaposlenika.Dohvati(tbUser.Text, tbPass.Text);
            if ( z == null )
            {
                lbGreska.Visible = true;
                return;
            }

            PocetnaFrm p = (PocetnaFrm)this.MdiParent;
            p.prijavljeniZaposlenik = z;

            Form izbornik = new IzbornikFrm();
            izbornik.MdiParent = this.MdiParent;
            izbornik.Show();
        }

        private void tbUser_Enter(object sender, EventArgs e)
        {
            //tbUser.Text = "";
        }

        private void tbPass_Enter(object sender, EventArgs e)
        {
            //tbPass.Text = "";

        }

        private void tbPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }


    }
}
