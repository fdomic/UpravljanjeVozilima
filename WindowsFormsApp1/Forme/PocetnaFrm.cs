using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransportnaApp.Forme;
using TransportnaApp.Modeli;
using TransportnaApp.Baza;
	

namespace TransportnaApp
{
    public partial class PocetnaFrm : Form
    {
        public Zaposlenik prijavljeniZaposlenik { get; set; }
 
        public PocetnaFrm()
        {
            InitializeComponent();

            //Postavi da je ovaj prozor glavni i da se svi otvaranju unutar njega
            this.IsMdiContainer = true;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //Stavi praznu traku
            this.MainMenuStrip = new MenuStrip();

            Form izbornik = new LoginFrm();
            izbornik.MdiParent = this;
            izbornik.Show();
        }
    }
}
