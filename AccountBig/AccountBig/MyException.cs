using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBig
{
    class MyException:ApplicationException
    {
        public string msg;
        public MyException(string msg)
        {
            this.msg = msg;
        }
    }
}
