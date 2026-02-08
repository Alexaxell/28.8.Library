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
    public partial class FormSalvaSuCsv: Form
    {
        public FormSalvaSuCsv()
        {
            InitializeComponent();
        }

        private void btnVeicoli_Click(object sender, EventArgs e)
        {
            var gestoreNoleggi = new GetsoreNoleggi();
            gestoreNoleggi.Veicoli = Archivio.Veicoli;

            gestoreNoleggi.SalvaSuCSV_Veicoli(txtFilePath.Text);
        }

        private void btnClienti_Click(object sender, EventArgs e)
        {
            var gestoreNoleggi = new GetsoreNoleggi();
            gestoreNoleggi.Clienti = Archivio.Clienti;

            gestoreNoleggi.SalvaSuCSV_Clienti(txtFilePath.Text);
        }

        private void btnNoleggi_Click(object sender, EventArgs e)
        {
            var gestoreNoleggi = new GetsoreNoleggi();
            gestoreNoleggi.Noleggi = Archivio.Noleggi;

            gestoreNoleggi.SalvaSuCSV_Noleggi(txtFilePath.Text);
        }
    }
}
