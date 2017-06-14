using CXC.Data;
using CXC.Data.Repositories;
using CXC.Data.Repositories.Database;
using CXC.WinApp.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CXC.WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CXC"].ConnectionString;
            CXCDbContext _dbContext = new CXCDbContext(connectionString);
            IClienteRepository clienteRepo = new ClienteRepository(_dbContext);
            ClientesController cc = new ClientesController(clienteRepo);

            this.allClientes1.Model = cc.GetAll();
        }
    }
}
