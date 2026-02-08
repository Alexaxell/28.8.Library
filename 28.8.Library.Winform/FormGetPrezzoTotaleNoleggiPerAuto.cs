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
    public partial class FormGetPrezzoTotaleNoleggiPerAuto: Form
    {
        public FormGetPrezzoTotaleNoleggiPerAuto()
        {
            InitializeComponent();
        }

        private void FormGetPrezzoTotaleNoleggiPerAuto_Load(object sender, EventArgs e)
        {
            var gestoreNoleggi = new GetsoreNoleggi();
            gestoreNoleggi.Clienti = Archivio.Clienti;
            gestoreNoleggi.Veicoli = Archivio.Veicoli;
            gestoreNoleggi.Noleggi = Archivio.Noleggi;

            lstPrezzi.Items.Add(gestoreNoleggi.GetPrezzoTotaleNoleggiPerAuto());
        }
    }
}
