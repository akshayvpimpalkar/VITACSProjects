using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRestService_insert
{
    interface IRepository
    {
        bool InsertMyLog(int UserId, string Password);
        List<Log> Display();
    }
}
