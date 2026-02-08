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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            var formAddCliente = new FormAddCliente();
            formAddCliente.ShowDialog();
        }

        private void btnAddVeicolo_Click(object sender, EventArgs e)
        {
            var formAddVeicolo = new FormAddVeicolo();
            formAddVeicolo.ShowDialog();
        }

        private void btnAddNoleggio_Click(object sender, EventArgs e)
        {
            var formAddNoleggio = new FormAddNoleggio();
            formAddNoleggio.ShowDialog();
        }

        private void btnGetPrezzoTotaleNoleggiDallaTarga_Click_1(object sender, EventArgs e)
        {
            var formGetPrezzoTotaleNoleggiDallaTarga = new FormGetPrezzoTotaleNoleggiDallaTarga();
            formGetPrezzoTotaleNoleggiDallaTarga.ShowDialog();
        }

        private void btnGetPrezzoTotaleNoleggiDalCodiceFiscale_Click(object sender, EventArgs e)
        {
            var formGetPrezzoTotaleNoleggiDalCodiceFiscale = new FormGetPrezzoTotaleNoleggiDalCodiceFiscale();
            formGetPrezzoTotaleNoleggiDalCodiceFiscale.ShowDialog();
        }

        private void btnGetPrezzoTotaleNoleggiPerAuto_Click(object sender, EventArgs e)
        {
            var formGetPrezzoTotaleNoleggiPerAuto = new FormGetPrezzoTotaleNoleggiPerAuto();
            formGetPrezzoTotaleNoleggiPerAuto.ShowDialog();
        }

        private void btnSalvaSuCSV_Click(object sender, EventArgs e)
        {
            var formSalvaSuCSV = new FormSalvaSuCsv();
            formSalvaSuCSV.ShowDialog();
        }
    }
}
