using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClsLibInterface
{
    public interface IUsers
    {
        string uname { get; set; }

        string upass { get; set; }

        string empid { get; set; }
    }
}
