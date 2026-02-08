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
    public partial class FormGetPrezzoTotaleNoleggiDallaTarga: Form
    {
        public FormGetPrezzoTotaleNoleggiDallaTarga()
        {
            InitializeComponent();
        }

        private void btnCalcolo_Click(object sender, EventArgs e)
        {
            var gestoreNoleggi = new GetsoreNoleggi();
            gestoreNoleggi.Clienti = Archivio.Clienti;
            gestoreNoleggi.Veicoli = Archivio.Veicoli;
            gestoreNoleggi.Noleggi = Archivio.Noleggi;

            lblRisultato.Text = (gestoreNoleggi.GetPrezzoTotaleNoleggiDallaTarga(txtTarga.Text)).ToString();
        }
    }
}
