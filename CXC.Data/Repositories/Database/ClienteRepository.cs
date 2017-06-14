using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CXC.Data.Repositories.Database
{
    public class ClienteRepository : IClienteRepository
    {
        readonly CXCDbContext _dbContext;
        public ClienteRepository(CXCDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Cliente> GetAll()
        {
            return _dbContext.Clientes.ToList();
        }
    }
}
