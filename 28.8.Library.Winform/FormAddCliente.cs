using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _28._8.Library.Winform
{
    public partial class FormAddCliente: Form
    {
        public FormAddCliente()
        {
            InitializeComponent();
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            Archivio.Clienti.Add(new Cliente()
            {
                CodiceFiscale = txtCodiceFiscale.Text,
                Nome = txtNome.Text,
                Cognome = txtCognome.Text
            });
        }
    }
}
