using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CXC.Data.Repositories
{
    public interface IClienteRepository
    {
        List<Cliente> GetAll();
    }
}
