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
    }
}
