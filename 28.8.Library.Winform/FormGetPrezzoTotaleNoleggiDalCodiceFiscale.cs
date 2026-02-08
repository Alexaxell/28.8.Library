using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28._8.Library.Winform
{
    public partial class FormGetPrezzoTotaleNoleggiDalCodiceFiscale: Form
    {
        public FormGetPrezzoTotaleNoleggiDalCodiceFiscale()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            var gestoreNoleggi = new GetsoreNoleggi();
            gestoreNoleggi.Clienti = Archivio.Clienti;
            gestoreNoleggi.Veicoli = Archivio.Veicoli;
            gestoreNoleggi.Noleggi = Archivio.Noleggi;

            lblRisultato.Text = (gestoreNoleggi.GetPrezzoTotaleNoleggiDalCodiceFiscale(txtCodiceFiscale.Text)).ToString();
        }
    }
}
