using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CXC.WinApp.Controllers
{
    public class BaseController<TRepository>
    {
        protected readonly TRepository _Repository;
        public BaseController(TRepository repository)
        {
            _Repository = repository;
        }
    }
}
