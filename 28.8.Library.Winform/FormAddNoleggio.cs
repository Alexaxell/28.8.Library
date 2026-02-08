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
    public partial class FormAddNoleggio: Form
    {
        public FormAddNoleggio()
        {
            InitializeComponent();
        }

        private void FormAddNoleggio_Load(object sender, EventArgs e)
        {
            cbxAddCliente.DataSource = null;
            cbxAddCliente.DataSource = Archivio.Clienti;
            cbxAddVeicolo.DataSource = null;
            cbxAddVeicolo.DataSource = Archivio.Veicoli;
        }

        private void FormAddNoleggio_Activated(object sender, EventArgs e)
        {
            cbxAddCliente.DataSource = null;
            cbxAddCliente.DataSource = Archivio.Clienti;
            cbxAddVeicolo.DataSource = null;
            cbxAddVeicolo.DataSource = Archivio.Veicoli;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Archivio.Noleggi.Add(new Noleggio()
            {
                Id = txtId.Text,
                DataInizio = DateTime.Parse(dtpDataInizio.Text),
                NumeroDiGiorni = int.Parse(txtNumeroDiGiorni.Text),
                Costo = int.Parse(txtCosto.Text),
                Cliente = (Cliente)(cbxAddCliente.SelectedItem),
                Veicolo = (Veicolo)(cbxAddVeicolo.SelectedItem)
            });
        }
    }
}
