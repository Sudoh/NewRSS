using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ExceptionHandler : Exception
    {
        public ExceptionHandler(string message) : base (message)
        {

        }
    }
}
