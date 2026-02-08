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
            var formAddCliente = new FormAddCliente();
            formAddCliente.Show();
        }

        public void AddItem(object item)
        {
            cbxAddCliente.Items.Add(item);
        }
    }
}
