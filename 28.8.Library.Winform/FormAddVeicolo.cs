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
    public partial class FormAddVeicolo: Form
    {
        public FormAddVeicolo()
        {
            InitializeComponent();
        }

        private void btnAddAutomobile_Click(object sender, EventArgs e)
        {
            Archivio.Veicoli.Add(new Automobile()
            {
                Targa = txtTargaAutomobile.Text,
                Modello = txtModelloAutomobile.Text,
                Tariffa = double.Parse(txtTariffaAutomobile.Text),
                NumeroDiPosti = int.Parse(txtNumeroDiPostiAutomobile.Text)
            });
        }

        private void btnAddFurgone_Click(object sender, EventArgs e)
        {
            Archivio.Veicoli.Add(new Furgone()
            {
                Targa = txtTargaFurgone.Text,
                Modello = txtModelloFurgone.Text,
                Tariffa = double.Parse(txtTariffaFurgone.Text),
                CapacitaDiCarico = double.Parse(txtCapacitaDiCaricoFurgone.Text)
            });
        }
    }
}
