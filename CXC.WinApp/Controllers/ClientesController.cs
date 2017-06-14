using CXC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CXC.Data.Repositories;

namespace CXC.WinApp.Controllers
{
    public class ClientesController : BaseController<IClienteRepository>
    {
        public ClientesController(IClienteRepository repository) : base(repository)
        {

        }

        public List<Cliente> GetAll()
        {
            return _Repository.GetAll();
        }
    }
}
