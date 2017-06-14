using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CXC.Data;

namespace CXC.WinApp.Views.Clientes
{
    public partial class AllClientes : UserControl
    {
        public AllClientes()
        {
            InitializeComponent();
        }

        public List<Cliente> Model { get; set; }

        private void AllClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void AllClientes_Enter(object sender, EventArgs e)
        {
            grdClientes.DataSource = Model;
        }
    }
}
